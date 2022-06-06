using CiliPizzaOder.Entities;
using CiliPizzaOder.Repositories;
using CiliPizzaOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiliPizzaOder
{

    public class MainMenu
    {
        
        public string LogIn()
        {
            Console.WriteLine("Please Log in");
            Console.WriteLine("Enter your Name");
            string waiterName = Console.ReadLine();
            return waiterName;
        }
        public void RunMainMenu()
        {
            string prompt = @"
     ______     __     __         __        ______   __     ______     ______     ______       
    /\  ___\   /\ \   /\ \       /\ \      /\  == \ /\ \   /\___  \   /\___  \   /\  __ \      
    \ \ \____  \ \ \  \ \ \____  \ \ \     \ \  _-/ \ \ \  \/_/  /__  \/_/  /__  \ \  __ \     
     \ \_____\  \ \_\  \ \_____\  \ \_\     \ \_\    \ \_\   /\_____\   /\_____\  \ \_\ \_\    
      \/_____/   \/_/   \/_____/   \/_/      \/_/     \/_/   \/_____/   \/_____/   \/_/\/_/    
                                                                                           
                                Welcome to the best Pizza House
----------------------------------------------------------------------------------------------
Cili Pizza Order platform

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
        
        string prompt = "Make some order !!! \n " +
            "Select from the menu and push Enter \n" +
            "---------------------------------------------------------------";
        string[] options = { "Take table Order", "Ceck Order", "Back" };
        Menu walletMenu = new Menu(options, prompt);
        int selectedIndex = walletMenu.Run();
        switch (selectedIndex)
        {
            case 0:
                TakeTableOrder();
                break;
            case 1:
                CeckOrder_1();
                break;
            case 2:
                TableOrders();
                break;
        }

    }
        public void TakeTableOrder()
        {
            //int tableId = 0001; //kiekvienas staliukas turi savo Id

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

            string prompt = "--------------- \n " +
                "Select from the menu and push Enter \n" +
                "---------------------------------------------------------------";
            //Console.WriteLine($"Jusu pinigineje {x} EUR");

            string[] options = products.Concat(new string[] { "Back" }).ToArray();
           
            Menu walletMenu = new Menu(options, prompt);
            int selectedIndex = walletMenu.Run();

            if (options[selectedIndex].Contains("Back"))
            {
                TableOrders();
            }
            else
            {
                //var orderList = new OrderRepository(new Order (new List<Order>()));
                int quantity = Convert.ToInt32(Console.ReadLine());
                int table = Convert.ToInt32(Console.ReadLine());
                tableOrders = new List<Order>();
                //TableRepository = new List<Order>();
                tableOrders.Add(new CiliPizzaOder.Entities.Order("fanta", Convert.ToDecimal(2.20), quantity, "Justinas", "123msdk21asd",
                   table, DateTime.Now, false));
                tableOrders.ForEach(e => Console.WriteLine(e));
                Console.ReadKey();
                TakeTableOrder();
                
            }
           

        }
        public void CeckOrder_1()
        {
        string prompt = "Your Orders \n " +
            "Select from the menu and push Enter \n" +
            "---------------------------------------------------------------";
        string[] options = { "Pay Ordres",  "Back" };
        Menu walletMenu = new Menu(options, prompt);
        int selectedIndex = walletMenu.Run();
            //var ordersRepository = new OrdersRepository();
            Console.WriteLine("Enter Table number");
            string tableNum = Console.ReadLine();

        var order = new CiliPizzaOder.Entities.Order();
            var selectedTableList = order.TableRepository.Where(i => i.TableId.Equals(tableNum) && i.Paid == false).ToList();
           order.PrintOrderList(selectedTableList);

        switch (selectedIndex)
            {
            case 0:
                 selectedTableList.Select(i => i.Paid = true);
                    Console.WriteLine("Order has been paid");
                    Console.ReadKey();
                 break;
             case 1:
                 TableOrders();
                 break;
            }

        }
        private void TurnoverOfTheDay()
        {
            
            string prompt = "Turnover of fhe Day \n " +
                "Select from the menu and push Enter \n" +
                "---------------------------------------------------------------";
            string[] options = { "Back" };
            Menu walletMenu = new Menu(options, prompt);
            int selectedIndex = walletMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    TableOrders();
                    break;
            }

        }
        public void WaitressTips()
        {

            var program = new MainMenu();
            var waiterName = program.LogIn(); //negrazina man padavejos 
            
            string prompt = $" {waiterName} Jusu asmenine pinigine BARBOROS e-parduotuveje \n " +
                "Select from the menu and push Enter \n" +
                "---------------------------------------------------------------";
           
            string[] options = { "Back" };
            Menu walletMenu = new Menu(options, prompt);
            int selectedIndex = walletMenu.Run();

            var ordersRepository = new Order();
            ordersRepository.PrintList(new List<decimal> (ordersRepository.WaitressTips));
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
