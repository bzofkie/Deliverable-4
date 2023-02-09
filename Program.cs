using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Barbara Zofkie
// Date: 2/8/2023
// Description: Create a program to write Fibonacci numbers

namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int[] fibonacci = new int[x];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for(int i = 0; i < x; i++)
            {
                if(i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}
