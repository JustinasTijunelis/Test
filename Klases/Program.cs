using Klases;
using Klases.Repository;
using System.Net;
using System.Net.Mail;

namespace UzduotysConstruct
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reportGenerator = new ReportGenerator( new AircraftModelRepository(), new
            AircraftRepository(),
            new CompanyRepository(),
            new CountryRepository());
            //reportItem.GenerateReportAircraftInEurope();
            //reportItem.GeneratReportAircraftNotEurope();
            //var excel = new ExcelGenerator();
            //var exelFile = excel.GenerateExelFile(reportItem.GenerateReportAircraftInEurope());
            
                    

            var generator = new HTMLGenerator();   //Pasiduodam klase
            var htmlOut = generator.FormatHTML(reportGenerator.GenerateReportAircraftInEurope());
            var htmlOut2 = generator.FormatHTML(reportGenerator.GeneratReportAircraftNotEurope()); // neveikia

            // Pasiduodame klases metoda

            MailAddress to = new MailAddress("justinas.tijunelis@gmail.com");
            MailAddress from = new MailAddress("justinas.tijunelis@gmail.com");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Aircraft statement";
           // message.Attachments.Add(new Attachment(@"C:\Users\User\Desktop\TestasEksport\Aircraft.xlsx"));

            message.Body = $"Laimonai, Please find Aircraft Statement below\n" +
                $"{htmlOut}\n{htmlOut2}";
            SmtpClient client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("c27de64872301f", "45480ab344c8a4"),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
                Console.WriteLine("Message sent");
                Console.ReadLine();
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());

            }



            //GenerateExelFile( ReportItem aircraftEU, ReportItem  aircraftNotEU);

            //var htmlFormatter = new HTMLGenerator();
            //var reportItem = new ReportItem();
            //var reportItem = new List<ReportItem>(reportItem());
            //   {
            //    new ReportItem
            //    {
            //        AircraftTailNumber = "TEST",
            //        ModelNumber = "TEST",
            //        ModelDescription = "TEST",
            //        OwnerCompanyName = "TEST",
            //        CompanyCountryCode = "TEST",
            //        CompanyCountryName = "TEST",
            //        BelongToEU = true
            //    },
            //    new ReportItem
            //    {
            //        AircraftTailNumber = "TEST2",
            //        ModelNumber = "TEST2",
            //        ModelDescription = "TEST2",
            //        OwnerCompanyName = "TEST2",
            //        CompanyCountryCode = "TES2T",
            //        CompanyCountryName = "TEST2",
            //        BelongToEU = false
            //    },
            //    new ReportItem
            //    {
            //        AircraftTailNumber = "TEST3",
            //        ModelNumber = "TEST3",
            //        ModelDescription = "TEST3",
            //        OwnerCompanyName = "TEST3",
            //        CompanyCountryCode = "TEST3",
            //        CompanyCountryName = "TEST3",
            //        BelongToEU = true
            //    }
            //};

            // var C = new HTMLGenerator()
            //var result = ToString(GenerateReportAircraftInEurope.aircraftEU());
            //Console.WriteLine(result);

            // var results = htmlFormatter.FormatHTML();
        }
    }
}