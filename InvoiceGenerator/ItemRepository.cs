using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    public class ItemRepository
    {
        public List<Item> Items { get; set; }

        public ItemRepository()
        {
            Items = new List<Item>();
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\VStudio\InvoiceGenerator\NoneApril.csv");
            for (int i = 2; i < csvLines.Length; i++)
            {

                string[] rawData = csvLines[i].Split(';');
                if (string.IsNullOrEmpty(rawData[0])) 
                {
                    break;
                }
                
                    Items.Add(new Item(rawData));
             }
        }
       

    } 
}

