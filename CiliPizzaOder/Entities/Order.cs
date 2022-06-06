using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiliPizzaOder.Entities
{
    public class Order
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string WaiterName { get; set; }
        public string Id { get; set; }
        public int TableId { get; set; }
        public DateTime DateTime { get; set; }
        public bool Paid { get; set; }
        
        public List<Order> TableRepository { get; set; }
        public List<Order> TurnoverOfTheDay { get; set; }
        public List<decimal> WaitressTips { get; set; }

        public Order() { }
        public Order(string name, decimal price, int quantity,string waiterName, string id,
            int tableId, DateTime dateTime, bool paid) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            WaiterName = waiterName;
            Id = id;
            TableId = tableId;
            DateTime = dateTime;     //Reikes uzsetinti Console.WriteLine(DateTime.ToString("MM/dd/yyyy HH:mm"));
            Paid = paid;
            //TableRepository = new List<Order>();
            TurnoverOfTheDay = new List<Order>();
            WaitressTips = new List<decimal>() { 10, 20 };
        }
       
        public void PrintList(List<decimal> Name)
        {
            foreach (var item in Name) //Listo atvaizdavimas consoleje.
            {
                Console.WriteLine($"{Name} EUR");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine($"Your tips TODAY is {Name.OrderByDescending(x => x).Take(2).Sum()} EUR");
            Console.ReadKey();
        }
        public void PrintOrderList(List<Order> Name)
        {
            Name.ForEach(e => Console.WriteLine(e));
            
            Console.ReadKey();
        }
        
    }
}
