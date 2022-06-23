using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanPC.DB
{
    public class Folder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<File> Files { get; set;}
        public Folder(string name)
        {
            Guid Id = Guid.NewGuid();
            Name = Name;
            Files = new List<File>();
        }

        
    }
}
