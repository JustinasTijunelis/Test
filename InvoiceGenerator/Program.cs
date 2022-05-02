namespace InvoiceGenerator
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var data = new ItemRepository();
            var runGenerator = new RunInvoiceGenerator();
            runGenerator.GenerateExel(data.Items);
            Console.WriteLine("Saskaitos sugeneruotos");
            Console.ReadKey();

        }
    }
}