using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
namespace Klases
{
    public class ExcelGenerator
    {
        public void GenerateExelFile(List<ReportItem> aircraftEU, List<ReportItem> aircraftNotEU)
        {
            var report = new XLWorkbook();
            report.AddWorksheet("Raport");
            var exelSheet = report.Worksheet("Raport");

            exelSheet.Cell("D" + "1").Value = "Aircrafts which belongs to Europe";
            exelSheet.Cell("A" + "2").Value = "AIRCRAFT TAIL NUMBER";
            exelSheet.Cell("B" + "2").Value = "MODEL NUMBER";
            exelSheet.Cell("C" + "2").Value = "MODEL DESCRIPTION,";
            exelSheet.Cell("D" + "2").Value = "OWNER COMPANY NAME";
            exelSheet.Cell("E" + "2").Value = "COMPANY COUNTRY CODE";
            exelSheet.Cell("F" + "2").Value = "COMPANY COUNTRY NAME";
            int row = 3;

            for (int i = 0; i < aircraftEU.Count; i++)
            {
                exelSheet.Cell("A" + row.ToString()).Value = aircraftEU[i].AircraftTailNumber;
                exelSheet.Cell("B" + row.ToString()).Value = aircraftEU[i].ModelNumber;
                exelSheet.Cell("C" + row.ToString()).Value = aircraftEU[i].ModelDescription;
                exelSheet.Cell("D" + row.ToString()).Value = aircraftEU[i].OwnerCompanyName;
                exelSheet.Cell("E" + row.ToString()).Value = aircraftEU[i].CompanyCountryCode;
                exelSheet.Cell("F" + row.ToString()).Value = aircraftEU[i].CompanyCountryName;

                row++;
            }
            row++;
            exelSheet.Cell("D" + row.ToString()).Value = "Aircrafts which don't belongs to Europe";
            row++;

            for (int i = 0; i < aircraftNotEU.Count; i++)
            {
                exelSheet.Cell("A" + row.ToString()).Value = aircraftNotEU[i].AircraftTailNumber;
                exelSheet.Cell("B" + row.ToString()).Value = aircraftNotEU[i].ModelNumber;
                exelSheet.Cell("C" + row.ToString()).Value = aircraftNotEU[i].ModelDescription;
                exelSheet.Cell("D" + row.ToString()).Value = aircraftNotEU[i].OwnerCompanyName;
                exelSheet.Cell("E" + row.ToString()).Value = aircraftNotEU[i].CompanyCountryCode;
                exelSheet.Cell("F" + row.ToString()).Value = aircraftNotEU[i].CompanyCountryName;
                row++;
            }
            report.SaveAs(@"C:\Users\User\Desktop\TestasEksport\Aircraft.xlsx");

        }
    }
}
