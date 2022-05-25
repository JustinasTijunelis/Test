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
        public List<CreditCard> PinCard { get; set; }
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
        public void CashOut(decimal CardAmoun)
        {
            Console.WriteLine($"Jusu inigu likutis {CardAmount} EUR");
            Console.WriteLine("Iveskite norima papildyti suma");
            decimal addAmount = Convert.ToDecimal(Console.ReadLine());
            CardAmoun = addAmount * CardAmoun;
            Console.WriteLine($"Jusu esamas balansas {CardAmoun} EUR");

        }
    }
}
