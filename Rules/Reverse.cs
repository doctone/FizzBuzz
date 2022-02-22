namespace FizzBuzz.Rules
{
    public class Reverse : IRule
    {
        public int Divisor { get; set; }

        public Reverse(int divisor)
        {
            Divisor = divisor;
        }

        public List<string> Apply(List<string> previous, int number)
        {
            if (number % Divisor != 0)
            {
                return previous;
            }
            previous.Reverse();
            return previous;

        }
    }
}