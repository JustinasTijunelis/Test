using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2.Repositories
{
    public class VegetableRepositories
    {
        private List<Vegetable> Vegetables { get; set; }
        public VegetableRepositories()
        {
            Vegetables = new List<Vegetable>();
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\VStudio\PrekiuSarasai\Vegetables.csv");
            for (int i = 0; i < csvLines.Length; i++)
            {
                var rowData = csvLines[i].Split(';');
                Vegetables.Add(new Vegetable (rowData[0], Convert.ToDecimal(rowData[1]), rowData[2], Convert.ToInt32(rowData[3]), Convert.ToInt32(rowData[4])));
            }

        }
    }
}
