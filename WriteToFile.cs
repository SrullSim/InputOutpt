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

        Encrypt encrypter = new Encrypt();
        public void writeToFile(string content)
        {
            // Get the path to the desktop

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // create path for folder 
            string filePath = Path.Combine(desktopPath, "message");

            // encrypt the message
            string encContent = encrypter.decrypt(content);

            // Write the content to the file
            File.AppendAllText(filePath, encContent);
            File.AppendAllText(filePath, "\n");

        }
    }
}
