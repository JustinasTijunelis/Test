using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanPC.DB
{
    public class FolderRepository
    {
        private readonly FolderContext _dbContext;
        public FolderRepository()
        {
            _dbContext = new FolderContext();
        }
        public void FolderCategory(Folder folder)
        {
            _dbContext.Folders.Add(folder);
            _dbContext.SaveChanges();

        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
