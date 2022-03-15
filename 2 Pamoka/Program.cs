
namespace Pirma_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string yourName;
            //    int yearOfBirth;
            //    var lastName = "Pavardenis";
            //    decimal salary = 10m; //M iskarto nurodo kad tai Pinigai.naudojama su pinigais
            //    double income = 5000d; // D iskarto nurodo kad tai Double. Darbui su liekana arba po kablelio

            //Priskiriame duomenis
            //yourName = "Vardenis";
            //yearOfBirth = 1990;

            //DateTime lastPayDay1 = new DateTime(2022,03,01);
            //DateTime lastPayDay2 = DateTime.Today.AddDays(-1);

            //Console.WriteLine($"Vardas: {yourName}");
            //Console.WriteLine($"Gimimo metai: {yearOfBirth}");
            //Console.WriteLine($"Paskutini karta ismoketa alga {lastPayDay2}");


            //1 uzduotis

            //int x = 5;
            //int y = 6;
            //int temp; 

            //Console.WriteLine($"Pries \n x: {x} \n y:{y}");
            //x = temp;
            //x = y;
            //y = temp;
            //Console.WriteLine($" Po \n x: {x} \n y:{y}");
            //Console.WriteLine($"Rezultatas pries x = {x} ir y = {y} \n " +
            //    $"Rezultatas po x = {y} ir y = {x}");


            //2 uzduoti + 3
            //string MokName = "Code Academy";
            //string KursName = "C#";
            //int Studsk = 15;
            //DateTime aDate = DateTime.Now; //datos isvedimas, sios dienos
            //string stringDate = aDate.ToString("MM/dd/yyyy"); //pavertimas datos i Stringa ir pasirinkimas ka atvaizduoti
            //DateTime kursDate = new DateTime(2022, 03, 01); //datos isvedimas, sios dienos
            //DateTime endKDate = new DateTime(2022, 10, 01);
            //double totalDaysDiff = (endKDate - endKDate).TotalDays; //minusuoja is skaiciuoja dienu skaisiu



            //Console.WriteLine($"Mokykos pavadinimas: {MokName}, Kursas: {KursName}, Studentu sk: {Studsk},");
            //Console.WriteLine($"Sios dienos data: {stringDate}, \n" +
            //    $" Kurso pradzia: {kursDate}, Kurso trukme: {totalDaysDiff},");

            // Kintamieji ir Operatoriai


            //4+5 Uzduotis
            //do          //Do ir while yra loopas
            //{


            //    Console.WriteLine("Sveiki, prasome iveskite pirma skaiciu");
            //    string input1 = Console.ReadLine();

            //    bool isValidNumber = Int32.TryParse(input1, out int number1);
            //    if (isValidNumber)
            //    {
            //        Console.WriteLine("Iveskite antra skaiciu");
            //        string input2 = Console.ReadLine();
            //        bool isValidNumber2 = Int32.TryParse(input2, out int number2);
            //        if (isValidNumber2)
            //        {
            //            bool isEqual = number1 == number2;
            //            Console.WriteLine($"Sie skaiciai {number1}: {number2} yra {isEqual}");
            //            number1--;
            //            number2++;
            //            Console.WriteLine($"Jusu ivestas skaiciu: {number1} ir {number2}");
            //            Console.WriteLine($"Nauji skaiciai: {number1} ir {number2}");
            //        }

            //        else
            //        {
            //            Console.WriteLine("Blogas ivestas skaiciu");

            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Blogas ivestas skaicius");

            //    }

            //} while (true);


            //6 Uzduotis
            //Console.WriteLine("prasome ivesti teksta");
            
            //string text = Console.ReadLine();

            //if (string.IsNullOrEmpty(text))
            //{
            //    //text = String.Empty;

            //    //bool string.IsNullOrEmpty = false;
            //    Console.WriteLine($"Jus nieko neivedete");
            //}

            //else 
            
            //       Console.WriteLine($"Jusu textas {text}");
            
            //7 Uzduoti

            //do
            //{
            //    //bool number1 = false;
            //    Console.WriteLine("Iveskite skaiciu");
               
            //    String input = Console.ReadLine();
            //    bool isvalid = Int32.TryParse(input, out int number1);

            //    if (number1 < 0)
            //    {
            //        Console.WriteLine(true);
            //    }
            //    else
            //        Console.WriteLine(false);


            //} while (!false);

            //8 uzduotis 

            Console.WriteLine("Iveskite savo varda");
            string input1 = Console.ReadLine();
            Console.WriteLine("Iveskite savo pavarde");
            string input2   = Console.ReadLine();   

            bool sutampa = string.Equals(input1, input2, StringComparison.OrdinalIgnoreCase);
            if (sutampa)
            {
                Console.WriteLine("sutampa");
            }
            else
            {
                Console.WriteLine("Nesutampa");
            }
        }
    }
}
