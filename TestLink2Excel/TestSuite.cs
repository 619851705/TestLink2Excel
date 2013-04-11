using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLink2Excel
{
    class TestSuite
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                ObjectHelper.RaiseChanged(this);
            }
        }
        public string Description { get; set; }

        public List<TestSuite> UnderSuits { get; set; }
        public List<TestCase> Tcs { get; set; }

        public TestSuite(string name, string descryption)
        {
            Name = name;
            Description = descryption;
            UnderSuits = new List<TestSuite>();
            Tcs = new List<TestCase>();
        }
        
        public void addTestCase(TestCase tc)
        {
            Tcs.Add(tc);
        }
        public int getSuitsDeep()
        {
            int i = 0;
            foreach (TestSuite suite in UnderSuits)
            {
                int under = suite.getSuitsDeep();
                if (i < under) i = under;
            }
            return i+1;
        }
    }
}
