using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2
{
    public class Candy : Product
    {
        public string Name { get; set; }
        public int Sugar { get; set; }
        public Candy() { }
        public Candy(string name, decimal price, string barcode, int weight, int sugar)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Weight = weight;
            Sugar = sugar;
           
        }
    }
}
