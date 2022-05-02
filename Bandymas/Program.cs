using ClosedXML.Excel;
using System;
using System.Globalization;

namespace UzduotysConstruct

{
    public class Program
    {
        public static void Main(string[] args)
        {

            double value = 12345.6789;
            //Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
            //Console.WriteLine(value.ToString("C3", CultureInfo.CurrentCulture));
            //Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("EU-EUR")));
            System.Globalization.CultureInfo EnglishCulture = new System.Globalization.CultureInfo("en-EN");
            value.ToString("F2", EnglishCulture);


            // The example displays the following output on a system whose
            // current culture is English (United States(sad)
            //       $12,345.68
            //       $12,345.679
            //       kr 12.345,679
            //string MyString = "-Big*-dks-sdeim;-kasdmi";
            //Console.WriteLine("Hello{0}World!", MyString);
            //string TrimString = MyString.Trim('-');
            //Console.WriteLine("Hello{0}World!", TrimString);


            //  Random rnd = new Random();
            //  DateTime thisDay = DateTime.Today;
            //  string fileDay = thisDay.ToString("yyyy-MM-dd");
            //int num =  rnd.Next(1,10);

            //      Console.WriteLine(fileDay+"_"+num);

            //using var wbook = new XLWorkbook(@"C:\Users\User\Desktop\VStudio\InvoiceGenerator\None.xlsx");
            //var ws1 = wbook.Worksheet(1);
            //var data = ws1.Cell("A1").Value = "Skaiciai ";
            //var data1 = ws1.Cell("A2").Value = "Vardas";
            //var data2 = ws1.Cell("A3").Value = "60,50";

            //wbook.SaveAs($@"C:\Users\User\Desktop\VStudio\InvoiceGenerator\None{fileDay}_{num}.xlsx");

        }
    }
}
