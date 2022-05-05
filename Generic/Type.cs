using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    // Tecia uzduotis 1_1
    public class ShowValues<T1,T2>
    {
        public T1 Tipas1 { get; set; }
        public T2 Tipas2 { get; set; }
        public List<T1> MySelfCreatedList { get; private set; }


        public void GetType()
        {
            Console.WriteLine(Tipas1.GetType());
            Console.WriteLine(Tipas2.GetType());
            Console.ReadKey();

        }
        //Trecia uzduotis 1_2
         public  T1 GetType (T1 input)
        {
            Console.WriteLine(input.GetType().Name);  // Su T1 inputu,  "Name" Tipo pavadinimas
            Console.ReadKey();
            return input;

        }
        // Trecios uzduoties papildymas 1_1
        public void MySelfCreatedListDelete()
        {
            MySelfCreatedList.Clear();
        }
    }
}
