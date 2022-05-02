namespace Bilietai
    {
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bilietuTipas10 = new List<int>();
            List<int> bilietuTipas20 = new List<int>();
            List<int> bilietuTipas30 = new List<int>();

            List<int> visoSukurta10 = new List<int>();
            List<int> visoSukurta20 = new List<int>();
            List<int> visoSukurta30 = new List<int>();

            List<int> visoParduota10 = new List<int>();
            List<int> visoParduota20 = new List<int>();
            List<int> visoParduota30 = new List<int>();

            MainMeniu(bilietuTipas10,bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
        }
        private static void BilietuKurimas10(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.WriteLine("Keik bilietu norite kurti");
            int kiekis = Int32.Parse(Console.ReadLine());
            
            for (int i = 1; i <= kiekis; i++)
            {
                bilietuTipas10.Add(1);
                visoSukurta10.Add(1);
            }
            MeniuBilietuKurimas(bilietuTipas10,bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20,  visoSukurta30,  visoParduota10,  visoParduota20,visoParduota30);
        }
        private static void BilietuKurimas20(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.WriteLine("Keik bilietu norite kurti");
            int kiekis = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= kiekis; i++)
            {
                bilietuTipas20.Add(1);
                visoSukurta20.Add(1);
            }
            MeniuBilietuKurimas(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
        }
        private static void BilietuKurimas30(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.WriteLine("Keik bilietu norite kurti");
            int kiekis = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= kiekis; i++)
            {
                bilietuTipas30.Add(1);
                visoSukurta30.Add(1);
            }
            MeniuBilietuKurimas(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
        }
        private static void MeniuBilietuKurimas(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.Clear();
            Console.WriteLine("Bilietu kurimas");
            Console.WriteLine("Pasirinkite bilieto tipa\n[1] - Po 10 Eur\n[2] - Po 20 Eur\n[3] - Po 30 Eur\n[5] - Sugrizti");
          
            int meniuPasirinkimas = int.Parse(Console.ReadLine());
            while(true)
            {
                switch (meniuPasirinkimas)
                {
                    case 1:
                        BilietuKurimas10(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                    case 2:
                        BilietuKurimas20(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                    case 3:
                        BilietuKurimas30(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                    case 5:
                        MainMeniu(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30); ;
                        break;
                }
            }
        }
        private static void BilietuPirkimas10(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.WriteLine("Keik bilietu norite pirkti");
            int kiekis = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= kiekis; i++)
            {
                bilietuTipas10.Remove(1);
                visoParduota10.Add(1);
            }
            MeniuBilietuPirkimas(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
        }
        private static void BilietuPirkimas20(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.WriteLine("Keik bilietu norite pirkti");
            int kiekis = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= kiekis; i++)
            {
                bilietuTipas20.Remove(1);
                visoParduota20.Add(1);
            }
            MeniuBilietuPirkimas(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
        }
        private static void BilietuPirkimas30(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.WriteLine("Keik bilietu norite pirkti");
            int kiekis = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= kiekis; i++)
            {
                bilietuTipas30.Remove(1);
                visoParduota30.Add(1);
            }
            MeniuBilietuPirkimas(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
        }
        private static void MeniuBilietuPirkimas(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.Clear();
            Console.WriteLine("Bilietu pirkimas");

            Console.WriteLine("Pasirinkite bilieto tipa\n[1] - Po 10 Eur\n[2] - Po 20 Eur\n[3] - Po 30 Eur\n[5] - Sugrizti");
            int meniuPasirinkimas = Int32.Parse(Console.ReadLine());
            
            while(true)
            {
                switch (meniuPasirinkimas)
                {
                    case 1:
                        BilietuPirkimas10(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                    case 2:
                        BilietuPirkimas20(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                    case 3:
                        BilietuPirkimas30(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                    case 5:
                        MainMeniu(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30); ;
                        break;
                }
            }
        }
        private static void MainMeniu(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.Clear();
            Console.WriteLine("TIKETA ONLINE");
            Console.WriteLine("----MENIU----\n[1] - Pirkti bilietus\n[2] - Kurti bilietu\n[3] - Ataskaitos\n[5] - Iseiti is programos");

            int meniuPasirinkimas = Int32.Parse(Console.ReadLine());
            if (meniuPasirinkimas == 5)
            {
                return;
            }
            while (true)
            {
                switch (meniuPasirinkimas)
                {
                    case 1:
                        MeniuBilietuPirkimas(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                    case 2:
                        MeniuBilietuKurimas(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                    case 3:
                        MeniuBilietuAtaskaitos(bilietuTipas10, bilietuTipas20, bilietuTipas30,visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
                        break;
                }
            }
        }
        private static void MeniuBilietuAtaskaitos(List<int> bilietuTipas10, List<int> bilietuTipas20, List<int> bilietuTipas30, List<int> visoSukurta10, List<int> visoSukurta20, List<int> visoSukurta30, List<int> visoParduota10, List<int> visoParduota20, List<int> visoParduota30)
        {
            Console.Clear();
           
            Console.WriteLine($"----Sukurta bilietu----\nBilietai po 10 EUR - {visoSukurta10.Sum()}\nBilietai po 20 EUR - {visoSukurta20.Sum()}\nBilietai po 30 EUR - {visoSukurta30.Sum()}\n");
            Console.WriteLine($"----Parduota bilietu----\nBilietai po 10 EUR - {visoParduota10.Sum()}\nBilietai po 20 EUR - {visoParduota20.Sum()}\nBilietai po 30 EUR - {visoParduota30.Sum()}\n");
            Console.WriteLine($"----Bilietu likutis kasoje----\nBilietai po 10 EUR - {bilietuTipas10.Sum()}\nBilietai po 20 EUR - {bilietuTipas20.Sum()}\nBilietai po 30 EUR - {bilietuTipas30.Sum()}\n");

            Console.WriteLine("[5] - Sugrizti");
            int meniuPasirinkimas = Int32.Parse(Console.ReadLine());
            if (meniuPasirinkimas == 5)
            {
                MainMeniu(bilietuTipas10, bilietuTipas20, bilietuTipas30, visoSukurta10, visoSukurta20, visoSukurta30, visoParduota10, visoParduota20, visoParduota30);
            }
            else if (meniuPasirinkimas != 5)
            {
                Console.WriteLine("Neteisingas pasirinkimas");
            }

        }
    }
}