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


            WriteToFile writer = new WriteToFile();

            ReadFromFile reader = new ReadFromFile();


            // print menu and get user input
            while (run)
            {
                string choice = printMunu();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter your message: \n");
                        string message = Console.ReadLine();

                        writer.writeToFile(message);

                        break;


                    case "2":
                        Console.Clear();
                        Console.WriteLine("enter path");

                        string filepath = Console.ReadLine();
                        while(filepath == null)
                        {
                             filepath = Console.ReadLine();
                        }

                        string readmessage = reader.readFromFile(filepath);
                        filepath = null;
                        Console.WriteLine(readmessage);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        break;

                    case "3":
                        Console.WriteLine("Exiting the program.");
                        run = false;
                        break;

                    default:
                        Console.WriteLine( "Invalid choice. Please try again.");
                        break;

                }
            }
            return "Operation completed successfully.";
        }


        // menu 
        public string printMunu()
        {
            Console.Clear();
            Console.WriteLine("===== Welcome to the Secret Messages – Atbash Cipher Writer! =====");
            Console.WriteLine("1. send a message");
            Console.WriteLine("2. read a message");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: \n");

            string choice = Console.ReadLine();
            if(choice == null)
            {
                Console.WriteLine("Invalid input. Please try again.");
                return printMunu();
            }
            return choice;

        

            }


    }
}
