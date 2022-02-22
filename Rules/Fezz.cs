namespace FizzBuzz.Rules
{
    public class Fezz: IRule
    {
        public int Divisor { get; set; }
        
        public string ToAdd { get; set; }
        public Fezz(int divisor, string toAdd)
        {
            Divisor = divisor;
            ToAdd = toAdd;

        }

        public List<string> Apply(List<string> previous, int number)
        {
            if (number % Divisor != 0)
            {
                return previous;
            }

            if (previous.Count == 0)
            {
                var output = new List<string>(previous);
                output.Add(ToAdd);
                return output;
            }
            else
            {
                string str = string.Join("", previous).Replace("B", String.Concat(ToAdd, "B"));
                var output = new List<string>();
                output.Add(str);
                return output;
            }
            
        }
    }
}