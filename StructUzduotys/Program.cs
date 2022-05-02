using Class1;

namespace StructUzduotys
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //var data2 = new DateTime.

            Mokinys mokinys1 = new Mokinys();
            Console.WriteLine("Jusu Vardas");
            mokinys1.Vardas = Console.ReadLine();
            Console.WriteLine("Jusu Pavarde");
            mokinys1.Pavarde = Console.ReadLine();
            Console.WriteLine("Kurso Pradzia yyyy-MM-DD");
            mokinys1.KursoPradzia = DateTime.ParseExact(Console.ReadLine(),"yyyy-MM-DD",null);
            Console.WriteLine("Kurso Pabaiga yyyy-MM-DD");
            mokinys1.KursoPabaiga = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-DD", null);
            
            Console.WriteLine($"Vardas {mokinys1.Vardas} Pavarde {mokinys1.Pavarde}" +
                $"Kurso Pradzia {mokinys1.KursoPradzia} Kuro Pabaiga {mokinys1.KursoPabaiga}");
           // var data2 = new DateTime(PaemimoData.BibliotekosKnyga, "yyyy-MM-DD", null);
        }

    }
}