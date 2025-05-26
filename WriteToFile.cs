using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace InputOutpt
{
    internal class WriteToFile
    {
        public void writeToFile(string content)
        {
            // Get the path to the desktop

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = Path.Combine(desktopPath, "message");

            // Write the content to the file

            File.WriteAllText(filePath, content);
            File.AppendAllText(filePath, "\n");


        }
    }
}
