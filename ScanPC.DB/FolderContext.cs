using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanPC.DB
{
    
    public class FolderContext : DbContext
    {
        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder option) =>
            option.UseSqlServer($"Server=localhost;Database=ScanPC;Trusted_Connection=True;");
    }
}
