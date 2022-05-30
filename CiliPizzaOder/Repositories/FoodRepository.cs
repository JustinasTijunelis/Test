using CiliPizzaOder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiliPizzaOder.Repositories
{
    public class FoodRepository
    {
        public List<Food> Foods { get; set; }

        public FoodRepository()
        {
            Foods = new List<Food>();
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\VStudio\CilliPizzaApp\Food.csv"); // Failas nesukurtas
            for (int i = 0; i < csvLines.Length; i++)
            {
                var rowData = csvLines[i].Split(';');
                Foods.Add(new Food(rowData[0], Convert.ToDecimal(rowData[1])));
            }

        }
    }
}
