using ClosedXML.Excel;


namespace ExcelTest
{
    public class Program
    {

        public static void Main(string[] args)
        {

            using var report = new XLWorkbook(@"C:\Users\User\Desktop\TestasEksport\Data.xlsx");
            var ws1 = report.Worksheet(1);
            var data = ws1.Cell("B4").GetValue<string>();
            

            Console.WriteLine(data,data2);
            
            //var report = new XLWorkbook();
            //report.AddWorksheet("Sheet333"); //sheet Pridejimas i Exelio faila
            //var exelSheet = report.Worksheet("Sheet333"); 

            //exelSheet.Cell("A" + "1").Value = "Pavadinimas";
            //exelSheet.Cell("A" + "2").Value = "Numeris ";

            //int row = 3;

           // report.SaveAs(@"C:\Users\User\Desktop\TestasEksport\Raport.xlsx");

            
            //string filePath = "C:\Users\User\Desktop\TestasEksport\testexport.xlsx";
            //Microsoft.Office.Interop.Excel.Application exel = new Microsoft.Office.Interop.Excel.Application();
            //Workbook wb;
            //Worksheet ws;

            //Worksheet newWorksheet;
            //Range cellRage = new Worksheets.Range
            //    //Range cellRange = ws.Range["A1: B1"];
            //string[] thing = new string[] { "Albinas", "Petras" };
            //cellRange.set.Value(XlRangeValueDataType.xlRangeValueDefault, thing);

            //wb.SaveAs("C:\Users\User\Desktop\TestasEksport\testexport.xlsx");
            //wb.Close();

            //Process.Start("C:\Users\User\Desktop\TestasEksport\testexport.xlsx")
        }
    }
    
}