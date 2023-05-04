using System.Text;

namespace _15_CountAndSay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            countsay(10);

            Console.ReadLine();

        }


        static string  countsay(int x)
        {
            var result = "1";
            while (x > 1)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    var counter = 1;
                    while (i + 1 < result.Length && result[i] == result[i + 1])
                    {
                        counter++;
                    }

                    sb.Append(counter).Append(result[i]);
                }
                result = sb.ToString();
                x--;
            }

            return result;
        }














    }

 
}