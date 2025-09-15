using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_1
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();


            string[] parts = input.Split(' ');


            for (int i = 0; i < parts.Length; i++)
            {
                int number = int.Parse(parts[i]);
                if (IsPrime(number))
                    Console.WriteLine($"{i + 1}.  {number} Prime");
                else
                    Console.WriteLine($"{i + 1}.  {number} Composite");
                

            }
            Console.ReadKey();
        }
    }
}
