namespace majorityLement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var dict = new Dictionary<int, int>();
            var numbers = new List<int>();


            for (var i = 0; i < r.Next(10, 100); i++)
                numbers.Add(r.Next(9));

            var halfSize = numbers.Count / 2;


            foreach (var number in numbers) Console.Write($"[{number}] ");

            var z = 0;
            Console.WriteLine("\n");
            foreach (var number in numbers)
                if (dict.ContainsKey(number))
                    dict[number]++;
                else
                    dict.Add(number, 1);


            foreach (var number in dict.Keys)
                if (halfSize < number)
                    Console.Write($"[{dict[number]}] ");
                else
                    break;
        }
      
    }
   
}