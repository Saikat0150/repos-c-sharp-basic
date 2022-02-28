using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary_write_Read
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();

            Console.Read();
        }
        static void WriteBinaryFile()
        {
            using(BinaryWriter writer=new BinaryWriter(File.Open("D:\\c.dat", FileMode.Create)))
            {
                writer.Write(12.5);
                writer.Write("This is String Data");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using(BinaryReader reader=new BinaryReader(File.Open("D:\\c.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value: " + reader.ReadDouble());
                Console.WriteLine("String Value: " + reader.ReadString());
                Console.WriteLine("Boolean Value: " + reader.ReadBoolean());
            }
        }
    }
}
