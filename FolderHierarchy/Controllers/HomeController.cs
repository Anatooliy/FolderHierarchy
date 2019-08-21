using FolderHierarchy.Core;
using FolderHierarchy.Models;
using FolderHierarchy.ViewModels;
using System.Web.Mvc;

namespace FolderHierarchy.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string folderLink)
        {   
            if (folderLink != null)
            {                
                Folder currentFolder = FolderWorker.GetFolderByLink(folderLink);

                if (currentFolder == null)
                {
                    return HttpNotFound($"Couldn't find folder");
                }

                return View(new ParentFolder(currentFolder));
            }

            return View(new ParentFolder());
        }       
    }
}
