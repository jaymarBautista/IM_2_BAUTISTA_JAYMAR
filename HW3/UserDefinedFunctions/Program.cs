using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Dictionary<char, int> freq = GetCharFrequency(input);

            Console.WriteLine("\nCharacter Frequency:");
            foreach (KeyValuePair<char, int> kvp in freq)
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }
        }
        static Dictionary<char, int> GetCharFrequency(string input)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c)) // only count letters
                {
                    if (frequency.ContainsKey(c))
                    {
                        frequency[c]++;
                    }
                    else
                    {
                        frequency[c] = 1;
                    }
                }
            }

            return frequency;
        }

       
    }
}
