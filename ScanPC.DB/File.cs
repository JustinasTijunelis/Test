using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanPC.DB
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public List<Folder> Folders { get; set; }

        public File(string name, string path, long size)
        {
            Id = Guid.NewGuid();
            Name = name;
            Path = path;
            Size = size;
            Folders = new List<Folder>();
        }
   
       

    }
}
