using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_FileStream
{
    public class Demo3
    {
        public static void CheckFileClass()
        {
            Console.WriteLine("\n***DEMO FILE CLASS IS EXIST***\n");

            string path = @"MyData.txt";
            if (!File.Exists(path))
            {
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
