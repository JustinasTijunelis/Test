namespace Pirma_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            // Antra uzduotis

            //Console.WriteLine("Studentu sarasas");
            //List<string> list2 = new List<string> { "Petras", "Antanas", "Jonas" };

            //foreach (string item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Veliau atvyke studentai");
            //List<string> list = new List<string> { "As", "AB", "JD" };
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("visas sarasas");
            //list.AddRange(list2);
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Isrusiuoti");
            //list.Sort();
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Trecia uzduoti
            //List<string> list = new List<string> {"Jon", "Tom", "Ben", "Anhel", "Styv"};

            //Console.WriteLine(" Vislas listas");
            //foreach (string s in list)
            //{
            //    Console.WriteLine(s);
            //}
            //list.Add("Napaleonas");
            //list.Add("Asteriksas");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Naujas listas");
            //foreach (string s in list)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Istrintas trecias vardas -Ben-");
            //list.Remove("Ben");
            //foreach (string s in list)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Vietoi Napaleonas bus Kleopatra");
            //list[4] = "Kleaopatra";
            //foreach (string s in list)
            //{
            //    Console.WriteLine(s);
            //}


            //Ketvirta uzduoti 


            //Console.WriteLine("Pazymiu sarasa");
            //List<int> PList = new List<int> { 1, 2, 10, 4, 7, 8, 10, 4, 6, 2};

            //do
            //{


            //    foreach (int i in PList)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine($"Pasirinkite is meniu \n" +
            //        $"0 - papildyti\n" +
            //        $"1 - istrinti \n" +
            //        $"2 - iterpti \n" +
            //        $"3 - parodyti pazymiu vidurki \n" +
            //        $"4 - iseiti is programos");
            //    Console.WriteLine("-----------------------");

            //    int input = Int32.Parse(Console.ReadLine());


            //    switch (input)
            //    {

            //        case 0:

            //            Console.WriteLine("Irasykite norima prideti skaiciu");
            //            var NewAddNum = Int32.Parse(Console.ReadLine());
            //            PList.Add(NewAddNum);

            //            break;

            //        case 1:
            //            Console.WriteLine($"Pasirinkite kuri rezultata norite istrinti");
            //            var pasirinkimas = Int32.Parse(Console.ReadLine());
            //            if (pasirinkimas > 0 && pasirinkimas <= 10)
            //            {
            //                PList.Remove(pasirinkimas);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tokio pazymio nera");
            //            }
            //            break;

            //        case 2:
            //            Console.WriteLine($"Pasirinkite i kuria eilute norite iterpti skaiciu");
            //            var insertRange = Int32.Parse(Console.ReadLine());
            //            Console.WriteLine("Irasykite skaiciu kuri norite iterpti");
            //            var insertNum = Int32.Parse(Console.ReadLine());    
            //            PList.Insert(insertRange, insertNum);
            //            break;

            //        case 3:
            //            Console.WriteLine($"Jusu pazymiu vidurkis");

            //            Console.WriteLine(PList.Average());
            //            break;

            //        case 4:
            //            Console.WriteLine("Geros dienos");
            //            break;

            //    }
            //}
            //while (false);
            //Console.WriteLine("----------------------------");
            //foreach (int i in PList)
            //{
            //    Console.WriteLine(i);
            //}

            // Penkta uzduoti

            //Random random = new Random(10);
            //List<int> rnd1 = new List<int>();

            Random random = new Random(10);
            //{
            //int num = random.Next(100);
            random.Next(100);
            for (int i = 0; i < 10; i++)
                //    List<int> Newlist = new List<int>(random.Next(100));


                //   foreach (int i in Newlist) 
                //{
                //    Console.WriteLine(i);
                Console.WriteLine();
        
        








            

            //Console.WriteLine(num);
            //Console.ReadKey();
            //Console.WriteLine("parodyk lista");
            //foreach (int skaiciai in rnd1)
            //{
            //    Console.WriteLine(skaiciai);
            //}
            //random.Next (10);
            //List<int> rnd1 = new List<int>(random,10);
            //foreach (int skaisiai in rnd1)
            //{
            //    Console.WriteLine(rnd1);
            //}
        }

    }
}