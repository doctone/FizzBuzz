using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            string output = "";

            if (number % 3 == 0){
                output += "Fizz";
            }
            if (number % 5 == 0){
                output += "Buzz";
            }
            if (output == ""){
                output += number.ToString();
            }
            return output;
        }
    }
}