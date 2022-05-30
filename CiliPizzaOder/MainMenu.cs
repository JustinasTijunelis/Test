using CiliPizzaOder.Entities;
using CiliPizzaOder.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiliPizzaOder
{
    public class MainMenu
    {
        //public decimal X { get; set; }
        //public MainMenu(decimal x)
        //{
        //    X = x;
        //}

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

            string[] options = { "Table Orders", "Turnover of the day", "Waitress tips", "LOG OFF" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();
            

            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            switch (selectedIndex)
            {
                case 0:
                    TableOrders();
                    break;
                case 1:
                    TurnoverOfTheDay();
                    break;
                case 2:
                    WaitressTips();
                    break;
                case 3:
                    RunMainMenu();
                    break;

            }
        }
        private void TableOrders()
        {
            decimal x = 0;
            string prompt = "Jusu asmenine pinigine BARBOROS e-parduotuveje \n " +
                "Pasirinkeite is meniu ir spauskite Enter \n" +
                "---------------------------------------------------------------";
            Console.WriteLine($"Jusu pinigineje {x} EUR");
            string[] options = { "Table 1", "Table 2", "Table 3", "Table 4", "Back" };
            Menu walletMenu = new Menu(options, prompt);
            int selectedIndex = walletMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    //Table_1();
                    break;
                case 1:
                    //Table_2();
                    break;
                case 2:
                    //Table_3();
                    break;
                case 3:
                    //Table_4();
                    break;
                case 4:
                    RunMainMenu();
                    break;
            }

        }
        private void Table_1()
        {
        decimal x = 0;
        string prompt = "Jusu asmenine pinigine BARBOROS e-parduotuveje \n " +
            "Pasirinkeite is meniu ir spauskite Enter \n" +
            "---------------------------------------------------------------";
        Console.WriteLine($"Jusu pinigineje {x} EUR");
        string[] options = { "Take table Order", "Ceck Order", "Pay Order", "Back" };
        Menu walletMenu = new Menu(options, prompt);
        int selectedIndex = walletMenu.Run();
        switch (selectedIndex)
        {
            case 0:
                TakeTableOrder_1();
                break;
            case 1:
                CeckOrder_1();
                break;
            case 2:
                PayOrder_1();
                break;
            case 3:
                TableOrders();
                break;
        }

    }
        public void TakeTableOrder_1()
        {
            int tableId = 0001; //kiekvienas staliukas turi savo Id

        var drinkRepository = new DrinksRepository(); //Issibviesti klase
        var foodRepository = new FoodRepository();
        var drinks = drinkRepository.Drinks; //Issikviesti Lista
        var food = foodRepository.Foods;

        string[] drinsArrayName = drinks.Select(x => x.Name).ToArray();
        string[] foodArrayName = food.Select(x => x.Name).ToArray();
        var products = foodArrayName.Concat(drinsArrayName).ToArray();
            //Listo pirma dali "Name" convertina i Array - gali buti metodas

        var order = new Order();
        var tableOrders = order.TableRepository;
            
        decimal x = 0;
        string prompt = "Jusu asmenine pinigine BARBOROS e-parduotuveje \n " +
            "Pasirinkeite is meniu ir spauskite Enter \n" +
            "---------------------------------------------------------------";
        Console.WriteLine($"Jusu pinigineje {x} EUR");

        string[] options = products; //reikia ideti arreju string[] ;
        Menu walletMenu = new Menu(options, prompt);
        int selectedIndex = walletMenu.Run();

            //ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            //ConsoleKey keyPressed;
            //keyPressed = keyInfo.Key;

            //if (keyPressed == ConsoleKey.Y && selectedIndex == options[0].Length)
            //{

            //    Console.WriteLine($"Pasirintkai {options[0]}");
            //    Console.ReadLine();

            //    //selectedIndex--;
            //    //int quantity = Convert.ToInt32(Console.ReadLine());
            //    //string name, decimal price, int quantity, DateTime dateTime, string waiterName


            //    //tableOrders.Add(new Entities.Order ("arbata", 2.2, 2, "02-12-2022", "Justinas"));

            //}
        //switch (selectedIndex)
        //{
            //    case 0:
            //        //TakeTableOrder_1();
            //        break;
            //    case 1:
            //        //CeckOrder_1();
            //        break;
            //    case 2:
            //        //PayOrder();
            //        break;
            //    case 3:
            //        TableOrders();
            //        break;
            //}

        }
        public void CeckOrder_1()
        {
        decimal x = 0;
        string prompt = "Jusu asmenine pinigine BARBOROS e-parduotuveje \n " +
            "Pasirinkeite is meniu ir spauskite Enter \n" +
            "---------------------------------------------------------------";
        Console.WriteLine($"Jusu pinigineje {x} EUR");
        string[] options = {  "Back" };
        Menu walletMenu = new Menu(options, prompt);
        int selectedIndex = walletMenu.Run();
            //var ordersRepository = new OrdersRepository();
        var ordersRepository = new Order();
            ordersRepository.PrintList(ordersRepository.TableRepository);

        switch (selectedIndex)
            {
            case 0:
                 Table_1();
                 break;
            }

        }
        private void PayOrder_1()
        {
        decimal x = 0;
        string prompt = "Jusu asmenine pinigine BARBOROS e-parduotuveje \n " +
            "Pasirinkeite is meniu ir spauskite Enter \n" +
            "---------------------------------------------------------------";
        Console.WriteLine($"Jusu pinigineje {x} EUR");
        string[] options = { "Take table Order", "Ceck Order", "Pay Order", "Back" };
        Menu walletMenu = new Menu(options, prompt);
        int selectedIndex = walletMenu.Run();
        switch (selectedIndex)
            {
            case 0:
                //TakeTableOrder();
                break;
            case 1:
                //CeckOrder();
                break;
            case 2:
                //PayOrder();
                break;
            case 3:
                TableOrders();
                break;
            }

        }

        private void TurnoverOfTheDay()
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
                    //WolletCashIn(x);
                    break;
                case 1:
                    //WolletCashOut();
                    break;
            }

        }
        public void WaitressTips()
        {
            decimal x = 0;
            string prompt = "Jusu asmenine pinigine BARBOROS e-parduotuveje \n " +
                "Pasirinkeite is meniu ir spauskite Enter \n" +
                "---------------------------------------------------------------";
            Console.WriteLine($"Jusu pinigineje {x} EUR");
            string[] options = { "Back" };
            Menu walletMenu = new Menu(options, prompt);
            int selectedIndex = walletMenu.Run();

            var ordersRepository = new Order();
            ordersRepository.PrintList(ordersRepository.WaitressTips);
            //Ieinam i metoda kuris parodo dienos arbatpinigius

            switch (selectedIndex)
            {
                case 0:
                    RunMainMenu();
                    break;
                
            }

        }

    }
}
