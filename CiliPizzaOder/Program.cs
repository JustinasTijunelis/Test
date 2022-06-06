using CiliPizzaOder;
using CiliPizzaOder.Entities;
using CiliPizzaOder.Repositories;
using System.Collections.Generic;

namespace CiliPizzaOrder
{
    public class Program
    {
       
        
        public static void Main(string[] args)
        {
          
            var drinkReprsytory = new DrinksRepository();
            var ordersRepository = new OrdersRepository();
            var food = new FoodRepository();
            var order = new Order();
            var mainMenu = new MainMenu();
            mainMenu.LogIn();

            //var naujasListas = new List<string>() { "Petras", "Jonas", "Antanas" };
            //order.PrintOrderList(naujasListas);
            //Console.ReadKey();

            //order.PrintList(List<Drink> Drinks);
            MainMenu runMainMenu = new MainMenu();
            runMainMenu.RunMainMenu();
            //runMainMenu.TakeTableOrder_1();

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm"));
            //Console.ReadKey();  

            //decimal x = 0;
            //MainMenu runMainMenu = new MainMenu(x);

            //runMainMenu.RunMainMenu();
        }
        
    }
}
