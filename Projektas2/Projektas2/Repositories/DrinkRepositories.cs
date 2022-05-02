using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2.Repositories
{
    public class DrinkRepositories
    {
        private List<Drink> Drinks { get; set; }
        public DrinkRepositories()
        {
            Drinks = new List<Drink>();
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\VStudio\PrekiuSarasai\Drinks.csv");
            for (int i = 0; i < csvLines.Length; i++)
            {
                var rowData = csvLines[i].Split(';');
                Drinks.Add(new Drink(rowData[0], Convert.ToDecimal(rowData[1]), rowData[2], Convert.ToInt32(rowData[3]), Convert.ToInt32(rowData[4])));
            }

        }
    }
}
