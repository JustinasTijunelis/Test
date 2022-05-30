using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas
{
    public class RunMenu
    {
        public RunMenu()
        {
            string prompt = @"
                                                                                             
Sveiki atvyke i MMM Sekundes banka
----------------------------------------------------------------------------------------------

Pasirinkite is meniu ir spauskite ENTER

";          

            string[] options = { "Pinigu likutis", "Transakcijos", "Pinigu isemimas", "Iseiti is prgramos" };
            Menu mainMenu = new Menu(options, prompt);
            int selectedIndex = mainMenu.Run();
            var x = new CreditCardRepository();
            
           
            
            switch (selectedIndex)
            {
                case 0:
                    //x.CardAmountPrint();
                    break;
                case 1:
                    //5Transaction();
                    break;
                case 2:
                    //CashOut();
                    break;
                case 3:
                    //Exit();
                    break;

            }
        }

    }
}
