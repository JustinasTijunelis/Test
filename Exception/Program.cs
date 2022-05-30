namespace Exception
{

    public class Class
    {
        public string ToDouble(string value)
        {
            Convert.ToDouble(value);
            return value;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine(arr[7]);
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                   // Console.WriteLine(arr[i]);
                }
                Console.WriteLine(arr[7]); //out of the array 
            }
            catch (IndexOutOfRangeException ex)
            {
              
                
                Console.WriteLine($"Error {ex}");

            }
            finally
            {

            }


            try
            {
                var x = new Class();
                string v = "a";
                x.ToDouble(v);
                //statements
            }
            catch (FormatException ex)
            {
                //error handling  code
                Console.WriteLine($"Exeption Cought {ex}");
                Console.ReadKey();

            }
            finally
            {
                //statements to be executed
            }

        }
    }
    
}