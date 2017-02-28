using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SDSU_Rock_Wall_CRM
{
    class Report
    {
        public void generateMasterReport()
        {
            var workBook = new XLWorkbook();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("User Information"));
            workSheets.Add(workBook.Worksheets.Add("Current Suspensions"));
            workSheets.Add(workBook.Worksheets.Add("Inventory"));
            initialSetUp(workBook, workSheets);
            String fileName = String.Format("Master Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx",fileName));
        }
        private void initialSetUp(XLWorkbook workbook, List<IXLWorksheet> workSheets)
        {
            workSheets[0].Cell("A1").Value = "First Name";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Last Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Student ID";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Date of Birth";
            workSheets[0].Cell("D1").Style.Font.Bold = true;
            workSheets[0].Cell("E1").Value = "Gender";
            workSheets[0].Cell("E1").Style.Font.Bold = true;
            workSheets[0].Cell("F1").Value = "Suspended";
            workSheets[0].Cell("F1").Style.Font.Bold = true;
            workSheets[0].Cell("G1").Value = "B-Lay Certified";
            workSheets[0].Cell("G1").Style.Font.Bold = true;
            workSheets[0].Cell("H1").Value = "Lead Certified";
            workSheets[0].Cell("H1").Style.Font.Bold = true;
            workSheets[0].Cell("I1").Value = "Last Check In";
            workSheets[0].Cell("I1").Style.Font.Bold = true;
            workSheets[0].Cell("J1").Value = "Number of Check Ins";
            workSheets[0].Cell("J1").Style.Font.Bold = true;
            workSheets[0].Cell("K1").Value = "Mailing List";
            workSheets[0].Cell("K1").Style.Font.Bold = true;
            workSheets[0].Columns().AdjustToContents();

            workSheets[1].Cell("A1").Value = "First Name";
            workSheets[1].Cell("A1").Style.Font.Bold = true;
            workSheets[1].Cell("B1").Value = "Last Name";
            workSheets[1].Cell("B1").Style.Font.Bold = true;
            workSheets[1].Cell("C1").Value = "Student ID";
            workSheets[1].Cell("C1").Style.Font.Bold = true;
            workSheets[1].Cell("D1").Value = "Gender";
            workSheets[1].Cell("D1").Style.Font.Bold = true;
            workSheets[1].Cell("E1").Value = "Suspension Start Date";
            workSheets[1].Cell("E1").Style.Font.Bold = true;
            workSheets[1].Cell("F1").Value = "Suspension End Date";
            workSheets[1].Cell("F1").Style.Font.Bold = true;
            workSheets[1].Columns().AdjustToContents();

            workSheets[2].Cell("A1").Value = "Item Name";
            workSheets[2].Cell("A1").Style.Font.Bold = true;
            workSheets[2].Cell("B1").Value = "Item ID";
            workSheets[2].Cell("B1").Style.Font.Bold = true;
            workSheets[2].Cell("C1").Value = "Item Purchase Date";
            workSheets[2].Cell("C1").Style.Font.Bold = true;
            workSheets[2].Cell("D1").Value = "Item Replacement Date";
            workSheets[2].Cell("D1").Style.Font.Bold = true;
            workSheets[2].Columns().AdjustToContents();
        }
    }
}
