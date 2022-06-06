using CiliPizzaOder.Entities;
using CiliPizzaOder.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CiliPizzaOder
{
    public class Menu //Siam menu butina naudoti "using static System.Console;"
    {
        private int SelectedIndex;
        private string[] Options; // naudojame [] meniu pasirinkimo variantai(Pinigine,Pirkti prekes, Exit)
        private string Prompt;
        public Menu(string[] options, string prompt)
        {
            Options = options;
            Prompt = prompt;
            SelectedIndex = 0;
        }
        public void DisplayOtion()  //Turetu buti Privat ? 
        {
            //WriteLine(Prompt);
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++) //Lenght naudojame kad apintume visa [] visus meniu variantus
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;  //Kursorio vietos indeksavimas
                    BackgroundColor = ConsoleColor.White;

                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                //Console.WriteLine("-----------------");
                Console.WriteLine($"{prefix}<<{currentOption}>>");   //Atvaizduja viska ka mes itaruojame

            }
            ResetColor();

        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOtion();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;   //updaitina SelectedIndex kur yra kursorius
                if (keyPressed == ConsoleKey.UpArrow)  //kursorio judejimas aukstyn ir zemyn keiciant SelectIndex
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)     // SelectIndeks neturi buti -1 nes kursoriu pradings
                    {
                        SelectedIndex = Options.Length - 1; // Kusrsoriaus sukimasis ratu
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
                //else if (keyPressed == ConsoleKey.E)
                //{
                //    //TableRepository list ORder 
                //    var order = new Order();
                //    var tableOrders = order.TableRepository;
                //    var mainMenu = new MainMenu();
                //    var drinksRepository = new DrinksRepository();
                //    var drinks = drinksRepository.Drinks;
                //    //var takeOrder = mainMenu.TakeTableOrder_1();
                //    //var selectedTableNumber = mainMenu.TableOrders(tableNumber);
                //    //Char lasChar = [Length - 1]) ; 
                //    Console.WriteLine($" jus pasirinkote {SelectedIndex.ToString(Options[SelectedIndex])} \n" +
                //        $"ivestite kieki ");
                //    int quantity = Convert.ToInt32(Console.ReadLine());
                //    int table = Convert.ToInt32(Console.ReadLine());
                //    tableOrders = new List<Order>();
                //    tableOrders.Add(new Entities.Order("fanta", Convert.ToDecimal(2.20), quantity, "Justinas", "123msdk21asd",
                //       table , DateTime.Now, false));
                //    //Console.WriteLine(tableOrders[0]);
                //}
            } while (keyPressed != ConsoleKey.Enter);  //Lupas veiks tol kol nepaspaus Enter

            return SelectedIndex;   //grasinama Indeksas ir kiekviena karta atnaujinamas (online update)
        }
    }
}
