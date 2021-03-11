using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;

namespace regedit_cleaner
{
    class yeap
    {
        public static bool Clean_Regedit()
        {

            // get regedit address as a key and then delete everything on it. you can add more paths for regedit
            // if you want, i will only put for userassistview here.
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MICROSOFT\\WINDOWS\\CURRENTVERSION\\" +
                "Explorer\\USERASSIST", true))
            {
                // for each string(subkeys) in the path located it will open these and for each one it will delete it.
                // this code can be way more optimizated.
                foreach(string c in key.GetSubKeyNames())
                {
                    try
                    {
                        RegistryKey productK = key.OpenSubKey(c);
                        productK.DeleteSubKeyTree(c);
                        return true;
                    }catch(Exception e)
                    {
                        Console.Write(e.Message);
                        return false;
                    }
                    
                }
            }

            return false;
        }
    }
}
