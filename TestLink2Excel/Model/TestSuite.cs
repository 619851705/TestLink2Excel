using System.Collections.Generic;
using System.ComponentModel;

namespace TestLink2Excel.Model
{
	public class TestSuite : INotifyPropertyChanged
	{
		#region Fields

		private string name;

		#endregion

		#region Properties

		public List<TestSuite> UnderSuits { get; set; }
		public List<TestCase> Tcs { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
				this.NotifyPropertyChanged("Name");
			}
		}

		public string VisibleName
		{
			get
			{
				return string.IsNullOrEmpty(this.name) ? "<NoName>" : this.name;
			}
		}

		public string Description { get; set; }

		#endregion

		#region Constructors

		public TestSuite(string name, string descryption)
		{
			this.Name = name;
			this.Description = descryption;
			this.UnderSuits = new List<TestSuite>();
			this.Tcs = new List<TestCase>();
		}
		#endregion

		public void AddTestCase(TestCase tc)
		{
			this.Tcs.Add(tc);
		}

		public int GetSuitsDeep()
		{
			int i = 0;

			foreach (TestSuite suite in UnderSuits)
			{
				int under = suite.GetSuitsDeep();

				if (i < under)
					i = under;
			}

			return i + 1;
		}

		private void NotifyPropertyChanged(string info)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(info));
		}
	}
}
