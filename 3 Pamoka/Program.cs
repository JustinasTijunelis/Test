namespace Trecia_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte a = 0; //skaicius naudojamas micKontroleriams iki 255 sk

            //sbyte b = 0; // skaicius naudojamas micKontroleriams iki 128 sk

            //1 Uzduotis

            //Console.WriteLine("Iveskite metrus");
            //string input = Console.ReadLine();
            //double m;
            //m = double.Parse(input);
            //Console.WriteLine($"{m}m");

            //Console.WriteLine("Iveskite Laika");
            //string inputSec = Console.ReadLine();
            //double s;
            //s = double.Parse(inputSec);

            //Console.WriteLine($"{s}sec");

            //double mRezult = (m / 1000);
            //double sRezult = (s / 3600);
            //Console.WriteLine($"Jusu rezultatas {mRezult}km per {sRezult}h");

            //2 Uzduotis
            //Console.WriteLine("Iveskite kvadrato krastine");
            //string a = Console.ReadLine();
            //double krastine;
            //krastine = double.Parse(a);

            //double plotas = krastine * krastine;


            //Console.WriteLine($"Jusus kvadrato plotas yra {plotas}");

            //3 Uzduotis

            //Console.WriteLine("Irasykite pirma skaiciu");
            //string input = Console.ReadLine();
            //double  sk1;
            //sk1 = double.Parse(input);

            //Console.WriteLine("Irasykite antra skaiciu");
            //string input2 = Console.ReadLine();
            //double sk2;
            //sk2 = double.Parse(input2);

            //if (sk1 == sk2)
            //    Console.WriteLine("jusu skaiciai lygus");
            //else
            //    Console.WriteLine("skaiciai nelygus");

            //Conditins 
            //Console.WriteLine("Iveskite grupes pavadinima");
            //String GPav = Console.ReadLine();
            //Console.WriteLine("Iveskite nariu skaiciu");
            //int GSK =int.Parse(Console.ReadLine());

            //if (!int.TryParse(GPav, out GSK))
            //{
            //    Console.WriteLine("Ivestas nekorektiskas sk");

            //    Environment.Exit(0);
            //    Console.ReadLine();
            //}
            //string spalva = Console.ReadLine();

            //if (spalva == "geltona")
            //{
            //    Console.WriteLine("Saule");
            //}
            //else if (spalva == "raudona")
            //{
            //    Console.WriteLine("nieko gero");
            //}
            //Console.WriteLine($"Grupes pavadinimas yra {GPav}, {GSK}");
            //Console.ReadLine();
            //// Ifa  gali uzrasyti ir consoleje 
            //Console.WriteLine(spalva == "geltona" ? "grazi spalva":" ne ta spalva");

            //1 uzduoti su swich

            Console.WriteLine("Iveskite grupes nariu skaiciu");
            int sk = int.Parse(Console.ReadLine());

            //if (sk == 1)
            //{
            //    Console.WriteLine("TAI SOLO ATLIKĖJAS");
            //}
            //else if (sk == 2)
            //{
            //    Console.WriteLine("Tai duetas");
            //}
            //else if (sk > 2 && sk <= 10)
            //{
            //    Console.WriteLine("TAI ANSAMBLIS");
            //}
            //else if (sk > 10)
            //{
            //    Console.WriteLine("Tai kamerinis ansamblis");
            //}
            //else
            //    Console.WriteLine("Neegsituoja tokios komandos");

            switch (sk) // su Switchu
            {
                case 1:
                    Console.WriteLine("TAI SOLO ATLIKĖJAS");
                break;
                case 2:
                    Console.WriteLine("Tai duetas");
                     break;
                case 3: case 4: case 5:case 6: case 7: case 8: case 9:
                     Console.WriteLine("TAI ANSAMBLIS");
                      break;
                case > 10:
                    Console.WriteLine("Tai kamerinis ansamblis");
                break;
                    default:
                    break;


                    //2 Uzduotis
                    //Console.WriteLine("Iveskite isdirbtas valandas");
                    //int sk = int.Parse(Console.ReadLine());

                    //if (sk < 160)
                    //{
                    //    int isdibrti = 160 - sk;
                    //    Console.WriteLine($"Jusms reikia isdirbti {isdibrti}");
                    //}
                    //else if (sk == 160)
                    //{
                    //    Console.WriteLine("Isdirbtos visos valando");
                    //}
                    //else if (sk > 160)
                    //{
                    //    int perdirbta = sk - 160;
                    //    Console.WriteLine($"Jusu virsvalandziai {perdirbta}");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Jus padarete klaida");
                    //}
                    //Console.WriteLine("Iveskite savo egzamino rezultata");
                    //int rezultatas = int.Parse(Console.ReadLine()); 

                    //switch (rezultatas)
                    //{
                    //    case 1: case 2: case 3:case 4: case 0:
                    //        Console.WriteLine("NEPATEKINAMAI");
                    //            break;
                    //    case 5:
                    //        Console.WriteLine("SILPNAI");
                    //        break ;
                    //    case 6:
                    //        Console.WriteLine("PATENKINAMAI");
                    //        break;
                    //    case 7:
                    //        Console.WriteLine("VIDUTINIŠKAI");
                    //        break;
                    //    case 8:
                    //        Console.WriteLine("GERAI");
                    //        break;
                    //    case 9:
                    //        Console.WriteLine("LABAI GERAI");
                    //        break;
                    //    case 10:
                    //        Console.WriteLine("PUIKIAI");
                    //        break;
                    //    default:
                    //        break;
            }

        }

    }
}