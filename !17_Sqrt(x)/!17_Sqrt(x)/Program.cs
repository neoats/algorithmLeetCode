namespace _17_Sqrt_x_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sqrtx(a));
                Console.WriteLine("Hello, World!");
            }
          
        }

        static string sqrtx(decimal x)
        {
            decimal guess = x / 2m;
            decimal lastGuess = 0m;
            while (guess != lastGuess)
            {
                lastGuess = guess;
                guess = (x / guess + guess) / 2m;
            }
            return $"{Convert.ToInt32(guess)}  ({guess})ba";
        }
    }
}