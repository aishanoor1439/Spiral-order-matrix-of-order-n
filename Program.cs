using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_order_matrix_of_order_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a positive integer N (N < 20): ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Validation
            if (num < 1 || num >= 20)
            {
                Console.WriteLine("num should be a positive integer less than 20.");
                return;
            }

            // Output
            for (int i = 0; i < num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write(i + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
