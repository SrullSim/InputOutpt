using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace InputOutpt
{
    internal class Runall
    {

        bool run = true;
        public string runAll()
        {
            
            // create instances

            Encrypt encrypt = new Encrypt();

            WriteToFile writer = new WriteToFile();

            ReadFromFile reader = new ReadFromFile();

            
            
            while (run)
            {
                string choice = printMunu();

                switch (choice)
                {
                    case "1":

                        Console.WriteLine("Enter your message: \n");
                        string message = Console.ReadLine();

                        string encryptMessage = encrypt.decrypt(message);

                        writer.writeToFile(encryptMessage);

                        break;


                    case "2":
                        Console.WriteLine("enter path");
                        string filepath = Console.ReadLine();

                        string readmessage = reader.readFromFile(filepath);

                        return readmessage;


                    case "3":
                        Console.WriteLine("Exiting the program.");
                        run = false;
                        break;

                    default:
                        return "Invalid choice. Please try again.";


                }
            }
            return "Operation completed successfully.";
        }
        public string printMunu()
        {
            Console.Clear();
            Console.WriteLine("1. send a message");
            Console.WriteLine("2. read a message");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: \n");

            string choice = Console.ReadLine();
            return choice;

        

            }


    }
}
