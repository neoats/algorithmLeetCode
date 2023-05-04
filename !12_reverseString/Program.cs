namespace _12_reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            var x = reverse(chars);
            Console.WriteLine(x);
        }

        static string reverse(char[] str)
        {
            string str1 = String.Empty;
            for (int i = str.Length-1; i >= 0; i--)
            {
                str1 += str[i];
             
            }

            return str1;
        }
    }
}