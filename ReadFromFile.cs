using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace InputOutpt
{
    internal class ReadFromFile
    {

        public string readFromFile(string filePath)
        {
            // read the contect
            string content = File.ReadAllText(filePath);

            // create  instance of Encrypt 
            Encrypt encrypt = new Encrypt();

            // decrypt the content
            string decryptMessage = encrypt.decrypt(content);

            // display the decrypted message
            Console.WriteLine(decryptMessage);
            
            return decryptMessage;
        }
    }
}
