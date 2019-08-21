using FolderHierarchy.Core;
using FolderHierarchy.Models;
using System.Collections.Generic;


namespace FolderHierarchy.ViewModels
{
    public class ParentFolder
    {
        public string FolderName { get; } = "";
        public List<ChildrenFolder> childrenFolders { get; } = new List<ChildrenFolder>();

        public ParentFolder()
        {
            childrenFolders.Add(new ChildrenFolder(FolderWorker.GetMainFolder()));
        }

        public ParentFolder(Folder currentFolder)
        {
            FolderName = currentFolder.FolderName;

            foreach(var folder in currentFolder.Folders)
            {
                childrenFolders.Add(new ChildrenFolder(folder));
            }            
        } 
    }
}