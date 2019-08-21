using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FolderHierarchy.Models
{
    public class FolderDbInitializer : DropCreateDatabaseAlways<FolderContext>
    {
        protected override void Seed(FolderContext context)
        {
            Folder mainLevelFolder = new Folder { FolderName = "Creating Digital Images" };

            Folder secondLevelResourcesFolder = new Folder { FolderName = "Resources", Parent = mainLevelFolder };
            Folder secondLevelEvidenceFolder = new Folder { FolderName = "Evidence", Parent = mainLevelFolder };
            Folder secondLevelGraphicFolder = new Folder { FolderName = "Graphic Products", Parent = mainLevelFolder };

            Folder thirdLevelPrimaryFolder = new Folder { FolderName = "Primary Sources", Parent = secondLevelResourcesFolder };
            Folder thirdLevelSecondaryFolder = new Folder { FolderName = "Secondary Sources", Parent = secondLevelResourcesFolder };
            Folder thirdLevelProcessFolder = new Folder { FolderName = "Process", Parent = secondLevelGraphicFolder };
            Folder thirdLevelFinalFolder = new Folder { FolderName = "Final Product", Parent = secondLevelGraphicFolder };

            context.Folders.AddRange(new List<Folder>() {
                mainLevelFolder,
                secondLevelResourcesFolder,
                secondLevelEvidenceFolder,
                secondLevelGraphicFolder,
                thirdLevelPrimaryFolder,
                thirdLevelSecondaryFolder,
                thirdLevelProcessFolder,
                thirdLevelFinalFolder
            });

            base.Seed(context);
        }
    }
}