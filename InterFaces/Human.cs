using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    public class Human : ICanRun, ICanEat //gali paveldeti is ne vieno interfeiso ir jo visus metodus 
    {
        public void Eat()
        {
            Console.WriteLine("Im eating");
        }

        //Metodai is interfeisu,
        public string GetRunnerName(string name)
        {
           Console.WriteLine( $"Runner name is {name}");
            return name;
        }

        public void Run()
        {
            Console.WriteLine("Im runing");
        }
    }
}
