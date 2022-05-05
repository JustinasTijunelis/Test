using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        
        public double GetArea()
        {
            double area = Base * Height;
            return area;
        }
        public override string ToString()
        {
            return GetArea().ToString();
        }
        //public override string ToString1()
        //{
        //    return Name.ToString();
        //}
    }
    public class Generator <T>
    {
        public void Show (T Item)
        {
            Console.WriteLine(Item);
        }

    }
}
