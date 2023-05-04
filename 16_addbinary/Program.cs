namespace _16_addbinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string binary1,binary2;
           int sum = 0;
           binary1 = Console.ReadLine();
           binary2 = Console.ReadLine();
           int a = Convert.ToInt32(binary1,2);
           int b = Convert.ToInt32(binary1, 2);
           sum = a + b;
          
           Console.WriteLine(Convert.ToString(sum,2).PadLeft(8,'0'));

        }
    }
}