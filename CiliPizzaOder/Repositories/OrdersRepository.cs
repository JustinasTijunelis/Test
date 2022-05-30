using CiliPizzaOder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiliPizzaOder.Repositories
{
    public class OrdersRepository
    {
        public List<Order> OrderRepository { get; set; }


        public OrdersRepository()   
        {
            OrderRepository = new List<Order>();
        }
        //Table1Order.Add(new List<Order>() { "arbata", 2.2, 2, "02-12-2022", "Justinas" };
    }
}
