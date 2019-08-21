using System.Data.Entity;

namespace FolderHierarchy.Models
{
    public class FolderContext : DbContext
    {
        public DbSet<Folder> Folders { get; set; }
    }
}