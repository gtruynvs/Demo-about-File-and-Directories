using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_FileStream
{
    public class Demo4
    {
        public static void DemoFileInfoClass()
        {
            Console.WriteLine("\n***DEMO FILEINFO CLASS***\n");

            string path = @"MyFile.txt";
            File.WriteAllText(path, "Hello World.");
            Console.WriteLine("Read file: ");
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
            Console.WriteLine("***File information***");
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine($"File name: {fileInfo.Name}");
            Console.WriteLine($"File size: {fileInfo.Length}");
            Console.WriteLine($"File creation time: {fileInfo.CreationTime}");
            Console.WriteLine($"File last access time: {fileInfo.LastAccessTime}");
            Console.WriteLine($"Directory Name: {fileInfo.DirectoryName}");
            Console.ReadLine();
        }
    }
}
