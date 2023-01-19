using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 6, i, j, m = 1; 
            Console.WriteLine(" Enter the number to define the columns: \n");

            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            for (i = num - 1; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

        }
    }
}
   
