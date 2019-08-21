using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FolderHierarchy.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string FolderName { get; set; }
        public int? ParentId { get; set; }
        public Folder Parent { get; set; }

        public virtual ICollection<Folder> Folders { get; set; }
        public Folder()
        {
            Folders = new List<Folder>();
        }
    }
}