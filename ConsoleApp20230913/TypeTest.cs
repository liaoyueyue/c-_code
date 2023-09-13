using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20230913
{
    internal class TypeTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of double: {0}", sizeof(double));
            Console.WriteLine("Size of float: {0}", sizeof(float));
            Console.WriteLine("Size of decimal: {0}", sizeof(decimal));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("Size of bool: {0}", sizeof(bool));
            Console.ReadLine();
        }
    }
}
