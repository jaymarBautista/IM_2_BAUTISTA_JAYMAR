using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Write("Enter a string: ");
                string word = Console.ReadLine().ToLower();
                string result = "";
                bool isPalindrome = true;


                if (word == "*")
                {
                    break;
                }

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }


                if (result == word)
                {
                    if (isPalindrome)
                    {
                        Console.Write("Original String" + "     ");
                        Console.Write("Reversed String" + "     ");
                        Console.WriteLine("Palindrome?");

                        Console.Write("  " + result + "                  ");
                        Console.Write("  " + word + "             ");
                        Console.WriteLine("  " + "Yes");
                    };

                }
                else
                {
                    Console.Write("Original String" + "     ");
                    Console.Write("Reversed String" + "     ");
                    Console.WriteLine("Palindrome?");

                    Console.Write("  " + result + "                  ");
                    Console.Write("  " + word + "             ");
                    Console.WriteLine("  " + "No");
                }



            }
        }


    }
}