using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        static bool IsDivisibleBy(int a, int b){
            return a % b == 0;
        }
        public string FizzBuzz(int number)
        {
            string output = "";

            if (IsDivisibleBy(number, 3)){
                output += "Fizz";
            }
            if (IsDivisibleBy(number, 5)){
                output += "Buzz";
            }
            if (IsDivisibleBy(number, 7)){
                output += "Bang";
            }
            if (IsDivisibleBy(number, 11)){
                output = "Bong";
            }
            if (output == ""){
                output += number.ToString();
            }
            return output;
        }
    }
}