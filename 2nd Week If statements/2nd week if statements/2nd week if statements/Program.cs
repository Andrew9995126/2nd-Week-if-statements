using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_week_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            { Console.WriteLine("These numbers are equal");
            }

            if (num1 > num2)
            { Console.WriteLine($"The number {num1} is greater than {num2}");
            }

            if (num1<num2)
            { Console.WriteLine($"The number {num1} is less than {num2}");
            }

            Console.ReadLine();
             

            
        }
    }
}
