using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerDay2
{
    class IndexCre
    {
        public static int size = 6;
        private string[] val = new string[size];
        public IndexCre()
        {
            for(int i = 0; i < size; i++)
            {
                val[i] = "No value";
            }
        }
        public string this[int index]
        {
            get
            {
                return val[index];
            }
            set
            {
                val[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexCre n = new IndexCre();
            n[0] = "Oli";
            n[1] = "Joli";
            n[2] = "Tuli";
            n[3] = "Fuli";
            n[4] = "Lili";
            for(int i=0;i<IndexCre.size; i++)
            {
                Console.WriteLine("The value of the " + i + "th index is: " + n[i]);
            }
            Console.Read();
        }
    }
}
