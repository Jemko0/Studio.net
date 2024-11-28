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

        public static void SaveFile(string path)
        {
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

        }

        public static bool OpenFile(string path)
        {
            StreamReader s = new StreamReader(path);
            List<string> l = new List<string>();
            while(l != null)
            {
                l.Add(s.ReadLine());
            }
            s.Close();



            foreach (string a in l)
            {
                StringPropertyParser.GetPropertyValueFromPropertyList(a, "fn");
            }

            return true;
        }
    }
}
