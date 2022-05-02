using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1

{
    public struct Mokinys
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime KursoPradzia { get; set; }
        public DateTime KursoPabaiga { get; set; }

        public void VietaC(string Vardas, string Pavarde, DateTime KursoPradzia, DateTime KursoPabaiga)
        {

            Console.WriteLine($"Vardas - {Vardas}\nPavarde - {Pavarde}\nKurso pradzia - {KursoPradzia}\nKurso pabaiga - {KursoPabaiga}");
        }
        public struct BibliotekosKnyga
        {
            public string ID { get; set; }
            public string Pavadinimas { get; set; }
            public string SkaitytojoVardas { get; set; }

            public string SkaitytojoPavarde { get; set; }

            public DateTime PaemimoData { get; set; }

            public int LaikasNuoPasiemimo(DateTime PaemimoData)
            {
                DateTime siandien = DateTime.Now;
                DateTime total = PaemimoData - siandien;
                //DateTime pradelsta = siandien.ToShortDateString - PaemimoData.ToShortDateString;
             
                return //int (siandien - PaemimoData).TotalDays;
            }
        }
    }
    
}
