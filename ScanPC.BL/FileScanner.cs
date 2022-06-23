using ScanPC.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanPC.BL
{
    public class FileScanner
    {
        public List<ScanPC.DB.File> Files { get; set; }
        public List<Folder> Folders { get; set; }
         public FileScanner()
        {
            Files = new List<ScanPC.DB.File>();
            Folders = new List<Folder>();

        }
        public void ScanFile(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Files.Add(new ScanPC.DB.File(Path.GetFileName(file), file,  new System.IO.FileInfo(file).Length));
                                
            }
        }
        public void ScanFolder(string path)
        {
            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
            {
                Folders.Add(new Folder(folder));

            }
        }
    }
}
