using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2
{
    public class Vegetable:Product
    {
        public string Name { get; set; }
        public int Fibrous { get; set; }
        
        public Vegetable(string name, decimal price, string barcode, int weight, int fibrous)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Weight = weight;
            Fibrous = fibrous;
        }
    }
}
