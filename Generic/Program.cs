namespace Generic
{
    
    public class GenericClass <T1,T2>
    {
        //Pirma uzduotis 1_2
        public T1 Property { get; set; }
        public T2 Property2 { get; set; }

        public void PrintT1()
        {
            Console.WriteLine(Property);
        }

        public void PrintT2()
        {
            Console.WriteLine(Property2);
        }
        public T1 ChangeT1 (T1 value)
        {
            Property = value;
            return value;
        }
        public T2 ChangeT1(T2 value)
        {
            Property2 = value;
            return value;
        }
        public static void Main(string[] args)
        {
            // Antra uzsuoti 1_1        Kaip iskviesti Generik Klaseje esanti metoda
            var validation  = new GenericClass<T1,T2> ();
            validation.Validate<string>(null);

            var type = new ShowValues<T1, T2>();

        }
        // Pirma uzsuoti 1_1   Kaip sukurti Metoda Generic klaseje
        private void Validate<T> (T item)
        {
            if (item == null)
            {
                Console.WriteLine("Error");
            }

        }

        

    }

}