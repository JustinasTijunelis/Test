using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas
{
    public class CreditCard
    {
        public string CardPin { get; set; }
        public string CardUserPin { get; set; }
        public decimal CardAmount { get; set; }
      
        public CreditCard (string[] pin)
        {   
            CardPin = pin[0].Trim('"');
            CardUserPin = pin[1].Trim('"');
            CardAmount = Convert.ToDecimal(pin[2].Trim('"'));
        }
        public void CardAmountPrint()
        {
            
            Console.WriteLine($" Jusu saskaitos likutis {CardAmount}");
        }
        public static decimal CashOut(decimal CardAmount)
        {
            Console.WriteLine($"Jusu inigu likutis {CardAmount} EUR");
            Console.WriteLine("Iveskite norima papildyti suma");
            decimal addAmount = Convert.ToDecimal(Console.ReadLine());
            decimal CardAmount2 = addAmount + CardAmount;
            Console.WriteLine($"Jusu esamas balansas {CardAmount} EUR");
            return CardAmount2;
        }
    }
}
