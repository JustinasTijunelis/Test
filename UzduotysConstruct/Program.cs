using Staciakampis;

namespace UzduotysConstruct
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///////////// Uzduoti 1 //////////////////////

            Mokinys mokinys1 = new Mokinys();
            Console.WriteLine("Jusu Vardas");
            mokinys1.Vardas = Console.ReadLine();
            Console.WriteLine("Jusu Pavarde");
            mokinys1.Pavarde = Console.ReadLine();
            Console.WriteLine("Kurso Pradzia yyyy-MM-DD");
            mokinys1.KursoPradzia = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-DD", null);
            Console.WriteLine("Kurso Pabaiga yyyy-MM-DD");
            mokinys1.KursoPabaiga = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-DD", null);

            //////////////// Uzduotis 2 ////////////////

            BibliotekosKnyga knyga = new BibliotekosKnyga();
            knyga.ID = 2382301;
            knyga.SkaitytojoVardas = "Jonas";
            knyga.SkaitytojoPavarde = "Petrauskas";
            knyga.PaemimoData = new DateTime(2022 - 01 - 01);
            knyga.SiosDienosData = DateTime.Now;

           // knyga.LaikasNuoPasiemimo(knyga.ID, knyga.SkaitytojoVardas, knyga.SkaitytojoPavarde, knyga.PaemimoData, knyga.SiosDienosData);


            /////////////////// Uzduotis 3 ////////////////////
            
            Staciakampis1 staciakampis1 = new Staciakampis1();
            staciakampis1.Plotis = 2;
            staciakampis1.Ilgis = 3;
            staciakampis1.Plotas(staciakampis1.Plotis, staciakampis1.Ilgis);


            ///////////////// Uzduotis 1 //////////////////
           


        }

    }
}