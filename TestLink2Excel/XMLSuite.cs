using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace TestLink2Excel
{
    class XMLSuite
    {
        private XmlDocument suite;

        public XMLSuite(string path)
        {
            suite = new XmlDocument();
            if (!string.IsNullOrEmpty(path))
            {
                suite.Load(path);
            }
        }


        public XMLSuite(TestSuite suite)
        {
            this.suite = new XmlDocument();
            XmlNode n = this.suite.CreateNode(XmlNodeType.XmlDeclaration,"","");
            this.suite.AppendChild(n);
            var xmlelem = writeSuite(suite);
            this.suite.AppendChild(xmlelem);
            this.suite.Save("C:/users/kszymanski/Desktop/suite.xml");
        }

        public void saveAs(string path)
        {

        }

        private XmlNode writeSuite(TestSuite suite)
        {
            XmlElement node = this.suite.CreateElement("", "testsuite", "");
            node.SetAttribute("name", suite.Name);
            foreach (TestCase tc in suite.Tcs)
            {
                node.AppendChild(writeTC(tc));
            }

            foreach (TestSuite s in suite.UnderSuits)
            {
                node.AppendChild(writeSuite(s));
            }
            return node;
            
        }

        private XmlNode writeTC(TestCase tc)
        {
            XmlElement node = this.suite.CreateElement("", "testcase", "");
            node.SetAttribute("name", tc.Name);

            if (tc.Steps.Count > 0)
            {
                XmlElement steps = this.suite.CreateElement("", "steps", "");
                foreach (Step step in tc.Steps)
                {
                    steps.AppendChild(writeStep(step));
                }
                node.AppendChild(steps);
            }

        }

        private XmlNode writeStep(Step step)
        {
            throw new NotImplementedException();
        }

        public List<TestSuite> makeTestSuite()
        {
            List<TestSuite> suite = new List<TestSuite>();
            foreach (XmlNode node in this.suite.ChildNodes)
            {
                if (node.Name == "testsuite") suite.Add(addSuite(node));
            }
            return suite;
        }

        private TestSuite addSuite(XmlNode node)
        {
            string name = node.Attributes[0].InnerText != null && node.Attributes[0].InnerText != string.Empty ? node.Attributes[0].InnerText : "<<Test Suite>>";
            TestSuite suite = new TestSuite(name, string.Empty);
            foreach (XmlNode n in node.ChildNodes)
            {
                if (n.Name == "testsuite") suite.UnderSuits.Add(addSuite(n));
                else if (n.Name == "testcase") suite.addTestCase(addCase(n));
                else if (n.Name == "details") suite.Description = n.Value;
            }
            return suite;
        }

        private TestCase addCase(XmlNode node)
        {
            TestCase testCase = new TestCase(node.Attributes[1].InnerText);
            foreach (XmlNode n in node.ChildNodes)
            {
                if (n.Name == "preconditions") testCase.Preconditions = n.InnerText;
                else if (n.Name == "summary") testCase.Summary = n.InnerText;
                else if (n.Name == "externalid") testCase.Id = int.Parse(n.InnerText);
                else if (n.Name == "steps") testCase.Steps = addSteps(n);
            }
            return testCase;
        }

        private List<Step> addSteps(XmlNode node)
        {
            List<Step> steps = new List<Step>();
            foreach (XmlNode n in node.ChildNodes)
            {
                Step step = addStep(n);
                steps.Add(step);
            }
            return steps;
        }

        private Step addStep(XmlNode node)
        {
            Step step = new Step();
            foreach (XmlNode n in node.ChildNodes)
            {
                if (n.Name == "step_number") step.StepNumber = int.Parse(n.InnerText);
                else if (n.Name == "actions") step.Action = n.InnerText;
                else if (n.Name == "expectedresults") step.ExpectedResult = n.InnerText;
            }
            return step;
        }
    }
}
