using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_FileStream
{
    public class Demo6
    {
        public static void DemoDirectoryInfoClass()
        {
            Console.WriteLine("\n***DEMO DIRECTORYINFO CLASS***\n");

            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\UNIVERSITY\Sem5\PRN212\CODE\DEMO_FileStream\DEMO_FileStream");
            Console.WriteLine("Search pattern demo* returns: ");
            foreach (var file in directoryInfo.GetFiles("demo*"))
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Search pattern TopDirectoryOnly returns: ");
            foreach (var file in directoryInfo.GetFiles("*.cs", SearchOption.TopDirectoryOnly))
            {
                Console.WriteLine(file.Name);
            }
            Console.ReadLine();
        }
    }
}
