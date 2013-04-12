using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLink2Excel.Model
{
    class TestCase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Preconditions { get; set; }
        public List<Step> Steps { get; set; }

        public TestCase(string name)
        {
            Name = name;
            Steps = new List<Step>();
        }

        public void addStep(Step step)
        {
            Steps.Add(step);
        }
    }
}
