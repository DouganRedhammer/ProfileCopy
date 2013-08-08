using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileCopy
{
    static class Workstation
    {
        /*
         *  try and parse the username for the item and the complete path for the value
         */
        public static List<string> listUsersWindows7(string workstation)
        {
            List<string> users = new List<string>();
            
            try 
            {
            
                string[] dirs = Directory.GetDirectories(@"\\" + workstation + @"\c$\Users");
 
                foreach (string dir in dirs) 
                {
                    users.Add(dir);
                }
            } 
            catch (Exception e) 
            {
                 Console.WriteLine("The process failed: {0}", e.ToString());
            }
                return users;
        }

        /*
         *  try and parse the username for the item and the complete path for the value
         */
        public static List<string> listUsersWindowsXp(string workstation)
        {
            List<string> users = new List<string>();

            try
            {

                string[] dirs = Directory.GetDirectories(@"\\" + workstation + @"\c$\Documents and Settings");

                foreach (string dir in dirs)
                {
                    users.Add(dir);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            return users;
        }

        /*
        public static void Copy(string from, string to, bool overwrite)
        {

            DirectoryInfo dir = new DirectoryInfo(from);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + from);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(to))
            {
                Directory.CreateDirectory(to);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(to, file.Name);
                try
                {
                    file.CopyTo(temppath, overwrite);
                }
                catch (System.IO.IOException e)
                {
                    continue;
                }
            }


            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(to, subdir.Name);
                Copy(subdir.FullName, temppath, overwrite);
            }


        }
        */
    }
}
