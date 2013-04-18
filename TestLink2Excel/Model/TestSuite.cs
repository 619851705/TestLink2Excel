using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using TestLink2Excel.Utils;
using System.ComponentModel;

namespace TestLink2Excel.Model
{
    public class TestSuite : INotifyPropertyChanged
    {
        #region Fields
        private string name;
        private string description;
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
                NotifyPropertyChanged("Name");
            }
        }

        public string Description
        {
             get
            {
                return this.description;
            }
            set
            {
                this.description = value;
                NotifyPropertyChanged("Descryption");
            }
        }

        #endregion

        #region Constructors
        public TestSuite(string name, string descryption)
        {
            Name = name;
            Description = descryption;
            UnderSuits = new List<TestSuite>();
            Tcs = new List<TestCase>();
        }
        #endregion

        
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

       

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
