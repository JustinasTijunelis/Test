using System;
using System.Linq;
namespace Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputName = InputName();
            OutputName(inputName);

            //Console.WriteLine("koks jusu vardas");
            //string input = Console.ReadLine();
            //Console.WriteLine("Iveskite skaiciu");
            //var num = Console.ReadLine();
            //string name = GrazinimasName();
            //GrazinimasName(name);
            //Console.WriteLine(num);

        }
       private static string InputName()
        {
            Console.WriteLine("Koks jusu vardas");
           string inputName = Console.ReadLine();
            return inputName;
        }
        //private static int InputName(int num, string name)
        //{
        //    //int num = 0;
           
        //    for (int i = 0; i < num; i++)
        //        num++;
        //    return num;
        //}

        private static void OutputName(string inputName)
        {
            Console.WriteLine($"svaiki {inputName}");
           
        }

     }

}
