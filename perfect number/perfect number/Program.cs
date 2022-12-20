using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("pls enter the frist Number");
            int n1 = int.Parse(Console.ReadLine());


            Console.WriteLine("pls enter the second Number");
            int n2 = int.Parse(Console.ReadLine());


            int start = n1;
            int end = n2;
            int i = 1;
            int total = 0;
            int sum = 0;

            Console.Write("Perfect numbers between {0} and {1}:\n", start, end);
            for (start = start; start <= end; start++)
            {
                for (i = 1; i < start; i++)
                {
                    if (start % i == 0)
                        total += i;
                }
                if ((total == start) && (start != 0))
                {
                    sum = 1;
                    Console.Write(start + " ");
                }
                total = 0;
            }
            if (sum == 0)
                Console.Write("There in no perfect number between the given range");

        }
    }
}
