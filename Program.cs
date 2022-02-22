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
                new ReplaceWith(11, "Bong"),
                new Fezz(13, "Fezz"),
                new Reverse(17),
            };

            var fizzbuzzer = new FizzBuzzer(rules);

            for (int i=1; i<=256; i++){
               Console.WriteLine(fizzbuzzer.FizzBuzz(i));
            }
        }
    }
}