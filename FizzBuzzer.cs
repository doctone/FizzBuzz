using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        static bool StartsWithB(string word){
            return word.StartsWith("B");
        }
        static bool IsDivisibleBy(int a, int b){
            return a % b == 0;
        }
        public string FizzBuzz(int number)
        {
            List<string> output = new List<string>();
            if (IsDivisibleBy(number, 13)){
                output.Add("Fezz");
            }

            if (IsDivisibleBy(number, 3)){
                output.Add("Fizz");
            }
            if (IsDivisibleBy(number, 5)){
                output.Add("Buzz");
            }
            if (IsDivisibleBy(number, 7)){
                output.Add("Bang");
            }
            if (IsDivisibleBy(number, 11)){
                output.Add("Bong");
            }
            if (IsDivisibleBy(number, 17)){
                output.Reverse();
            }


            if (output.Count == 0){
                output.Add(number.ToString());
            }
            return String.Join("", output.ToArray());
        }
    }
}