namespace Generic
{
    public class GenericClass <T1,T2>
    {
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
            //Validate<Validation>(new Validation { Name = "Jonas", LastName="Petrauskas"});
            //Validate<string>()
            

        }
        private void Validate<T> (T item)
        {
            Console.WriteLine();
        }
    }
    
}