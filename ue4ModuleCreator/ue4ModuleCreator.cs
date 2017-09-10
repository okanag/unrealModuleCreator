using System;
using System.IO;
using ue4ModuleCreator.Properties;

namespace ue4ModuleCreator
{
    class Ue4ModuleCreator
    {
        private string parentPath;
        private string moduleName;
        private bool isPluginModule;
        private string parentSourceFolderPath;
        private string moduleFolderPath;

        public Ue4ModuleCreator(string parentPath, string moduleName, bool isPluginModule)
        {
            this.parentPath = parentPath;
            this.moduleName = moduleName;
            this.isPluginModule = isPluginModule;
            FindSourceFolder();
        }

        private void FindSourceFolder()
        {
            string sourceFolder = Path.Combine(parentPath, "Source");
            parentSourceFolderPath = Directory.Exists(sourceFolder) ? sourceFolder : "";
        }

        public void CreateModule()
        {
            try
            {
                CreateModuleFolderStructure();
                CreateBuildCs();
                CreateModuleHeader();
                CreateMdouleSource();
                RegisterToParent();
                //ToDo: Create Success Popup
                //ToDo: Close
            }
            catch (Exception e)
            {
                //ToDo: Something went wrong
                Console.WriteLine(e);
                throw;
            }
        }

        private void CreateModuleFolderStructure()
        {
            moduleFolderPath = Path.Combine(parentSourceFolderPath, moduleName);
            if (!Directory.Exists(moduleFolderPath))
            {
                Directory.CreateDirectory(moduleFolderPath);
            }
            string modulePrivateFolderPath = Path.Combine(moduleFolderPath, "Private");
            if (!Directory.Exists(modulePrivateFolderPath))
            {
                Directory.CreateDirectory(modulePrivateFolderPath);
            }
            string modulePublicFolderPath = Path.Combine(moduleFolderPath, "Public");
            if (!Directory.Exists(modulePublicFolderPath))
            {
                Directory.CreateDirectory(modulePublicFolderPath);
            }
        }
        
        private void CreateBuildCs()
        {
            string buildCsPath = Path.Combine(moduleFolderPath, moduleName + ".Build.cs");

            string buildCsContent = ReplacePlaceholdersWithModuleData(Resources.moduleCreator_buildCs);
            File.WriteAllText(buildCsPath, buildCsContent);
        }

        private string ReplacePlaceholdersWithModuleData(string contentString)
        {
            contentString = contentString.Replace("%COPYRIGHT%", Resources.moduleCreator_copyright);
            contentString = contentString.Replace("%MODULENAME%", moduleName);
            return contentString;
        }

        private void CreateModuleHeader()
        {
            string headerPath = Path.Combine(moduleFolderPath, "Public", moduleName + ".h" );
            string headerContent = ReplacePlaceholdersWithModuleData(Resources.moduleCreator_moduleHeader);
            File.WriteAllText(headerPath, headerContent);
        }

        private void CreateMdouleSource()
        {
            string sourcePath = Path.Combine(moduleFolderPath, "Private", moduleName + ".cpp");
            string sourceContent = ReplacePlaceholdersWithModuleData(Resources.moduleCreator_moduleSource);
            File.WriteAllText(sourcePath, sourceContent);
        }

        private void RegisterToParent()
        {
            if (isPluginModule)
            {
                RegisterToPlugin();
            }
            else
            {
                RegisterToMainModule();
            }
        }

        private void RegisterToPlugin()
        {
            
        }

        private void RegisterToMainModule()
        {
            
        }
    }
}
