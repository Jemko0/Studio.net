using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace StudioDotNet
{
    public class UIColors
    {
        static Dictionary<string, Color> uiColors = new Dictionary<string, Color>();
        static string uiColorFilePath = Directory.GetCurrentDirectory() + "/ui/";

        public static void DefaultColors() 
        {
            uiColors.Add("backgrounds", Color.Gray);
            uiColors.Add("tl_lines", Color.Black);
            uiColors.Add("pt_background", Color.Green);
        }

        public static void RefreshUIColors()
        {
            string fp = uiColorFilePath + "colors.txt";
            System.Diagnostics.Debug.WriteLine("checking init ui color file path: " + uiColorFilePath);
            if(File.Exists(fp))
            {
                StreamReader r = File.OpenText(fp);
                string uiColorFileContent = r.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(uiColorFileContent);
            }
            else
            {
                File.WriteAllText(fp, "COLORS ? idk");
            }
        }

        public static Color GetColorByKey(string k)
        {
            return uiColors[k];
        }

        public static bool SetUIColor(string k, Color c)
        {
            uiColors[k] = c;
            return true;
        }
    }
}
