using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2.Repositories
{
    public class CandyRepositories
    {
        public List<Candy> Candies { get; set; }
        
        public CandyRepositories()
        {
            Candies = new List<Candy>();
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\VStudio\PrekiuSarasai\Candies.csv");
            for (int i = 0; i < csvLines.Length; i++)
            {
                var rowData = csvLines[i].Split(';');
                Candies.Add(new Candy ( rowData[0], Convert.ToDecimal( rowData[1]), rowData[2], Convert.ToInt32( rowData[3]), Convert.ToInt32( rowData[4])));
            }

        }
        
    }
}
