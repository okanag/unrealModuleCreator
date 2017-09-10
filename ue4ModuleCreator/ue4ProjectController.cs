using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ue4ModuleCreator
{
    class Ue4ProjectController
    {
        private string ue4ProjectPath;

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
                    ue4ProjectPath = file;
                    return true;
                }
            }

            ue4ProjectPath = "";
            return false;
        }

        public bool IsProjectPathValid()
        {
            return !ue4ProjectPath.Equals("");
        }
    }
}
