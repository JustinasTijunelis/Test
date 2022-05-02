using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2
{
    public class Drink : Product
    {
        public string Name { get; set; }
        public int Litre { get; set; }

      
        public Drink(string name, decimal price, string barcode, int weight, int litre)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Weight = weight;
            Litre = litre;
        }

    }
}
