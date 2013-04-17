using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Xml;
using TestLink2Excel.Model;

namespace TestLink2Excel.Utils
{
    class ExcelWriter
    {
        private string filePath;
        private XLWorkbook workbook;
        private int row = 1;
        private int deep;
        
        
        private const int expectedResultCellDiv = 100;

        public ExcelWriter(string newFilePath)
        {
            if (!string.IsNullOrEmpty(newFilePath)) filePath = newFilePath;
            workbook = new XLWorkbook();
        }


        internal void generateSuiteSheet(TestSuite suite)
        {
            IXLWorksheet sheet = workbook.AddWorksheet(suite.Name);
            sheet.Columns("A:Z").Style.Alignment.WrapText = true;
            sheet.Columns("A:Z").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            sheet.Columns("A:Z").Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
            deep = suite.getSuitsDeep();
            row = 1;
            makeHeaders(sheet, suite);
            writeSuite(sheet,suite,new List<string>());
        }

        private void writeSuite(IXLWorksheet sheet, TestSuite suite, List<string> oldCats)
        {
            List<string> cats = oldCats;
            if (suite.Tcs.Count > 0) writeSuiteTcs(sheet, suite, oldCats);
            if (suite.UnderSuits.Count > 0)
            {
                cats.Add(suite.Name);
                foreach (TestSuite s in suite.UnderSuits)
                {
                    writeSuite(sheet,s,new List<string>(cats));
                }
            }
        }

        private void writeSuiteTcs(IXLWorksheet sheet, TestSuite suite, List<string> cats)
        {
            
            foreach (TestCase testCase in suite.Tcs)
            {
                for (int column = 1; column <= cats.Count; column++)
                {
                    sheet.Cell(row, column).Value = cats[column - 1];
                }
                sheet.Cell(row, cats.Count + 1).Value = suite.Name;
                sheet.Cell(row, deep + 1).Value = testCase.Name;
                sheet.Cell(row, deep + 2).Value = testCase.Id;
                sheet.Cell(row, deep + 3).Value = testCase.Summary;
                sheet.Cell(row, deep + 4).Value = testCase.Preconditions;
                string actions = string.Empty;
                string expected = string.Empty;
                if (testCase.Steps.Count == 1)
                {
                    actions += testCase.Steps[0].Action;
                    expected += testCase.Steps[0].ExpectedResult;
                }
                else
                {
                    foreach (Step step in testCase.Steps)
                    {
                        actions += step.StepNumber.ToString() + ". " + step.Action + "\n";
                        expected += step.StepNumber.ToString() + ". " + step.ExpectedResult + "\n";
                    }
                }
                sheet.Cell(row, deep + 5).Value = actions.Substring(0,actions.Length - 1);
                sheet.Cell(row, deep + 6).Value = expected.Substring(0, expected.Length - 1);
                row++;
            }
        }

        private void makeHeaders(IXLWorksheet sheet, TestSuite suite)
        {
            int column = 1;
            for (; column <= deep; column++)
            {
                string header = string.Empty;
                for (int i = 1; i < column; i++)
                {
                    header += "Sub-";
                }
                sheet.Cell(row, column).Value = header + "Category";
                sheet.Column(column).Width = 20.86;
            }
            sheet.Cell(row, deep + 1).Value = "Name";
            sheet.Column(deep + 1).Width = 30;
            sheet.Cell(row, deep + 2).Value = "Id";
            sheet.Column(deep + 2).Width = 13;
            sheet.Cell(row, deep + 3).Value = "Summary";
            sheet.Column(deep + 3).Width = 42;
            sheet.Cell(row, deep + 4).Value = "Preconditions";
            sheet.Column(deep + 4).Width = 56.43;
            sheet.Cell(row, deep + 5).Value = "Actions";
            sheet.Column(deep + 5).Width = 100;
            sheet.Cell(row, deep + 6).Value = "Expected Results";
            sheet.Column(deep + 6).Width = 100;
            row++;
        }
        

        internal void Save()
        {
            workbook.SaveAs(filePath);
        }

        internal void Close()
        {
            workbook.Dispose();
        }
    }
}
