using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            workSheets.Add(workBook.Worksheets.Add("Certified Users"));
            initialSetUp(workBook, workSheets);
            inventorySetUp(workBook, workSheets);
            suspensionsSetUp(workBook, workSheets);
            userInformationSetUp(workBook, workSheets);
            certifiedUserSetUp(workBook, workSheets);
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

            workSheets[1].Cell("A1").Value = "First Name";
            workSheets[1].Cell("A1").Style.Font.Bold = true;
            workSheets[1].Cell("B1").Value = "Last Name";
            workSheets[1].Cell("B1").Style.Font.Bold = true;
            workSheets[1].Cell("C1").Value = "Student ID";
            workSheets[1].Cell("C1").Style.Font.Bold = true;
            workSheets[1].Cell("D1").Value = "Gender";
            workSheets[1].Cell("D1").Style.Font.Bold = true;
            workSheets[1].Cell("E1").Value = "Date Of Birth";
            workSheets[1].Cell("E1").Style.Font.Bold = true;
            workSheets[1].Cell("F1").Value = "Suspension Start Date";
            workSheets[1].Cell("F1").Style.Font.Bold = true;
            workSheets[1].Cell("G1").Value = "Suspension End Date";
            workSheets[1].Cell("G1").Style.Font.Bold = true;
            workSheets[1].Columns().AdjustToContents();
            workSheets[1].Rows().AdjustToContents();

            workSheets[2].Cell("A1").Value = "Item Name";
            workSheets[2].Cell("A1").Style.Font.Bold = true;
            workSheets[2].Cell("B1").Value = "Item ID";
            workSheets[2].Cell("B1").Style.Font.Bold = true;
            workSheets[2].Cell("C1").Value = "Item Purchase Date";
            workSheets[2].Cell("C1").Style.Font.Bold = true;
            workSheets[2].Cell("D1").Value = "Item Replacement Date";
            workSheets[2].Cell("D1").Style.Font.Bold = true;
            workSheets[2].Columns().AdjustToContents();

            workSheets[3].Cell("A1").Value = "First Name";
            workSheets[3].Cell("A1").Style.Font.Bold = true;
            workSheets[3].Cell("B1").Value = "Last Name";
            workSheets[3].Cell("B1").Style.Font.Bold = true;
            workSheets[3].Cell("C1").Value = "Student ID";
            workSheets[3].Cell("C1").Style.Font.Bold = true;
            workSheets[3].Cell("D1").Value = "Date Of Birth";
            workSheets[3].Cell("D1").Style.Font.Bold = true;
            workSheets[3].Cell("E1").Value = "Gender";
            workSheets[3].Cell("E1").Style.Font.Bold = true;
            workSheets[3].Cell("F1").Value = "Belay Certified";
            workSheets[3].Cell("F1").Style.Font.Bold = true;
            workSheets[3].Cell("G1").Value = "Lead Certified";
            workSheets[3].Cell("G1").Style.Font.Bold = true;
            workSheets[3].Columns().AdjustToContents();
        }
        private void inventorySetUp(XLWorkbook workbook, List<IXLWorksheet> workSheets)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select * from Inventory", db.con);
            DataSet inventory = db.sendSelectCommand(command);
            StringBuilder cell = new StringBuilder("A2");
            for(int i = 0; i < inventory.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < inventory.Tables[0].Columns.Count; j++)
                {
                    try
                    {
                        workSheets[2].Cell(cell.ToString()).Value = inventory.Tables[0].Rows[i][j];
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                    catch (NullReferenceException ex)
                    {
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
        }
        private void suspensionsSetUp(XLWorkbook workbook, List<IXLWorksheet> workSheets)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select firstName,lastName,studentID,dateOfBirth,gender,dateSuspended,dateUnsuspended from Patrons where isSuspended=1", db.con);
            DataSet suspensions = db.sendSelectCommand(command);
            StringBuilder cell = new StringBuilder("A2");
            for (int i = 0; i < suspensions.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < suspensions.Tables[0].Columns.Count; j++)
                {
                    workSheets[1].Cell(cell.ToString()).Value = suspensions.Tables[0].Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
        }
        private void userInformationSetUp(XLWorkbook workbook, List<IXLWorksheet> workSheets)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1", db.con);
            DataSet users = db.sendSelectCommand(command);
            StringBuilder cell = new StringBuilder("A2");
            for (int i = 0; i < users.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < users.Tables[0].Columns.Count; j++)
                {
                    try
                    {
                        workSheets[0].Cell(cell.ToString()).Value = users.Tables[0].Rows[i][j];
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                    catch(NullReferenceException ex)
                    {
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
        }
        private void certifiedUserSetUp(XLWorkbook workbook, List<IXLWorksheet> workSheets)
        {
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select firstName,lastName,studentID,dateOfBirth,gender,isBlayCertified,isLeadCertified from Patrons where isWaiverSigned=1 And (isBlayCertified = 1 Or isLeadCertified = 1)", db.con);
            DataSet suspensions = db.sendSelectCommand(command);
            StringBuilder cell = new StringBuilder("A2");
            for (int i = 0; i < suspensions.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < suspensions.Tables[0].Columns.Count; j++)
                {
                    workSheets[3].Cell(cell.ToString()).Value = suspensions.Tables[0].Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
        }
        public void generateInventoryReport()
        {
            var workBook = new XLWorkbook();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("Inventory"));
            workSheets[0].Cell("A1").Value = "Item Name";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Item ID";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Item Purchase Date";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Item Replacement Date";
            workSheets[0].Cell("D1").Style.Font.Bold = true;
            workSheets[0].Columns().AdjustToContents();
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select * from Inventory", db.con);
            DataSet inventory = db.sendSelectCommand(command);
            StringBuilder cell = new StringBuilder("A2");
            for (int i = 0; i < inventory.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < inventory.Tables[0].Columns.Count; j++)
                {
                    workSheets[0].Cell(cell.ToString()).Value = inventory.Tables[0].Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
            String fileName = String.Format("Inventory Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));
        }
        public void generateSuspensionList()
        {
            var workBook = new XLWorkbook();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("Current Suspensions"));
            workSheets.Add(workBook.Worksheets.Add("Unhandled Suspensions"));
            #region Sheet Headings
            workSheets[0].Cell("A1").Value = "First Name";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Last Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Student ID";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Gender";
            workSheets[0].Cell("D1").Style.Font.Bold = true;
            workSheets[0].Cell("E1").Value = "Date Of Birth";
            workSheets[0].Cell("E1").Style.Font.Bold = true;
            workSheets[0].Cell("F1").Value = "Suspension Start Date";
            workSheets[0].Cell("F1").Style.Font.Bold = true;
            workSheets[0].Cell("G1").Value = "Suspension End Date";
            workSheets[0].Cell("G1").Style.Font.Bold = true;
            workSheets[0].Columns().AdjustToContents();
            workSheets[0].Rows().AdjustToContents();

            workSheets[1].Cell("A1").Value = "First Name";
            workSheets[1].Cell("A1").Style.Font.Bold = true;
            workSheets[1].Cell("B1").Value = "Last Name";
            workSheets[1].Cell("B1").Style.Font.Bold = true;
            workSheets[1].Cell("C1").Value = "Student ID";
            workSheets[1].Cell("C1").Style.Font.Bold = true;
            workSheets[1].Cell("D1").Value = "Gender";
            workSheets[1].Cell("D1").Style.Font.Bold = true;
            workSheets[1].Cell("E1").Value = "Date Of Birth";
            workSheets[1].Cell("E1").Style.Font.Bold = true;
            workSheets[1].Cell("F1").Value = "Suspension Start Date";
            workSheets[1].Cell("F1").Style.Font.Bold = true;
            workSheets[1].Cell("G1").Value = "Suspension End Date";
            workSheets[1].Cell("G1").Style.Font.Bold = true;
            workSheets[1].Columns().AdjustToContents();
            workSheets[1].Rows().AdjustToContents();
            #endregion
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select firstName,lastName,studentID,dateOfBirth,gender,dateSuspended,dateUnsuspended from Patrons where isSuspended=1", db.con);
            DataSet suspensions = db.sendSelectCommand(command);
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender from Patrons where isWaiverSigned=1 And isSuspended=0 And suspensionReason Is Not NULL";
            DataSet unhandledSuspensions = db.sendSelectCommand(command);
            StringBuilder cell = new StringBuilder("A2");
            for (int i = 0; i < suspensions.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < suspensions.Tables[0].Columns.Count; j++)
                {
                    try
                    {
                        workSheets[0].Cell(cell.ToString()).Value = suspensions.Tables[0].Rows[i][j];
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                    catch(NullReferenceException ex)
                    {
                        
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
            cell = new StringBuilder("A2");
            for (int i = 0; i < unhandledSuspensions.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < unhandledSuspensions.Tables[0].Columns.Count; j++)
                {
                    try
                    {
                        workSheets[1].Cell(cell.ToString()).Value = unhandledSuspensions.Tables[0].Rows[i][j];
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                    catch (NullReferenceException)
                    {
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
            String fileName = String.Format("Suspensions Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));
        }
        public void generateCertifiedUsersReport()
        {
            var workBook = new XLWorkbook();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("Certified Users"));
            workSheets.Add(workBook.Worksheets.Add("Blay Users"));
            workSheets.Add(workBook.Worksheets.Add("Lead Users"));
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select firstName,lastName,studentID,dateOfBirth,gender,isBlayCertified,isLeadCertified From [dbo].[Patrons] Where isWaiverSigned=1 And isBlayCertified = 1 Or isLeadCertified = 1",db.con);
            #region Sheat Headings
            workSheets[0].Cell("A1").Value = "First Name";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Last Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Student ID";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Date Of Birth";
            workSheets[0].Cell("D1").Style.Font.Bold = true;
            workSheets[0].Cell("E1").Value = "Gender";
            workSheets[0].Cell("E1").Style.Font.Bold = true;
            workSheets[0].Cell("F1").Value = "Belay Certified";
            workSheets[0].Cell("F1").Style.Font.Bold = true;
            workSheets[0].Cell("G1").Value = "Lead Certified";
            workSheets[0].Cell("G1").Style.Font.Bold = true;
            workSheets[0].Columns().AdjustToContents();

            workSheets[1].Cell("A1").Value = "First Name";
            workSheets[1].Cell("A1").Style.Font.Bold = true;
            workSheets[1].Cell("B1").Value = "Last Name";
            workSheets[1].Cell("B1").Style.Font.Bold = true;
            workSheets[1].Cell("C1").Value = "Student ID";
            workSheets[1].Cell("C1").Style.Font.Bold = true;
            workSheets[1].Cell("D1").Value = "Date Of Birth";
            workSheets[1].Cell("D1").Style.Font.Bold = true;
            workSheets[1].Cell("E1").Value = "Gender";
            workSheets[1].Cell("E1").Style.Font.Bold = true;
            workSheets[1].Cell("F1").Value = "Belay Certified";
            workSheets[1].Cell("F1").Style.Font.Bold = true;
            workSheets[1].Cell("G1").Value = "Lead Certified";
            workSheets[1].Cell("G1").Style.Font.Bold = true;
            workSheets[1].Columns().AdjustToContents();

            workSheets[2].Cell("A1").Value = "First Name";
            workSheets[2].Cell("A1").Style.Font.Bold = true;
            workSheets[2].Cell("B1").Value = "Last Name";
            workSheets[2].Cell("B1").Style.Font.Bold = true;
            workSheets[2].Cell("C1").Value = "Student ID";
            workSheets[2].Cell("C1").Style.Font.Bold = true;
            workSheets[2].Cell("D1").Value = "Date Of Birth";
            workSheets[2].Cell("D1").Style.Font.Bold = true;
            workSheets[2].Cell("E1").Value = "Gender";
            workSheets[2].Cell("E1").Style.Font.Bold = true;
            workSheets[2].Cell("F1").Value = "Belay Certified";
            workSheets[2].Cell("F1").Style.Font.Bold = true;
            workSheets[2].Cell("G1").Value = "Lead Certified";
            workSheets[2].Cell("G1").Style.Font.Bold = true;
            workSheets[2].Columns().AdjustToContents();
            #endregion
            DataSet allUsers = db.sendSelectCommand(command);
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isBlayCertified,isLeadCertified from Patrons where isWaiverSigned=1 And (isBlayCertified = 1)";
            DataSet blayUsers = db.sendSelectCommand(command);
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isBlayCertified,isLeadCertified from Patrons where isWaiverSigned=1 And (isLeadCertified = 1)";
            DataSet leadUsers = db.sendSelectCommand(command);
            StringBuilder cell = new StringBuilder("A2");
            for (int i = 0; i < allUsers.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < allUsers.Tables[0].Columns.Count; j++)
                {
                    workSheets[0].Cell(cell.ToString()).Value = allUsers.Tables[0].Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
            cell = new StringBuilder("A2");
            for (int i = 0; i < blayUsers.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < blayUsers.Tables[0].Columns.Count; j++)
                {
                    workSheets[1].Cell(cell.ToString()).Value = blayUsers.Tables[0].Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
            cell = new StringBuilder("A2");
            for (int i = 0; i < leadUsers.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < leadUsers.Tables[0].Columns.Count; j++)
                {
                    workSheets[2].Cell(cell.ToString()).Value = leadUsers.Tables[0].Rows[i][j];
                    cell[0] = (char)((int)(cell[0]) + 1);
                }
                if (i > 0)
                {
                    cell = new StringBuilder('A' + (i + 3).ToString());
                }
                else
                {
                    cell = new StringBuilder("A3");
                }
            }
            String fileName = String.Format("Certified Users Report {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));
        }
        public void generateUserReportWeeky()
        {
            var workBook = new XLWorkbook();
            var todaysDate = DateTime.Now.ToShortDateString();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("All Users Checked In"));
            workSheets.Add(workBook.Worksheets.Add("All Existing Users Checked In"));
            workSheets.Add(workBook.Worksheets.Add("All New Patrons"));
            workSheets.Add(workBook.Worksheets.Add("All Certifications"));
            workSheets.Add(workBook.Worksheets.Add("All Blay Certifications"));
            workSheets.Add(workBook.Worksheets.Add("All Lead Certifications"));
            workSheets.Add(workBook.Worksheets.Add("All New Suspensions"));
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-7, GETDATE()) AND lastCheckIn<=GETDATE()", db.con);
            #region Book Headings
            workSheets[0].Cell("A1").Value = "First Name";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Last Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Student ID";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Date Of Birth";
            workSheets[0].Cell("D1").Style.Font.Bold = true;
            workSheets[0].Cell("E1").Value = "Gender";
            workSheets[0].Cell("E1").Style.Font.Bold = true;
            workSheets[0].Cell("F1").Value = "Is Suspended";
            workSheets[0].Cell("F1").Style.Font.Bold = true;
            workSheets[0].Cell("G1").Value = "Belay Certified";
            workSheets[0].Cell("G1").Style.Font.Bold = true;
            workSheets[0].Cell("H1").Value = "Lead Certified";
            workSheets[0].Cell("H1").Style.Font.Bold = true;
            workSheets[0].Cell("I1").Value = "Date Of Last Check In";
            workSheets[0].Cell("I1").Style.Font.Bold = true;
            workSheets[0].Columns().AdjustToContents();

            workSheets[1].Cell("A1").Value = "First Name";
            workSheets[1].Cell("A1").Style.Font.Bold = true;
            workSheets[1].Cell("B1").Value = "Last Name";
            workSheets[1].Cell("B1").Style.Font.Bold = true;
            workSheets[1].Cell("C1").Value = "Student ID";
            workSheets[1].Cell("C1").Style.Font.Bold = true;
            workSheets[1].Cell("D1").Value = "Date Of Birth";
            workSheets[1].Cell("D1").Style.Font.Bold = true;
            workSheets[1].Cell("E1").Value = "Gender";
            workSheets[1].Cell("E1").Style.Font.Bold = true;
            workSheets[1].Cell("F1").Value = "Is Suspended";
            workSheets[1].Cell("F1").Style.Font.Bold = true;
            workSheets[1].Cell("G1").Value = "Belay Certified";
            workSheets[1].Cell("G1").Style.Font.Bold = true;
            workSheets[1].Cell("H1").Value = "Lead Certified";
            workSheets[1].Cell("H1").Style.Font.Bold = true;
            workSheets[1].Cell("I1").Value = "Date Of Last Check In";
            workSheets[1].Cell("I1").Style.Font.Bold = true;
            workSheets[1].Columns().AdjustToContents();

            workSheets[2].Cell("A1").Value = "First Name";
            workSheets[2].Cell("A1").Style.Font.Bold = true;
            workSheets[2].Cell("B1").Value = "Last Name";
            workSheets[2].Cell("B1").Style.Font.Bold = true;
            workSheets[2].Cell("C1").Value = "Student ID";
            workSheets[2].Cell("C1").Style.Font.Bold = true;
            workSheets[2].Cell("D1").Value = "Date Of Birth";
            workSheets[2].Cell("D1").Style.Font.Bold = true;
            workSheets[2].Cell("E1").Value = "Gender";
            workSheets[2].Cell("E1").Style.Font.Bold = true;
            workSheets[2].Cell("F1").Value = "Is Suspended";
            workSheets[2].Cell("F1").Style.Font.Bold = true;
            workSheets[2].Cell("G1").Value = "Belay Certified";
            workSheets[2].Cell("G1").Style.Font.Bold = true;
            workSheets[2].Cell("H1").Value = "Lead Certified";
            workSheets[2].Cell("H1").Style.Font.Bold = true;
            workSheets[2].Cell("I1").Value = "Date Of Last Check In";
            workSheets[2].Cell("I1").Style.Font.Bold = true;
            workSheets[2].Columns().AdjustToContents();

            workSheets[3].Cell("A1").Value = "First Name";
            workSheets[3].Cell("A1").Style.Font.Bold = true;
            workSheets[3].Cell("B1").Value = "Last Name";
            workSheets[3].Cell("B1").Style.Font.Bold = true;
            workSheets[3].Cell("C1").Value = "Student ID";
            workSheets[3].Cell("C1").Style.Font.Bold = true;
            workSheets[3].Cell("D1").Value = "Date Of Birth";
            workSheets[3].Cell("D1").Style.Font.Bold = true;
            workSheets[3].Cell("E1").Value = "Gender";
            workSheets[3].Cell("E1").Style.Font.Bold = true;
            workSheets[3].Cell("F1").Value = "Is Suspended";
            workSheets[3].Cell("F1").Style.Font.Bold = true;
            workSheets[3].Cell("G1").Value = "Belay Certified";
            workSheets[3].Cell("G1").Style.Font.Bold = true;
            workSheets[3].Cell("H1").Value = "Lead Certified";
            workSheets[3].Cell("H1").Style.Font.Bold = true;
            workSheets[3].Cell("I1").Value = "Date Of Last Check In";
            workSheets[3].Cell("I1").Style.Font.Bold = true;
            workSheets[3].Columns().AdjustToContents();

            workSheets[4].Cell("A1").Value = "First Name";
            workSheets[4].Cell("A1").Style.Font.Bold = true;
            workSheets[4].Cell("B1").Value = "Last Name";
            workSheets[4].Cell("B1").Style.Font.Bold = true;
            workSheets[4].Cell("C1").Value = "Student ID";
            workSheets[4].Cell("C1").Style.Font.Bold = true;
            workSheets[4].Cell("D1").Value = "Date Of Birth";
            workSheets[4].Cell("D1").Style.Font.Bold = true;
            workSheets[4].Cell("E1").Value = "Gender";
            workSheets[4].Cell("E1").Style.Font.Bold = true;
            workSheets[4].Cell("F1").Value = "Is Suspended";
            workSheets[4].Cell("F1").Style.Font.Bold = true;
            workSheets[4].Cell("G1").Value = "Belay Certified";
            workSheets[4].Cell("G1").Style.Font.Bold = true;
            workSheets[4].Cell("H1").Value = "Lead Certified";
            workSheets[4].Cell("H1").Style.Font.Bold = true;
            workSheets[4].Cell("I1").Value = "Date Of Last Check In";
            workSheets[4].Cell("I1").Style.Font.Bold = true;
            workSheets[4].Columns().AdjustToContents();

            workSheets[5].Cell("A1").Value = "First Name";
            workSheets[5].Cell("A1").Style.Font.Bold = true;
            workSheets[5].Cell("B1").Value = "Last Name";
            workSheets[5].Cell("B1").Style.Font.Bold = true;
            workSheets[5].Cell("C1").Value = "Student ID";
            workSheets[5].Cell("C1").Style.Font.Bold = true;
            workSheets[5].Cell("D1").Value = "Date Of Birth";
            workSheets[5].Cell("D1").Style.Font.Bold = true;
            workSheets[5].Cell("E1").Value = "Gender";
            workSheets[5].Cell("E1").Style.Font.Bold = true;
            workSheets[5].Cell("F1").Value = "Is Suspended";
            workSheets[5].Cell("F1").Style.Font.Bold = true;
            workSheets[5].Cell("G1").Value = "Belay Certified";
            workSheets[5].Cell("G1").Style.Font.Bold = true;
            workSheets[5].Cell("H1").Value = "Lead Certified";
            workSheets[5].Cell("H1").Style.Font.Bold = true;
            workSheets[5].Cell("I1").Value = "Date Of Last Check In";
            workSheets[5].Cell("I1").Style.Font.Bold = true;
            workSheets[5].Columns().AdjustToContents();

            workSheets[6].Cell("A1").Value = "First Name";
            workSheets[6].Cell("A1").Style.Font.Bold = true;
            workSheets[6].Cell("B1").Value = "Last Name";
            workSheets[6].Cell("B1").Style.Font.Bold = true;
            workSheets[6].Cell("C1").Value = "Student ID";
            workSheets[6].Cell("C1").Style.Font.Bold = true;
            workSheets[6].Cell("D1").Value = "Date Of Birth";
            workSheets[6].Cell("D1").Style.Font.Bold = true;
            workSheets[6].Cell("E1").Value = "Gender";
            workSheets[6].Cell("E1").Style.Font.Bold = true;
            workSheets[6].Cell("F1").Value = "Is Suspended";
            workSheets[6].Cell("F1").Style.Font.Bold = true;
            workSheets[6].Cell("G1").Value = "Suspension Reason";
            workSheets[6].Cell("G1").Style.Font.Bold = true;
            workSheets[6].Cell("H1").Value = "Date Suspended";
            workSheets[6].Cell("H1").Style.Font.Bold = true;
            workSheets[6].Cell("I1").Value = "Date Unsuspended";
            workSheets[6].Cell("I1").Style.Font.Bold = true;
            workSheets[6].Columns().AdjustToContents();
            #endregion
            DataTable allCheckedIn = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-7, GETDATE()) AND lastCheckIn<=GETDATE() AND dateOfCreation != GetDATE()";
            DataTable allExistingCheckedIn = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned = 1 AND lastCheckIn>= DATEADD(day, -7, GETDATE()) AND lastCheckIn<= GETDATE() AND dateOfCreation = GetDATE()";
            DataTable allNewPatrons = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-7, GETDATE()) AND lastCheckIn<=GETDATE() AND isBlayCertified=1 AND isLeadCertified=1";
            DataTable allCertifications = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-7, GETDATE()) AND lastCheckIn<=GETDATE() AND isBlayCertified=1";
            DataTable allBlay = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-7, GETDATE()) AND lastCheckIn<=GETDATE() AND isLeadCertified=1";
            DataTable allLeadCertifications = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName, lastName, studentID, dateOfBirth, gender, isSuspended, suspensionReason, dateSuspended, dateUnsuspended from Patrons where isWaiverSigned = 1 AND isSuspended=1 AND dateSuspended>= DATEADD(day, -7, GETDATE()) AND dateSuspended<=GETDATE()";
            DataTable allNewSuspension = db.sendSelectCommand(command).Tables[0];
            List<DataTable> results = new List<DataTable>();
            results.Add(allCheckedIn);
            results.Add(allExistingCheckedIn);
            results.Add(allNewPatrons);
            results.Add(allCertifications);
            results.Add(allBlay);
            results.Add(allLeadCertifications);
            results.Add(allNewSuspension);
            StringBuilder cell = new StringBuilder("A2");
            for (int l = 0; l < results.Count; l++)
            {
                for (int i = 0; i < results[l].Rows.Count; i++)
                {
                    for (int j = 0; j < results[l].Columns.Count; j++)
                    {
                        workSheets[l].Cell(cell.ToString()).Value = results[l].Rows[i][j];
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                    if (i > 0)
                    {
                        cell = new StringBuilder('A' + (i + 3).ToString());
                    }
                    else
                    {
                        cell = new StringBuilder("A3");
                    }
                }
                cell = new StringBuilder("A2");
            }
            String fileName = String.Format("Weekly Report {0} to {1} as of {2}", DateTime.Now.AddDays(-7).ToShortDateString(), DateTime.Now.ToShortDateString(),DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));
        }
        public void generateUserReportMonthly()
        {
            var workBook = new XLWorkbook();
            var todaysDate = DateTime.Now.ToShortDateString();
            List<IXLWorksheet> workSheets = new List<IXLWorksheet>();
            workSheets.Add(workBook.Worksheets.Add("All Users Checked In"));
            workSheets.Add(workBook.Worksheets.Add("All Existing Users Checked In"));
            workSheets.Add(workBook.Worksheets.Add("All New Patrons"));
            workSheets.Add(workBook.Worksheets.Add("All Certifications"));
            workSheets.Add(workBook.Worksheets.Add("All Blay Certifications"));
            workSheets.Add(workBook.Worksheets.Add("All Lead Certifications"));
            workSheets.Add(workBook.Worksheets.Add("All New Suspensions"));
            Database db = new Database();
            SqlCommand command = new SqlCommand("Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-30, GETDATE()) AND lastCheckIn<=GETDATE()", db.con);
            #region Book Headings
            workSheets[0].Cell("A1").Value = "First Name";
            workSheets[0].Cell("A1").Style.Font.Bold = true;
            workSheets[0].Cell("B1").Value = "Last Name";
            workSheets[0].Cell("B1").Style.Font.Bold = true;
            workSheets[0].Cell("C1").Value = "Student ID";
            workSheets[0].Cell("C1").Style.Font.Bold = true;
            workSheets[0].Cell("D1").Value = "Date Of Birth";
            workSheets[0].Cell("D1").Style.Font.Bold = true;
            workSheets[0].Cell("E1").Value = "Gender";
            workSheets[0].Cell("E1").Style.Font.Bold = true;
            workSheets[0].Cell("F1").Value = "Is Suspended";
            workSheets[0].Cell("F1").Style.Font.Bold = true;
            workSheets[0].Cell("G1").Value = "Belay Certified";
            workSheets[0].Cell("G1").Style.Font.Bold = true;
            workSheets[0].Cell("H1").Value = "Lead Certified";
            workSheets[0].Cell("H1").Style.Font.Bold = true;
            workSheets[0].Cell("I1").Value = "Date Of Last Check In";
            workSheets[0].Cell("I1").Style.Font.Bold = true;
            workSheets[0].Columns().AdjustToContents();

            workSheets[1].Cell("A1").Value = "First Name";
            workSheets[1].Cell("A1").Style.Font.Bold = true;
            workSheets[1].Cell("B1").Value = "Last Name";
            workSheets[1].Cell("B1").Style.Font.Bold = true;
            workSheets[1].Cell("C1").Value = "Student ID";
            workSheets[1].Cell("C1").Style.Font.Bold = true;
            workSheets[1].Cell("D1").Value = "Date Of Birth";
            workSheets[1].Cell("D1").Style.Font.Bold = true;
            workSheets[1].Cell("E1").Value = "Gender";
            workSheets[1].Cell("E1").Style.Font.Bold = true;
            workSheets[1].Cell("F1").Value = "Is Suspended";
            workSheets[1].Cell("F1").Style.Font.Bold = true;
            workSheets[1].Cell("G1").Value = "Belay Certified";
            workSheets[1].Cell("G1").Style.Font.Bold = true;
            workSheets[1].Cell("H1").Value = "Lead Certified";
            workSheets[1].Cell("H1").Style.Font.Bold = true;
            workSheets[1].Cell("I1").Value = "Date Of Last Check In";
            workSheets[1].Cell("I1").Style.Font.Bold = true;
            workSheets[1].Columns().AdjustToContents();

            workSheets[2].Cell("A1").Value = "First Name";
            workSheets[2].Cell("A1").Style.Font.Bold = true;
            workSheets[2].Cell("B1").Value = "Last Name";
            workSheets[2].Cell("B1").Style.Font.Bold = true;
            workSheets[2].Cell("C1").Value = "Student ID";
            workSheets[2].Cell("C1").Style.Font.Bold = true;
            workSheets[2].Cell("D1").Value = "Date Of Birth";
            workSheets[2].Cell("D1").Style.Font.Bold = true;
            workSheets[2].Cell("E1").Value = "Gender";
            workSheets[2].Cell("E1").Style.Font.Bold = true;
            workSheets[2].Cell("F1").Value = "Is Suspended";
            workSheets[2].Cell("F1").Style.Font.Bold = true;
            workSheets[2].Cell("G1").Value = "Belay Certified";
            workSheets[2].Cell("G1").Style.Font.Bold = true;
            workSheets[2].Cell("H1").Value = "Lead Certified";
            workSheets[2].Cell("H1").Style.Font.Bold = true;
            workSheets[2].Cell("I1").Value = "Date Of Last Check In";
            workSheets[2].Cell("I1").Style.Font.Bold = true;
            workSheets[2].Columns().AdjustToContents();

            workSheets[3].Cell("A1").Value = "First Name";
            workSheets[3].Cell("A1").Style.Font.Bold = true;
            workSheets[3].Cell("B1").Value = "Last Name";
            workSheets[3].Cell("B1").Style.Font.Bold = true;
            workSheets[3].Cell("C1").Value = "Student ID";
            workSheets[3].Cell("C1").Style.Font.Bold = true;
            workSheets[3].Cell("D1").Value = "Date Of Birth";
            workSheets[3].Cell("D1").Style.Font.Bold = true;
            workSheets[3].Cell("E1").Value = "Gender";
            workSheets[3].Cell("E1").Style.Font.Bold = true;
            workSheets[3].Cell("F1").Value = "Is Suspended";
            workSheets[3].Cell("F1").Style.Font.Bold = true;
            workSheets[3].Cell("G1").Value = "Belay Certified";
            workSheets[3].Cell("G1").Style.Font.Bold = true;
            workSheets[3].Cell("H1").Value = "Lead Certified";
            workSheets[3].Cell("H1").Style.Font.Bold = true;
            workSheets[3].Cell("I1").Value = "Date Of Last Check In";
            workSheets[3].Cell("I1").Style.Font.Bold = true;
            workSheets[3].Columns().AdjustToContents();

            workSheets[4].Cell("A1").Value = "First Name";
            workSheets[4].Cell("A1").Style.Font.Bold = true;
            workSheets[4].Cell("B1").Value = "Last Name";
            workSheets[4].Cell("B1").Style.Font.Bold = true;
            workSheets[4].Cell("C1").Value = "Student ID";
            workSheets[4].Cell("C1").Style.Font.Bold = true;
            workSheets[4].Cell("D1").Value = "Date Of Birth";
            workSheets[4].Cell("D1").Style.Font.Bold = true;
            workSheets[4].Cell("E1").Value = "Gender";
            workSheets[4].Cell("E1").Style.Font.Bold = true;
            workSheets[4].Cell("F1").Value = "Is Suspended";
            workSheets[4].Cell("F1").Style.Font.Bold = true;
            workSheets[4].Cell("G1").Value = "Belay Certified";
            workSheets[4].Cell("G1").Style.Font.Bold = true;
            workSheets[4].Cell("H1").Value = "Lead Certified";
            workSheets[4].Cell("H1").Style.Font.Bold = true;
            workSheets[4].Cell("I1").Value = "Date Of Last Check In";
            workSheets[4].Cell("I1").Style.Font.Bold = true;
            workSheets[4].Columns().AdjustToContents();

            workSheets[5].Cell("A1").Value = "First Name";
            workSheets[5].Cell("A1").Style.Font.Bold = true;
            workSheets[5].Cell("B1").Value = "Last Name";
            workSheets[5].Cell("B1").Style.Font.Bold = true;
            workSheets[5].Cell("C1").Value = "Student ID";
            workSheets[5].Cell("C1").Style.Font.Bold = true;
            workSheets[5].Cell("D1").Value = "Date Of Birth";
            workSheets[5].Cell("D1").Style.Font.Bold = true;
            workSheets[5].Cell("E1").Value = "Gender";
            workSheets[5].Cell("E1").Style.Font.Bold = true;
            workSheets[5].Cell("F1").Value = "Is Suspended";
            workSheets[5].Cell("F1").Style.Font.Bold = true;
            workSheets[5].Cell("G1").Value = "Belay Certified";
            workSheets[5].Cell("G1").Style.Font.Bold = true;
            workSheets[5].Cell("H1").Value = "Lead Certified";
            workSheets[5].Cell("H1").Style.Font.Bold = true;
            workSheets[5].Cell("I1").Value = "Date Of Last Check In";
            workSheets[5].Cell("I1").Style.Font.Bold = true;
            workSheets[5].Columns().AdjustToContents();

            workSheets[6].Cell("A1").Value = "First Name";
            workSheets[6].Cell("A1").Style.Font.Bold = true;
            workSheets[6].Cell("B1").Value = "Last Name";
            workSheets[6].Cell("B1").Style.Font.Bold = true;
            workSheets[6].Cell("C1").Value = "Student ID";
            workSheets[6].Cell("C1").Style.Font.Bold = true;
            workSheets[6].Cell("D1").Value = "Date Of Birth";
            workSheets[6].Cell("D1").Style.Font.Bold = true;
            workSheets[6].Cell("E1").Value = "Gender";
            workSheets[6].Cell("E1").Style.Font.Bold = true;
            workSheets[6].Cell("F1").Value = "Is Suspended";
            workSheets[6].Cell("F1").Style.Font.Bold = true;
            workSheets[6].Cell("G1").Value = "Suspension Reason";
            workSheets[6].Cell("G1").Style.Font.Bold = true;
            workSheets[6].Cell("H1").Value = "Date Suspended";
            workSheets[6].Cell("H1").Style.Font.Bold = true;
            workSheets[6].Cell("I1").Value = "Date Unsuspended";
            workSheets[6].Cell("I1").Style.Font.Bold = true;
            workSheets[6].Columns().AdjustToContents();
            #endregion
            DataTable allCheckedIn = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-30, GETDATE()) AND lastCheckIn<=GETDATE() AND dateOfCreation != GetDATE()";
            DataTable allExistingCheckedIn = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned = 1 AND lastCheckIn>= DATEADD(day, -30, GETDATE()) AND lastCheckIn<= GETDATE() AND dateOfCreation = GetDATE()";
            DataTable allNewPatrons = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-30, GETDATE()) AND lastCheckIn<=GETDATE() AND isBlayCertified=1 AND isLeadCertified=1";
            DataTable allCertifications = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-30, GETDATE()) AND lastCheckIn<=GETDATE() AND isBlayCertified=1";
            DataTable allBlay = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName,lastName,studentID,dateOfBirth,gender,isSuspended,isBlayCertified,isLeadCertified,lastCheckIn from Patrons where isWaiverSigned=1 AND lastCheckIn>=DATEADD(day,-30, GETDATE()) AND lastCheckIn<=GETDATE() AND isLeadCertified=1";
            DataTable allLeadCertifications = db.sendSelectCommand(command).Tables[0];
            command.CommandText = "Select firstName, lastName, studentID, dateOfBirth, gender, isSuspended, suspensionReason, dateSuspended, dateUnsuspended from Patrons where isWaiverSigned = 1 AND isSuspended=1 AND dateSuspended>= DATEADD(day, -30, GETDATE()) AND dateSuspended<=GETDATE()";
            DataTable allNewSuspension = db.sendSelectCommand(command).Tables[0];
            List<DataTable> results = new List<DataTable>();
            results.Add(allCheckedIn);
            results.Add(allExistingCheckedIn);
            results.Add(allNewPatrons);
            results.Add(allCertifications);
            results.Add(allBlay);
            results.Add(allLeadCertifications);
            results.Add(allNewSuspension);
            StringBuilder cell = new StringBuilder("A2");
            for (int l = 0; l < results.Count; l++)
            {
                for (int i = 0; i < results[l].Rows.Count; i++)
                {
                    for (int j = 0; j < results[l].Columns.Count; j++)
                    {
                        workSheets[l].Cell(cell.ToString()).Value = results[l].Rows[i][j];
                        cell[0] = (char)((int)(cell[0]) + 1);
                    }
                    if (i > 0)
                    {
                        cell = new StringBuilder('A' + (i + 3).ToString());
                    }
                    else
                    {
                        cell = new StringBuilder("A3");
                    }
                }
                cell = new StringBuilder("A2");
            }
            String fileName = String.Format("Monthly Report {0} to {1} as of {2}", DateTime.Now.AddDays(-7).ToShortDateString(), DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            fileName = rgx.Replace(fileName, "");
            workBook.SaveAs(String.Format("{0}.xlsx", fileName));
        }
    }
}
