using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_FileStream
{
    public class Demo2
    {
        public static void DemoFileStreamClass()
        {
            Console.WriteLine("\n***DEMO FILESTREAM CLASS***\n");

            using FileStream fStream = File.Open("demo.dat", FileMode.Create);
            string msg = "ABCDEFGHabcdefgh";
            byte[] msgByte = Encoding.Default.GetBytes(msg);
            fStream.Write(msgByte, 0, msgByte.Length);

            fStream.Position = 0;
            Console.Write("Data read from file: ");
            byte[] readByte = new byte[msgByte.Length];

            for (int i = 0; i < msgByte.Length; i++)
            {
                readByte[i] = (byte)fStream.ReadByte();
                Console.Write($"{readByte[i],5}");
            }

            Console.WriteLine("\nDecoded Message: ");
            Console.WriteLine(Encoding.Default.GetString(readByte));
        }
    }
}
