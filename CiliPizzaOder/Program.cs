using CiliPizzaOder;
using CiliPizzaOder.Repositories;

namespace CiliPizzaOrder
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var drink = new DrinksRepository();
            var food = new FoodRepository();
            var order = new OrdersRepository();
            
            
            //var  name = order.WaitressTips;
            //var drink = new DrinksRepository();
            //drink.
            MainMenu runMainMenu = new MainMenu();
            //runMainMenu.RunMainMenu();
            runMainMenu.TakeTableOrder_1();

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm"));
            //Console.ReadKey();  

            //decimal x = 0;
            //MainMenu runMainMenu = new MainMenu(x);

            //runMainMenu.RunMainMenu();
        }
    }
}
