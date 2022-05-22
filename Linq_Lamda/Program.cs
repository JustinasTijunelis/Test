using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lamda
{
    class Program
    {
        public class Human
        {
            public string Name { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
            public bool isHuman { get; set; }

            public List<Animal> Animals { get; set; }
        }

        public class Animal
        {
            public string Name { get; set; }
        }

       
        static void Main(string[] args)
        {
            // First parameter is input
            //Sekond parameter is output
            Func<string, string> selector = str => str.ToUpper();

            //Inputas
            string[] words = { "orange", "apple", "article", "dog" };

            //SELECT
            //Naudojamas su Func
            var upperWords = words.Select(selector);

            //nenurodoma funkcija, "Select" kaip itaracija veikia, paima po viena ir "s.ToUpper" atliekama funkcija
            var upperWords2 = words.Select(s => s.ToUpper());

            //WHERE
            //Suranda sarase ir ideda i lista, grazina kaip lista o ne stringa, todel visada gausis Colection 
            var wordsWhere = words.Where(s => s.Contains("orange"));

            //OrderBy/ OrderByDescending
            //sortina nuo didziausio i maziausia, pagal abecele, data ir tt 
            var humans = new List<Human> { new Human { Name = "John" }, new Human { Name = "Tom" } };
            //sortina i viena puse
            var orderByHumansAscending = humans.OrderBy(s => s.Name);
            //sortina i kita puse 
            var orrderByHumansDescending = humans.OrderByDescending(s => s.Name);

            //First or Defoult
            //grazina pirma pasiaikiusi elementa pagal tam nurodytas salygas
            //FirstOrDefault itaracija pasiima tik pirma pasitaikiusi elementa ir sustoja
            Human john = humans.FirstOrDefault(s => s.Name == "John");
            //SingleOrDefault itaracija pasiima pirma pirma atitinkanti elementa bet nesustoja ir patikrina visus,
            //jei pasitaiko dublikatu ismeta exeption'a 
            Human tom = humans.SingleOrDefault(s => s.Name == "Tom");

            //First / Single

            //Human joe = humans.First(s => s.Name == "Joe");
            //Human joe2 = humans.Single(s => s.Name == "Joe");


            //Uzduotis 1
            //Func<double,double> squeres = double => double.Math.Sqrt();
            int[] number = { 2, 6, 5, 7 };
            var numbersSquares = number.Select(s => Math.Pow(s,2)); //Pakelia kvadratu
            var SquerList= numbersSquares.ToList();

            //
            int[] numbers2 = { 2, 6, 5, -2, -4, -6, 11, 12, 9 };
            var numLesThenZero = numbers2.Where(s => s < 0);
            var lesThenZero = numLesThenZero.ToList();
            //Console.WriteLine(lesThenZero);
            //Console.ReadKey();
            var numMoreThenZero = numbers2.Where((s) => s > 0 && s< 10);
            var moreThenZero = numMoreThenZero.ToList();

            var numSortByLower = numbers2.OrderBy(s => s);
            var numSortByHigher = numbers2.OrderByDescending(s => s);

            //didziausias skaicius sarase 
            var highestNum = numbers2.Max();
            var lowestNum = numbers2.Min();

            //SelectMany 
            //Remepina listus. (List of the list and list. 
            var humansWithAnimals = new List<Human>
            {
                new Human //uzsetinam Listus duomenimis
                {
                    Name = "John",
                    Animals = new List<Animal>
                    {
                        new Animal
                        {
                            Name = "Cat"
                        }
                    }
                },
                new Human
                {
                    Name = "Tom",
                    Animals = new List<Animal>
                    {
                        new Animal
                        {
                            Name = "Cat"
                        },
                        new Animal
                        {
                            Name = "Dog"
                        }
                    }
                },
                new Human
                {
                    Name = "John",
                    Animals = new List<Animal>
                    {
                        new Animal
                        {
                            Name = "Monkey"
                        },
                        new Animal
                        {
                            Name = "Tinger"
                        }
                    }
                }
            };

            var humansWithAnimalsSelect = humansWithAnimals.SelectMany(x => x.Animals); 
            //jei mes norime susikurti nauja lista su visais animal.
        }

    }

}