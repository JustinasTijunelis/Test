namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal usd = 1.1052m;
            decimal pln = 4.6401m;
            decimal byr = 22288.8906m / 1000;
          
                Meniu(usd, pln, byr);
        }
        private static void Meniu(decimal usd, decimal pln, decimal byr)
        {
         
            Console.WriteLine("Valiutos konvertavimas is EUR i USD, PLN, RYB" +
                "\nPasirinkite i kokia valiuta norite konvertuoti\n");
            Console.WriteLine("[1] - USD\n[2] - PLN\n[3] - BYR\n[5] - Iseiti is programos");

            int pasirinkimoRezultatas;
            int.TryParse(Console.ReadLine(), out pasirinkimoRezultatas);

            if (pasirinkimoRezultatas <= 3 && pasirinkimoRezultatas >= 1 && pasirinkimoRezultatas!=5)
            {
                switch (pasirinkimoRezultatas)
                {
                    case 1:
                        UsdConvertavimas(usd,pln,byr);
                        break;
                    case 2:
                        PlnConvertavimas(usd, pln, byr);
                        break;
                    case 3:
                        ByrConvertavimas(usd, pln, byr);
                        break;
                }
            }
            else if (pasirinkimoRezultatas==5)
            {
                Console.WriteLine("Viso gero");
            }
            else
                Console.WriteLine("Pasirinkote neteisingai, bandykite dar karta" +
                    "\n------------------------------------------");
            Meniu(usd, pln, byr);
        }
        private static void UsdConvertavimas(decimal usd, decimal pln, decimal byr)
        {
            Console.WriteLine("----EUR - USD----\nKiek EUR norite konvertuoti?");

            decimal eurSuma;
            decimal.TryParse(Console.ReadLine(), out eurSuma);
            decimal usdRezultatas = eurSuma * usd;
            Console.WriteLine($"---------------\nJusu rezultatas {usdRezultatas} USD" +
                $"\n------------------------------------------\n");
            Meniu(usd, pln, byr);
        }
        private static void PlnConvertavimas(decimal usd, decimal pln, decimal byr)
        {
            Console.WriteLine("----EUR - PLN----\nKiek EUR norite konvertuoti?");
            decimal eurSuma1;
            decimal.TryParse(Console.ReadLine(), out eurSuma1);
            decimal usdRezultatas1 = eurSuma1 * pln;
            Console.WriteLine($"---------------\nJusu rezultatas {usdRezultatas1} PLN" +
                $"\n------------------------------------------\n");
            Meniu(usd, pln, byr);
        }
        private static void ByrConvertavimas(decimal usd, decimal pln, decimal byr)
        {
            Console.WriteLine("----EUR - BYR----\nKiek EUR norite konvertuoti?");
            decimal eurSuma2;
            decimal.TryParse(Console.ReadLine(), out eurSuma2);
            decimal usdRezultatas2 = eurSuma2 * byr;
            Console.WriteLine($"---------------\nJusu rezultatas {usdRezultatas2} BYR" +
                $"\n------------------------------------------\n");
            Meniu(usd, pln, byr);
        }

    }
}