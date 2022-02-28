using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_Demo
{
    namespace Indexer
    {
        class IndexedName
        {
            private string[] namelist = new string[size];
            static public int size = 10;
            public IndexedName()
            {
                for (int i = 0; i < size; i++)
                {
                    namelist[i] = "N.A";
                }
            }
            public string this[int index]
            {
                get
                {
                    string temp;
                    if (index >= 0 && index < size)
                    {
                        temp = namelist[index];
                    }
                    else
                    {
                        temp = "";
                    }
                    return temp;
                }
                set
                {
                    if (index >= 0 && index < size)
                    {
                        namelist[index] = value;
                    }
                }
            }
            public int this[string name]
            {
                get
                {
                    int index = 0;
                    while (index < size)
                    {
                        if (namelist[index] == name)
                        {
                            return index;
                        }
                        index++;
                    }
                    return -1;
                }
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                IndexedName name = new IndexedName();
                name[0] = "sam";
                name[1] = "ram";
                name[2] = "Sita";
                name[3] = "oli";
                name[4] = "anshu";
                name[5] = "rima";
                name[6] = "saikat";
                for (int i = 0; i < IndexedName.size; i++)
                {
                    Console.WriteLine(name[i]);
                }
                Console.WriteLine(name["oli"]);
                Console.ReadLine();
            }
        }
    }

}
