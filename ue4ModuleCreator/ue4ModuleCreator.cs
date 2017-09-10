using System;
using System.IO;
using Newtonsoft.Json.Linq;
using ue4ModuleCreator.Properties;

namespace ue4ModuleCreator
{
    class Ue4ModuleCreator
    {
        private string parentPath;
        private string parentName;
        private string moduleName;
        private bool isPluginModule;
        private string parentSourceFolderPath;
        private string moduleFolderPath;

        public Ue4ModuleCreator(string parentPath, string moduleName, bool isPluginModule)
        {
            this.parentPath = parentPath;
            parentName = Path.GetFileName(parentPath);
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
            CreateModuleFolderStructure();
            CreateBuildCs();
            CreateModuleHeader();
            CreateMdouleSource();
            RegisterToParent();
            //ToDo: Generate VS Project Files
            //ToDo: Create Success Popup
            //ToDo: Close
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
            string uPluginPath = Path.Combine(parentPath, parentName + ".uplugin");
            string uPluginContent = File.ReadAllText(uPluginPath);
            dynamic uPluginJson = JObject.Parse(uPluginContent);

            JArray modulesArray = uPluginJson.Modules;
            string moduleJsonObject = ReplacePlaceholdersWithModuleData(Resources.moduleCreator_pluginJson);
            modulesArray.Add(JObject.Parse(moduleJsonObject));
            uPluginJson.Modules = modulesArray;

            // ReSharper disable once UseObjectOrCollectionInitializer
            FileInfo fileInfo = new FileInfo(uPluginPath);
            fileInfo.IsReadOnly = false;

            File.WriteAllText(uPluginPath, uPluginJson.ToString());
        }

        private void RegisterToMainModule()
        {
            string mainModulePath = Path.Combine(parentSourceFolderPath, parentName, parentName + ".Build.cs");
            string mainModuleBuildCsContent = File.ReadAllText(mainModulePath);

            string functionToAddModuleName = "PublicDependencyModuleNames";

            int publicDependencyStartIndex = mainModuleBuildCsContent.IndexOf(functionToAddModuleName, StringComparison.Ordinal);
            int moduleNameInsertIndex = mainModuleBuildCsContent.IndexOf("});", publicDependencyStartIndex, StringComparison.Ordinal);

            //Might destroy the formating of Build CS
            //Don't have a better idea :(
            string moduleNameString = ",\"" + moduleName + "\"";

            mainModuleBuildCsContent = mainModuleBuildCsContent.Insert(moduleNameInsertIndex, moduleNameString);

            // ReSharper disable once UseObjectOrCollectionInitializer
            FileInfo fileInfo = new FileInfo(mainModulePath);
            fileInfo.IsReadOnly = false;

            File.WriteAllText(mainModulePath, mainModuleBuildCsContent);
        }
    }
}
