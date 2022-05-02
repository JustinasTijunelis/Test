using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace InvoiceGenerator
{
    public class RunInvoiceGenerator
    {
        public void GenerateExel(List<Item> rawData)
        {
            for (int i = 0; i < rawData.Count; i++)
            {

                Random rnd = new Random();
                int num = rnd.Next(1, 99);
                
                using var wbook = new XLWorkbook(@"C:\Users\User\Desktop\VStudio\InvoiceGenerator\InvoiceTheme.xlsx");
                var ws1 = wbook.Worksheet(1);
                ws1.Cell("D11").Value = rawData[i].GuestName;
                ws1.Cell("D12").Value = rawData[i].GueasLastName;
                ws1.Cell("D17").Value = rawData[i].GuestEMail;
                ws1.Cell("D18").Value = rawData[i].GuestPhoneNumber;
                ws1.Cell("B21").Value = rawData[i].Nights;
                ws1.Cell("C21").Value = rawData[i].Property;
                ws1.Cell("D21").Value = rawData[i].CheckInDate;
                ws1.Cell("E21").Value = rawData[i].CheckOutDate; 
                ws1.Cell("E24").Value = rawData[i].RentAmount;
                ws1.Cell("E25").Value = rawData[i].TaxAmount;
                ws1.Cell("E26").Value = rawData[i].RentAmount + rawData[i].TaxAmount;
                ws1.Cell("E27").Value = rawData[i].FeesAmount;
                ws1.Cell("E28").Value = rawData[i].TotalAmount;
                ws1.Cell("E8").Value = rawData[i].IdOrder;
                ws1.Cell("E5").Value = rawData[i].CreatedDate + "_" + num;
                ws1.Cell("E6").Value = rawData[i].CreatedDate;

                wbook.SaveAs($@"C:\Users\User\Desktop\VStudio\InvoiceGenerator\AIR{rawData[i].CreatedDate}_{num}.xlsx");


            }
            

        }
    } 
}
