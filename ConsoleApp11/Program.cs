using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows=8, k;
            
            Console.WriteLine("");
            for (i = 1; i <= rows; i++)
            {
                for (j = i; j < rows; j++)
                {
                    Console.WriteLine("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*"); // print the Star  
                }
                Console.WriteLine("");
            }
            for (i = 1; i <= rows; ++i)
            {
                for (j = 2; j <= i; j++)
                {
                    Console.WriteLine("");
                }
                for (k = i; k <= rows; k++)
                {
                    Console.Write("*"); // print the Star  
                }
                Console.WriteLine("");
            }
        }
    }
}
