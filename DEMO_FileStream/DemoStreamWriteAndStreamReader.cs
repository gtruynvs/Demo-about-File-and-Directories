using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_FileStream
{
    public class Demo7
    {
        public static void DemoStreamWriterReader()
        {
            string input = null;
            string fileName = @"MyData.txt";
            Console.WriteLine("***Demo StreamWriter and StreamReader***");
            using StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine("Hello");
            sw.WriteLine("World");
            sw.WriteLine("!");
            for (int i = 0; i <= 10; i++)
            {
                sw.Write(i + " ");
            }
            sw.Write(sw.NewLine);
            sw.Close();
            Console.WriteLine("File was created.");
            Console.WriteLine("\nRead file: ");
            using StreamReader sr = new StreamReader(fileName);
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
