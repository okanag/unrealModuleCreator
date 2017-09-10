using System.Collections.Generic;
using System.IO;

namespace ue4ModuleCreator
{
    class Ue4ProjectController
    {
        private string ue4ProjectPath;
        private string ue4ProjectName;

        private string projectPluginsFolder;
        private string projectSourceFolder;

        public bool InitializeWithProjectPath(string text)
        {
            if (!Directory.Exists(text))
            {
                ue4ProjectPath = "";
                return false;
            }
          
            string[] files = Directory.GetFiles(text);
            foreach (string file in files)
            {
                if (file.Contains(".uproject"))
                {
                    ue4ProjectPath = text;
                    ue4ProjectName = Path.GetFileNameWithoutExtension(ue4ProjectPath);
                    FindSourceFolder();
                    FindPluginsFolder();
                    return true;
                }
            }

            ue4ProjectPath = "";
            return false;
        }

        private void FindSourceFolder()
        {
            string sourceFolder = Path.Combine(ue4ProjectPath, "Source");
            projectSourceFolder = Directory.Exists(sourceFolder) ? sourceFolder : "";
        }

        private void FindPluginsFolder()
        {
            string pluginsFolder = Path.Combine(ue4ProjectPath, "Plugins");
            projectPluginsFolder = Directory.Exists(pluginsFolder) ? pluginsFolder : "";
        }

        public List<string> GetPossibleModuleLocationList()
        {
            List<string> modueLocations = GetValidatedPluginList();
            modueLocations.Insert(0, ue4ProjectName);
            return modueLocations;
        }

        private List<string> GetValidatedPluginList()
        {
            string[] pluginFolderList = Directory.GetDirectories(projectPluginsFolder);
            List<string> validatedPluginList = new List<string>();

            foreach (string pluginFolder in pluginFolderList)
            {
                string pluginName = Path.GetFileName(pluginFolder);
                string pluginFile = Path.Combine(pluginFolder, pluginName + ".uplugin");
                if (File.Exists(pluginFile))
                {
                    validatedPluginList.Add(pluginName);
                }
            }

            return validatedPluginList;
        }

        public bool IsProjectPathValid()
        {
            return !ue4ProjectPath.Equals("");
        }
    }
}
