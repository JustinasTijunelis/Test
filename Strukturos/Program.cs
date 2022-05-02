using Strukturos;

namespace strukturos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Studentas pimas = new Studentas();
            Console.WriteLine($"{pimas} vidurkis yra ");
        }
        public static decimal CalculateTax(decimal income)
        {
            decimal result = 0;
            if (income <= 4000)
            {
                result = income * 0.05m;
            }
            else if (income > 4000 && income <= 10000)
            {
                result = income * 0.15m;
            }
            else
            {
                result = income * 0.25m;
            }
            return result;
        }
}
}