using CiliPizzaOder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiliPizzaOder.Repositories
{
    public class DrinksRepository
    {
        public List<Drink> Drinks { get; set; }

        public DrinksRepository()
        {
            Drinks = new List<Drink>();
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\VStudio\CilliPizzaApp\Drinks.csv"); //Failas nesukurtas
            for (int i = 0; i < csvLines.Length; i++)
            {
                var rowData = csvLines[i].Split(';');
                Drinks.Add(new Drink(rowData[0], Convert.ToDecimal(rowData[1])));
            }

        }
        
    }
}
