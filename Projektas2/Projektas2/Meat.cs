using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2
{
    public class Meat : Product
    {
        public string Name { get; set; }
        public int Proteine { get; set; }

        public Meat(string name, decimal price, string barcode, int weight, int proteine)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Weight = weight;
            Proteine = proteine;

        }

    }
}
