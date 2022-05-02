using Klases.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    public class ReportGenerator
    {
        private AircraftModelRepository AircraftModelRepository { get; set; }
        private AircraftRepository AircraftRepository { get; set; }
        private CompanyRepository CompanyRepository { get; set; }   
        private CountryRepository CountryRepository { get; set; }

        public ReportGenerator()
        {

        }
        public ReportGenerator(AircraftModelRepository aircraftModelRepository,
            AircraftRepository aircraftRepository,
            CompanyRepository companyRepository,
            CountryRepository countryRepository)
        {
            AircraftModelRepository = aircraftModelRepository;
            AircraftRepository = aircraftRepository;
            CompanyRepository = companyRepository;
            CountryRepository = countryRepository;
        }

        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            var aircraftEU = new List<ReportItem>();
            

            List <Aircraft> aircrafts = AircraftRepository.Retrive();

            foreach(Aircraft aircraft in aircrafts)
            {
                var companyId = aircraft.CompanyId;
                var modelId = aircraft.ModelId;
                var aircraftmodel = AircraftModelRepository.RetriveById(modelId);
                var company = CompanyRepository.RetriveById(companyId);
                var country = CountryRepository.RetriveById(company.CountryId);
                if(country.Continent =="Europe")
                {
                    aircraftEU.Add(new ReportItem { AircraftTailNumber = aircraft.TailNumber, ModelNumber = aircraftmodel.Number, ModelDescription = aircraftmodel.Description, OwnerCompanyName = company.Name, CompanyCountryCode = company.CountryId, CompanyCountryName = country.Name});
                   
                }
                
            }
            return aircraftEU;
            
            
        }
        public List<ReportItem> GeneratReportAircraftNotEurope()
        {
            var aircraftNotEU = new List<ReportItem>();
            List<Aircraft> aircrafts = AircraftRepository.Retrive();

            foreach (Aircraft aircraft in aircrafts)
            {
                var companyId = aircraft.CompanyId;
                var modelId = aircraft.ModelId;
                var aircraftmodel = AircraftModelRepository.RetriveById(modelId);
                var company = CompanyRepository.RetriveById(companyId);
                var country = CountryRepository.RetriveById(company.CountryId);
                if (country.Continent != "Europe")
                {
                    aircraftNotEU.Add(new ReportItem { AircraftTailNumber = aircraft.TailNumber, ModelNumber = aircraftmodel?.Number, ModelDescription = aircraftmodel?.Description, OwnerCompanyName = company.Name, CompanyCountryCode = company.CountryId, CompanyCountryName = country.Name });

                }

            }
            return aircraftNotEU;
        }
    }
}
