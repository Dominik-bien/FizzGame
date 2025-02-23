using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                var fizzbuzz = new FizzBuzz();
                string result = fizzbuzz.PlayFizzBuzz(number);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
