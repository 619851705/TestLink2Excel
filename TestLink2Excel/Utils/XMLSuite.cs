using System.Collections.Generic;
using System.Xml;
using TestLink2Excel.Model;

namespace TestLink2Excel.Utils
{
	public class XMLSuite
	{
		private XmlDocument suite;
		private XmlElement root;

		public XMLSuite(string path)
		{
			suite = new XmlDocument();

			if (!string.IsNullOrEmpty(path))
				suite.Load(path);
		}

		public XMLSuite()
		{
			this.suite = new XmlDocument();
			XmlNode n = this.suite.CreateNode(XmlNodeType.XmlDeclaration, "", "");
			this.suite.AppendChild(n);
			this.root = this.suite.CreateElement("", "testsuite", "");
			this.suite.AppendChild(root);
		}

		public void AddSuite(TestSuite suite)
		{
			var xmlelem = WriteSuite(suite);
			this.root.AppendChild(xmlelem);
		}

		public void SaveAs(string path)
		{
			this.suite.Save(path);
		}

		private XmlNode WriteSuite(TestSuite suite)
		{
			XmlElement node = this.suite.CreateElement("", "testsuite", "");
			node.SetAttribute("name", suite.Name);

			foreach (TestCase tc in suite.Tcs)
				node.AppendChild(WriteTC(tc));

			foreach (TestSuite s in suite.UnderSuits)
				node.AppendChild(WriteSuite(s));

			return node;
		}

		private XmlNode WriteTC(TestCase tc)
		{
			XmlElement node = this.suite.CreateElement("", "testcase", "");
			node.SetAttribute("name", tc.Name);
			XmlElement externalid = this.suite.CreateElement("", "externalid", "");
			externalid.AppendChild(this.suite.CreateCDataSection(tc.Id.ToString()));
			node.AppendChild(externalid);
			XmlElement summary = this.suite.CreateElement("", "summary", "");
			summary.AppendChild(this.suite.CreateCDataSection(tc.Summary));
			node.AppendChild(summary);
			XmlElement preconditions = this.suite.CreateElement("", "preconditions", "");
			preconditions.AppendChild(this.suite.CreateCDataSection(tc.Preconditions));
			node.AppendChild(preconditions);

			if (tc.Steps.Count > 0)
			{
				XmlElement steps = this.suite.CreateElement("", "steps", "");

				foreach (Step step in tc.Steps)
					steps.AppendChild(WriteStep(step));

				node.AppendChild(steps);
			}

			return node;
		}

		private XmlNode WriteStep(Step step)
		{
			XmlElement node = this.suite.CreateElement("", "step", "");
			XmlElement stepNumber = this.suite.CreateElement("", "step_number", "");
			stepNumber.AppendChild(this.suite.CreateCDataSection(step.StepNumber.ToString()));
			node.AppendChild(stepNumber);
			XmlElement actions = this.suite.CreateElement("", "actions", "");
			actions.AppendChild(this.suite.CreateCDataSection(step.Action));
			node.AppendChild(actions);
			XmlElement expectedresults = this.suite.CreateElement("", "expectedresults", "");
			expectedresults.AppendChild(this.suite.CreateCDataSection(step.ExpectedResult));
			node.AppendChild(expectedresults);

			return node;
		}

		public List<TestSuite> MakeTestSuite()
		{
			List<TestSuite> suite = new List<TestSuite>();

			foreach (XmlNode node in this.suite.ChildNodes)
				if (node.Name == "testsuite")
					suite.Add(AddSuite(node));

			return suite;
		}

		private TestSuite AddSuite(XmlNode node)
		{
			string name = node.Attributes.Count > 0 && node.Attributes[0].InnerText != null && node.Attributes[0].InnerText != string.Empty ? node.Attributes[0].InnerText : "<<Test Suite>>";
			TestSuite suite = new TestSuite(name, string.Empty);

			foreach (XmlNode n in node.ChildNodes)
			{
				if (n.Name == "testsuite")
					suite.UnderSuits.Add(AddSuite(n));
				else if (n.Name == "testcase")
					suite.AddTestCase(AddCase(n));
				else if (n.Name == "details")
					suite.Description = n.Value;
			}

			return suite;
		}

		private TestCase AddCase(XmlNode node)
		{
			TestCase testCase = new TestCase(node.Attributes[1].InnerText);

			foreach (XmlNode n in node.ChildNodes)
			{
				if (n.Name == "preconditions")
					testCase.Preconditions = n.InnerText;
				else if (n.Name == "summary")
					testCase.Summary = n.InnerText;
				else if (n.Name == "externalid")
					testCase.Id = int.Parse(n.InnerText);
				else if (n.Name == "steps")
					testCase.Steps = AddSteps(n);
			}

			return testCase;
		}

		private List<Step> AddSteps(XmlNode node)
		{
			List<Step> steps = new List<Step>();

			foreach (XmlNode n in node.ChildNodes)
			{
				Step step = AddStep(n);
				steps.Add(step);
			}

			return steps;
		}

		private Step AddStep(XmlNode node)
		{
			Step step = new Step();

			foreach (XmlNode n in node.ChildNodes)
			{
				if (n.Name == "step_number")
					step.StepNumber = int.Parse(n.InnerText);
				else if (n.Name == "actions")
					step.Action = n.InnerText;
				else if (n.Name == "expectedresults")
					step.ExpectedResult = n.InnerText;
			}

			return step;
		}
	}
}
