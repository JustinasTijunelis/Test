using Projektas2.Repositories;

namespace Projektas2
{
    public class Program
    {


        public static void Main(string[] args)
        {
            decimal x = 0;
            MainMenu runMainMenu = new MainMenu(x);

            runMainMenu.RunMainMenu();

       

            //var candyRepository = new CandyRepositories();

            //var repositories = new Candy(new CandyRepositories(), new DrinkRepositories(), new MeatRepositories(), new VegetableRepositories());
            //var candy = new List<Candy>();
            //Console.WriteLine(candyRepository);
            //Console.ReadLine();
        }
    }


}