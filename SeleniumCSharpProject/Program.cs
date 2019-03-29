using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;

namespace SeleniumCSharpProject

{
    class Program
    {
         public void ReadData()
        {
            Console.WriteLine("Main method");
            excel.Application excelApp = new excel.Application();
            Console.WriteLine("excelApp");
            excel.Workbook workbook = excelApp.Workbooks.Open(@"C:\\Users\\iv_bhagyashri\\Desktop\\demo.xlsx");
            Console.WriteLine("workbook");
            excel._Worksheet worksheet = workbook.Sheets[1];
            Console.WriteLine("worksheet");
            excel.Range x1range = worksheet.UsedRange;
            Console.WriteLine("x1range");
            string strData;
            for (int i = 1; i <= 3; i++)
            {
                strData = x1range.Cells[i][1].value2;
                Console.WriteLine(strData);
            }

        }
        public void writeData()
        {
            excel.Application excelApp = new excel.Application();
            excel.Workbook workbook = excelApp.Workbooks.Open(@"C:\\Users\\iv_bhagyashri\\Desktop\\demo.xlsx");
            excel._Worksheet worksheet = workbook.Sheets[1];
            for (int j = 5; j < 10; j++)
            {
                Console.WriteLine("write Data");
                worksheet.Cells[j][1].value2 = "abc" + j;
            }
            worksheet.SaveAs("C:\\Users\\iv_bhagyashri\\Desktop\\demo4.xlsx");
          

        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.ReadData();
            p.writeData();
           
        }

    }
        
   
}
