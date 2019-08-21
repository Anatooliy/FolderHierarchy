using FolderHierarchy.Models;
using System.Linq;

namespace FolderHierarchy.Core
{
    public class FolderWorker
    {
        private static FolderContext db = new FolderContext();

        public static Folder GetFolderByLink(string folderLink)
        {            
            string folderName = folderLink.Trim('/').Split('/').Last();
            
            return db.Folders.FirstOrDefault(f => f.FolderName.ToLower() == folderName.ToLower());
        }

        public static string GetFolderLink(Folder folder)
        {
            if (folder.Parent == null)
            {
                return $"{folder.FolderName}";
            }
            else
            {
                return $"{GetFolderLink(folder.Parent)}/{folder.FolderName}";
            }            
        }

        public static Folder GetMainFolder()
        {           
            return db.Folders.FirstOrDefault(f => f.Parent == null);
        }
    }
}