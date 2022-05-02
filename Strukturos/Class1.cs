using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturos
{
   public struct Studentas
    {
        public string Vardas;
        public string Pavarde;
        public int Tremetstras1;
        public int Tremetstras2;
        public int Tremetstras3;
        
        public static int Vidurkis(int trimestras1, int trimestras2, int trimestras3)
        {
           return (trimestras1 + trimestras2 + trimestras3) / 3;
        }

    }
}

