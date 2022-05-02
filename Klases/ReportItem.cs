using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    public class ReportItem
    {
         public string AircraftTailNumber { get; set; }
        public string ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public string OwnerCompanyName { get; set; }
        public int CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }
        public bool BelongToEU { get; set; }

        public ReportItem() { }
        public ReportItem(
            string aircraftTailNumber,
            string modelNumber,
            string modelDescription,
            string ownerCompanyName, 
            int companyCountryCode,
            string companyCountryName, 
            bool belongToEU)
        {
            AircraftTailNumber = aircraftTailNumber;
            ModelNumber = modelNumber;
            ModelDescription = modelDescription;
            OwnerCompanyName = ownerCompanyName;
            CompanyCountryCode = companyCountryCode;
            CompanyCountryName = companyCountryName;
            BelongToEU = belongToEU;

        }

    }
}
