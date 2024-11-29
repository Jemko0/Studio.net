using StudioDotNet.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioDotNet
{
    public class Saving
    {
        public static string projectSaveDir = System.IO.Directory.GetCurrentDirectory() + "/Projects/";
        public static string currentProjectPath = "";
        public static void CreateNew()
        {

        }

        public static void CheckProjectsDir()
        {
            if (!Directory.Exists(projectSaveDir))
            {
                Directory.CreateDirectory(projectSaveDir);
            }
        }

        public static void SaveFile(string path)
        {
            CheckProjectsDir();
            StudioForm s = Program.formManager.GetForm<StudioForm>("studioform");
            string fileContent = "";
            fileContent += StringPropertyParser.MakeProperty("fn", s.mainTracker.projectName);
            fileContent += "\n";
            fileContent += StringPropertyParser.MakeProperty("ts", s.mainTracker.timeSignature.numerator + "/" + s.mainTracker.timeSignature.denominator);
            fileContent += "\n";
            fileContent += StringPropertyParser.MakeProperty("pt", Conv.PatternToString(s.mainTracker.patterns[0]));
            File.WriteAllText(path, fileContent);
        }

        public static void SaveAs()
        {
            CheckProjectsDir();
        }

        public static bool OpenFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader s = new StreamReader(path);
                string fc = s.ReadToEnd();
                s.Close();
                Conv.StringToPattern(StringPropertyParser.GetPropertyFromPropertyList(fc, "pt"));
            }
            return true;
        }
    }
}
