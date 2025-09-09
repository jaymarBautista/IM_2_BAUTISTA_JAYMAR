using System;
using System.Collections.Generic;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            List<List<double>> table = new List<List<double>>();
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter Column: ");
            int col = int.Parse(Console.ReadLine());

            double count = 0;
            double sum = 0;
            for(int i = 0; i < row; i++)
            {
                Console.WriteLine($"Row {i + 1}");

                List<double> rows = new List<double>();

                for(int x = 0; x < col; x++)
                {
                    Console.Write($"Enter number {x + 1}: ");
                    double value = double.Parse(Console.ReadLine());
                    rows.Add(value);

                    sum += value;
                    count++;

                }
                table.Add(rows);
            }

            Console.WriteLine("\nThe numbers are: ");
            for(int i = 0; i < table.Count; i++)
            {
                for(int x = 0; x < table[i].Count; x++)
                {
                    Console.Write($"{table[i][x]}" + " ");
                }
                Console.WriteLine();
            }
            double ave = sum / count;
            Console.WriteLine($"Sum : {sum}" + ";" + $"Average : {ave}");

            Console.ReadKey();

        }

    }
}
