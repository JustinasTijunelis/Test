namespace Bankomatas
    
{
    public class Program
    {


        public static void Main(string[] args)
        {

            var creditCardRepository = new CreditCardRepository();
            //creditCardRepository.Access("123");
            var creditCrards = creditCardRepository.CreditCards;  //issikvieciame lista su Pin duomenimis

            var creditCard = creditCrards[0]; //Pasiimame pirma is listo saraso 

            creditCard.CardAmountPrint(); // dabar galima callinti metoda 


           string inputNew = Console.ReadLine();

            List<string> pins = new List<string>() { "1234", "aks9349", "asjiasd" };

            // var contactIds = pins.Select(contact => contact).ToList();
            //var clients = inputNew.Where(c => inputNew.Contains(pins[1])).ToString();
            if (pins.Contains(inputNew))
            { Console.WriteLine("teisingai"); }             
           
            else { Console.WriteLine("neteisingai"); }

            //Console.WriteLine("neteisingai");
            Console.ReadKey();
            //var data = new CreditCardRepository();
            ////var runMeniu = new RunMenu();
            //data.Show();




        }
    }
}
           