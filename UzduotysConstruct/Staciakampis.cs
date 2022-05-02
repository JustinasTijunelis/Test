using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staciakampis
{
    public struct Staciakampis1
    {
        public int Plotis { get; set; }
        public int Ilgis { get; set; }

        public void Plotas (int Plotis, int Ilgis)
        {
            Console.WriteLine($"Jusu staciakampio plotis{(Plotis*Ilgis)}");
        }
    }
}
