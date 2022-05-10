namespace Delegat
{

    public class Class
    {
        static readonly int GlobalNumber = 10;
        private delegate int NumberChanger (int n);
        //uzduotis 1
        private delegate string Print(string firstName, string lastName, int age);
        private delegate int NumberSum(int number1, int number2);
        private delegate List<int> ReturnList(List<int> List, int steps);

        //    private string FirtName { get; set; }
        //    private string LastName { get; set; }
        //    private string Age { get; set; }
        //private Human()
        //{
        //    FirtName = "Jonas";
        //    LastName = "Petraitis";
        //    Age = "18";

        //}

        public static void Main(string[] args)
        {
            //iskvieti metodus
            var numberChange = new NumberChanger (AddNumber);       //sukuriamas kaip referenc tipas
            var numberChange2 = new NumberChanger(SubstractNumber);
            var printDelegate = new Print(ConcatInfo);
            Console.WriteLine(printDelegate("Jonas", "Petraitis", 18));

            var nuberSum = new NumberSum(ReturnNumersSum);
            Console.WriteLine(nuberSum((10),(23)));

            var listBySteps = new ReturnList(ReturnBySteps);
            var SkaiciuListas = new List<int> { 12, 13, 14, 15, 16, 17 };


            Console.WriteLine(numberChange(5));   // (5) paduodamas Int 
            Console.WriteLine(numberChange2(6));

        }
        private static int AddNumber(int number)
        {
            return GlobalNumber + number;
        }
        private static int SubstractNumber(int number)
        {
            return (GlobalNumber - number);
        }
        private static void PassMethod(NumberChanger method, int number)
        {
            Console.WriteLine(method.Invoke(number));
        }
        private static  string ConcatInfo(string firstName, string lastName, int age)
        {
            return firstName + lastName + age;  
        }
        private static int ReturnNumersSum(int number1, int number2)
        {
            return number1 + number2;
        }
        private static List<int> ReturnBySteps(List<int> List, int step)
        {
            var result = new List<int>();
            for (int i = 1; i<= List.Count; i += step)
            {
                List.Add(i);
            }
            return result;
        }
    }
}
