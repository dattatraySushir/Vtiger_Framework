using AventStack.ExtentReports;
using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.GenericUtility;
using Vtiger_Framework.Main_Folder.ObjectRepository.LoginRepo;

namespace Vtiger_Framework.Test_Scripts.Test.LoginTest
{
    [TestClass]
    public class LoginTest : BaseClass
    {
      
        //[TestMethod]
        [Owner("Datta")]
        [DynamicData(nameof(Names), DynamicDataSourceType.Method)]
        public void loginMethod(string username, string password)
        {
            var extentTest= extentReports.CreateTest(test_context.TestName);
            LoginPage login = new LoginPage(driver);
            login.Login(username, password);
        }
        [Owner("Datta")]
        public static IEnumerable<object[]> Names()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(CommonData.excelpath);
            var sheet = spreadsheet.Workbook.Worksheets["Login"];
            var maxrow = sheet.UsedRangeRowMax;
            var maxcol = sheet.UsedRangeColumnMax;

            for (int i = 0; i <= maxrow; i++)
            {
                string username = sheet.Cell(i, 0).ToString();
                string password = sheet.Cell(i, 1).ToString();

                yield return new object[] { username, password };
            }
        }
    }
}
