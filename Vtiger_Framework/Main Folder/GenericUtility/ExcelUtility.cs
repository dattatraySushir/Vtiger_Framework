using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger_Framework.Main_Folder.GenericUtility
{/// <summary>
/// This class is going to fectch the data from the excel sheet.
/// </summary>
    public class ExcelUtility
    {
        /// <summary>
        /// This method is going to provide the data from the excel sheet by taking the parameters as sheetname , row and cell.
        /// </summary>
        /// <param name="sheetname"></param>
        /// <param name="row"></param>
        /// <param name="cell"></param>
        /// <returns></returns>
        
        [Owner("Datta")]
        public string DataFetch(string sheetname,int row, int cell)
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(CommonData.excelpath);
            var sheet = spreadsheet.Workbook.Worksheets["Login"];
            string data = sheet.Cell(row,cell).ToString();
            return data;
        }
        /// <summary>
        /// This method is going to provide the multiple data at a time with the combination of inputs.
        /// </summary>
        /// <returns></returns>
        [Owner("Datta")]
        [DynamicData(nameof(Names), DynamicDataSourceType.Method)]
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
