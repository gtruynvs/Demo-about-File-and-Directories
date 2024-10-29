using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_FileStream
{
    public class Demo8
    {
        public static void DemoBinaryWriterReader()
        {
            string fileName = "MyFile.bin";
            Console.WriteLine("***Demo BinaryWriter and BinaryReader***");
            FileInfo fileInfo = new FileInfo(fileName);
            using BinaryWriter bw = new BinaryWriter(fileInfo.OpenWrite());
            Console.WriteLine("Base stream is: {0}", bw.BaseStream);
            double aDouble = 1234.67;
            int anInt = 34567;
            string aString = "A, B, C";
            bw.Write(aDouble);
            bw.Write(anInt);
            bw.Write(aString);
            bw.Close();
            Console.WriteLine("File was created.");
            Console.WriteLine("\nRead file: ");
            using BinaryReader br = new BinaryReader(fileInfo.OpenRead());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.ReadLine();
        }
    }
}
