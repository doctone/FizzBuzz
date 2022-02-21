using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzzer = new FizzBuzzer();

            for (int i=1; i<=256; i++){
               Console.WriteLine(fizzbuzzer.FizzBuzz(i));
            }
        }
    }
}