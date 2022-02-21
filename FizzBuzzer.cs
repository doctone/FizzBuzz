using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        static bool isDivisibleBy(int a, int b){
            return a % b == 0;
        }
        public string FizzBuzz(int number)
        {
            string output = "";

            if (isDivisibleBy(number, 3)){
                output += "Fizz";
            }
            if (isDivisibleBy(number, 5)){
                output += "Buzz";
            }
            if (isDivisibleBy(number, 7)){
                output += "Bang";
            }
            if (isDivisibleBy(number, 11)){
                output = "Bong";
            }
            if (output == ""){
                output += number.ToString();
            }
            return output;
        }
    }
}