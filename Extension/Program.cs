namespace Extension
{

    public class Class
    {
        public static void Main(string[] args)
        {
            string firstName = "Jonas";
            string lastName = "Petraitis";
            int num = 0;
            int num2 = 1;
            string sentence = "Parasytas sakinys";
            bool flag = num.BoolTrue();
            Console.WriteLine(firstName.Email(lastName));  //isvedimas i konsole
        }

    }
    public static class Extension 
    {
        
        public static bool BoolTrue(this int num)
        {
            if (num >= 0)                   //Ar skaicius yra teigiamas
            {
                return true;
            }
            return false;
        }
        public static bool EqualTrue(this int num)
        {
           
            return num%2== 0;               //Ar skaicius yra lyginis
        }
        public static bool HigherNum(this int num, int num2)
        {
            if (num > num2)                 //Ar pirmas skaicius yra didesnis uz antraji
            {
                return false;
            }
            return true;
        }
        public static bool StringGap(this string sentence)
        {
            if (sentence.Contains(" "))         //Ar sakinyje yra tarpas
            {
                return true;
            }
            return false;
        }
        
        public static string Email(this string firstName, string lastName)
        {
            return firstName + lastName +"@gmail.com";          //Grazina elektronini pasta
        }
    }

   
}