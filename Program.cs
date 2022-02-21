using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var rules = new List<IRule>()
            {
                new DivisibleRule(3, "Fizz"),
                new DivisibleRule(5, "Buzz"),
                new DivisibleRule(7, "Bang"),
            };

            var fizzbuzzer = new FizzBuzzer(rules);

            for (int i=1; i<=256; i++){
               Console.WriteLine(fizzbuzzer.FizzBuzz(i));
            }
        }
    }
}