using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas
{
    public class CreditCardRepository
    {
        public List<CreditCard> CreditCards { get; set; }

        public CreditCardRepository()
        {
            CreditCards = new List<CreditCard>();
            
           var csvLines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\VStudio\Bankomatas\CardPin.csv");
           
            for (int i = 0; i < csvLines.Length; i++)
            {
                string[] pin = csvLines[i].Split(';');
                if (string.IsNullOrEmpty(pin[0]))
                {
                    break;
                }

                CreditCards.Add(new CreditCard(pin));
            }
        }
    }

}
