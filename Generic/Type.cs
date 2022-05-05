using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Type <T1,T2>
    {
        public T1 Tipas1 { get; set; }
        public T2 Tipas2 { get; set; }

        public void GetType()
        {
            Console.WriteLine(Tipas1.GetType());
            Console.WriteLine(Tipas2.GetType());
            Console.ReadKey();

        }
    }
}
