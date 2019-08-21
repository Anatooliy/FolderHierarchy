using FolderHierarchy.Models;
using System;
using System.Web;
using System.Web.Routing;

namespace FolderHierarchy.Core
{
    public class FolderRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var db = new FolderContext();

            if (values[parameterName] != null)
            {
                string folderLink = values[parameterName].ToString().Trim('/');
                Folder folder = FolderWorker.GetFolderByLink(folderLink);
                string folderLinkFromDb = FolderWorker.GetFolderLink(folder).Trim('/');

                if (String.Compare(folderLink, folderLinkFromDb) != 0)
                {
                    return false;
                }                              
            }

            return true;
        }
    }
}