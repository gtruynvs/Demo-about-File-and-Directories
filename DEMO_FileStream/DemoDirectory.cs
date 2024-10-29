using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_FileStream
{
    public class Demo5
    {
        public static void DemoDirectoryClass()
        {
            Console.WriteLine("\n***DEMO DIRECTORY CLASS***\n");

            string sourceDirectory = Directory.GetCurrentDirectory();
            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.*");
                foreach (string currentFile in txtFiles)
                {
                    Console.WriteLine(currentFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
