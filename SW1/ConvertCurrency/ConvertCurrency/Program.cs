using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCurrency
{
   
    class Program
    {
        static (double peso, double yen) ConvertCurrency(double dollar)
        {
            double peso = dollar * 57.17;  
            double yen = dollar * 146.67;     
            return (peso, yen); 
        }
        static void Main(string[] args)
        {
            Console.Write("Enter currency in ($): ");
            double dollar = double.Parse(Console.ReadLine());
            
            var result = ConvertCurrency(dollar);

          
            Console.WriteLine(" Dollar($)  Phil Peso(P)  Jpn Yen(Y)");
            Console.WriteLine($"    {dollar}        {result.peso}        {result.yen}");
            Console.ReadKey();
        }
        
    }
}
