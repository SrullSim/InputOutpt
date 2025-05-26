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
            string content = File.ReadAllText(filePath);

            Console.WriteLine(content);
            return content;
        }
    }
}
