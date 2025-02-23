using System;

    public class FizzBuzz
    {

    //create method PlayFizzBuzz
        public string PlayFizzBuzz(int number) 
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
            //Convert int number to String 
                return number.ToString();
            }
        }
    }
