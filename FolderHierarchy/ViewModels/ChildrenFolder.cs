using FolderHierarchy.Core;
using FolderHierarchy.Models;

namespace FolderHierarchy.ViewModels
{
    public class ChildrenFolder
    {
        public string FolderName { get; }
        public string FolderLink { get; }

        public ChildrenFolder(Folder folder)
        {
            FolderName = folder.FolderName;
            FolderLink = FolderWorker.GetFolderLink(folder);
        }  
    }
}