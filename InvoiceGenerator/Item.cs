using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    public class Item
    {
        public string Property { get; set; }
        public string GuestName { get; set; }  // pataisyti lokacija
        public string GueasLastName { get; set; } //nesuvestas
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string IdOrder { get; set; } //Pataisytas, pataisyti lokacija
        public int Nights { get; set; }
        public decimal RentAmount { get; set; }
        public decimal FeesAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string GuestEMail { get; set; } //nesuvestas
        public string CreatedDate { get; set; } //Nesuvestas
        public string GuestPhoneNumber { get; set; } //nesuvestas

       

        public Item(string[] rawData)
        {
            Property = rawData[0].Trim('"');
            GuestName = rawData[19].Trim('"');
            GueasLastName = rawData[20].Trim('"');
            CheckInDate = rawData[4].Trim('"');
            CheckOutDate = rawData[5].Trim('"');
            IdOrder = rawData[21].Trim('"');
            Nights = Convert.ToInt32(rawData[7]);
            RentAmount = Convert.ToDecimal(rawData[8],new CultureInfo("en-US"));
            FeesAmount = Convert.ToDecimal(rawData[9],new CultureInfo("en-US"));
            FeesAmount = Convert.ToDecimal(rawData[9],new CultureInfo("en-US"));
            TaxAmount = Convert.ToDecimal(rawData[10],new CultureInfo("en-US"));
            TotalAmount = Convert.ToDecimal(rawData[11],new CultureInfo("en-US")); 
            GuestEMail = rawData[16].Trim('"'); 
            CreatedDate = rawData[17].Trim('"');
            GuestPhoneNumber = rawData[18].Trim('"');
            
        }
       public decimal ConvertCulture (string[] rawData )
        {
            // Kaip veikia konverteris Pavyzdys
            var culture = CultureInfo.CreateSpecificCulture("es-ES");
            decimal decimalEsCulture = Convert.ToDecimal(rawData);
          decimalEsCulture.ToString(culture); 

            return decimalEsCulture;
        }
    } 
}
