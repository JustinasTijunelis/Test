using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public int Weight { get; set; }

        public Product() { }
        public Product(decimal price, string barcode, int weight)
        {
            Price = price;
            Barcode = barcode;
            Weight = weight;

        }
    }
}
