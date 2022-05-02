namespace UzduotysConstruct
{
    public struct Mokinys
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime KursoPradzia { get; set; }
        public DateTime KursoPabaiga { get; set; }

        public void Vieta(string Vardas, string Pavarde, DateTime KursoPradzia, DateTime KursoPabaiga)
        {

            Console.WriteLine($"Vardas - {Vardas}\nPavarde - {Pavarde}\nKurso pradzia - {KursoPradzia}\nKurso pabaiga - {KursoPabaiga}");
        }

    }
    public struct BibliotekosKnyga
    {
        public int ID { get; set; }
        public string Pavadinimas { get; set; }
        public string SkaitytojoVardas { get; set; }

        public string SkaitytojoPavarde { get; set; }

        public DateTime PaemimoData { get; set; }
        public DateTime SiosDienosData { get; set; }


        public void LaikasNuoPasiemimo(int ID, string Pavadinimas, string SkaitytojoVardas, string SkaitytojoPavarde,
            DateTime PaemimoData, DateTime SiosDienosData)
        {

            Console.WriteLine($"Knygos ID - {ID}, Knygos Pavadinimas - {Pavadinimas}, Skaitytojo Vardas - {SkaitytojoVardas}, " +
                $"Skaitytojo Pavarde - {SkaitytojoPavarde}, Knygos paemimo data - {PaemimoData}, Pradelsta dienu - {(PaemimoData - SiosDienosData)}");
        }

    }
    

 }