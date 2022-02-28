﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regularexpression_demo
{
    class Program 
    { 
        static void Main(string[] args) 
        { 
            string input = "Hello World ";
            string pattern = "\\s+"; 
            string replacement = " "; 
            Regex rgx = new Regex(pattern); 
            string result = rgx.Replace(input, replacement);
            Console.WriteLine("Original String: {0}", input); 
            Console.WriteLine("Replacement String: {0}", result); 
            Console.ReadKey(); 
        }
    }

}
