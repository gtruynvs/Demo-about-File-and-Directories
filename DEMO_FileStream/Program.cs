using System;
using System.IO;
using System.Text;

namespace DEMO_FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Demo FileStream Class");
                Console.WriteLine("2. Demo File Class");
                Console.WriteLine("3. Check if File Class exists");
                Console.WriteLine("4. Demo FileInfo Class");
                Console.WriteLine("5. Demo Directory Class");
                Console.WriteLine("6. Demo DirectoryInfo Class");
                Console.WriteLine("7. Demo StreamWrite and StreamReader Class");
                Console.WriteLine("8. Demo BinaryWrite and BinaryReader Class");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Demo2.DemoFileStreamClass();
                        break;

                    case "2":
                        Demo1.DemoFileClass();
                        break;

                    case "3":
                        Demo3.CheckFileClass();
                        break;

                    case "4":
                        Demo4.DemoFileInfoClass();
                        break;

                    case "5":
                        Demo5.DemoDirectoryClass();
                        break;

                    case "6":
                        Demo6.DemoDirectoryInfoClass();
                        break;

                    case "7":
                        Demo7.DemoStreamWriterReader();
                        break;

                    case "8":
                        Demo8.DemoBinaryWriterReader();
                        break;

                    case "9":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter again.");
                        break;
                }
            }
        }
    }
}
