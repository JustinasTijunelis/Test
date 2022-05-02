using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2
{
    public class MainMenu
    {
        public decimal X { get; set; }
        public MainMenu(decimal x)
        {
            X = x;
        }

        public void RunMainMenu()
        {
            string prompt = @"

   ▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
  ▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
  ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌
  ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌
  ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌
  ▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
  ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀█░▌
  ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌     ▐░▌  ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌     ▐░▌  ▐░▌       ▐░▌
  ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌      ▐░▌ ▐░▌       ▐░▌
  ▐░░░░░░░░░░▌ ▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌
   ▀▀▀▀▀▀▀▀▀▀   ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀         ▀ 
                                                                                             
Sveiki atvyke i elektronine Maximos parduotuve
----------------------------------------------------------------------------------------------

Pasirinkite is meniu ir spauskite ENTER

";

            string[] options = { "Pinigine", "Parduotuve", "Pirkiniu krepselis", "Iseiti is prgramos" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();

            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            switch (selectedIndex)
            {
                case 0:
                    Wollet();
                    break;
                case 1:
                    EShop();
                    break;
                case 2:
                    ShopingCard();
                    break;
                case 3:
                    ExitShop();
                    break;

            }
        }
        private void Wollet()
        {
            decimal x = 0;
            string prompt = "Jusu asmenine pinigine BARBOROS e-parduotuveje \n " +
                "Pasirinkeite is meniu ir spauskite Enter \n" +
                "---------------------------------------------------------------";
            Console.WriteLine($"Jusu pinigineje {x} EUR");
            string[] options = { "Inesti lesas", "Issiimti lesas" };
            Menu walletMenu = new Menu(options, prompt);
            int selectedIndex = walletMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    WolletCashIn(x);
                    break;
                case 1:
                    WolletCashOut();
                    break;
            }

        }
            private decimal WolletCashIn(decimal x)
        {

            Console.Clear();
            ConsoleKey keyPressed1;

            do
            {
                Console.WriteLine($"Noredami sugristi spauskite Backspace \n" +
                    "--------------------------------------------------------- \n" +
                    " ");
                Console.WriteLine($"Jusu pinigineje - {X} EUR");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed1 = keyInfo.Key;
                decimal x1 = Convert.ToDecimal(Console.ReadLine());
                Console.Clear();
                if (x1 > 0)
                {
                    X = x1;

                    //if (x1 < 0)
                    //{
                    //    Console.WriteLine("neteisingai ivestas skaicius");
                    //}


                }
                else if (keyPressed1 == ConsoleKey.Backspace )
                {
                    Console.WriteLine("Neteisingai ivedete skaiciu,bandykite dar karta");
                    Wollet();
                }
            }
            while (keyPressed1 != ConsoleKey.Backspace);
            return x;
        }
            private void WolletCashOut()
        {

            decimal pinigiaPinigineje = Convert.ToDecimal(Console.ReadLine());
        }
        private void EShop()
        {
            string prompt = @"";
            string[] options = { "Saldainiai", "Gerimai", "Mesa", "Darzoves" };
            Menu mainMenu = new Menu(options, prompt);
          
            int selectedIndex = mainMenu.Run();

            ConsoleKey keyPressed;
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;
            //decimal x1 = Convert.ToDecimal(Console.ReadLine());
            do
            {
                switch (selectedIndex)
                {
                    case 0:
                        ShopCandy();
                        break;
                    case 1:
                        ShopDrink();
                        break;
                    case 2:
                        ShopMeat();
                        break;
                    case 3:
                        ShopVegetable();
                        break;
                }

            } 
            while (keyPressed == ConsoleKey.Backspace); { RunMainMenu(); }
        }
            private void ShopCandy()
        {
            string prompt = @"";
            string[] options = { "Sostine", "Irisas", "Rafaelo", "Karuna" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;

            }

        }
            private void ShopDrink()
        {
            string prompt = @"";
            string[] options = { "Alus", "CocaCola", "Pienas", "Brendis" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;


            }
        }
            private void ShopMeat()
            {
            string prompt = @"";
            string[] options = { "Jautiena", "Kiauliena", "Vistiena", "Triusiena" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;


            }

        }
            private void ShopVegetable()
            {

            string prompt = @"";
            string[] options = { "Pomidorai", "Morkos", "Bulves", "Svogunai" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;


            }
        }
         private void ShopingCard()
            {

            }
         private void ExitShop()
            {
                Console.WriteLine("Pres any key to Exit");
                Console.ReadKey(true);          //Uzlaikymas 
                Environment.Exit(0);            //Grazus isejimas is programos kad neuzlustu
            }


        
    }
}
