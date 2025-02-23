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
            //Program to ask user to enter a number
            Console.WriteLine("Enter a number: ");
            //Program check if user enter int number or wrong value
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                //Create object fizzbuzz
                FizzBuzz fizzbuzz = new FizzBuzz();
                //Calling method PlayFizzBuzz from class FizzBuzz
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
