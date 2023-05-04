
namespace _8_validperfectSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r=new Random();
           List<int> array = new List<int>();

            #region middleinciddle
            /*  long left = 1;
              long right = Convert.ToInt32(Console.ReadLine());
              long middle = left + (right - left) / 2;
              Console.WriteLine(middle);*/

            #endregion

            for (int i = 0; i < r.Next(100, 500); i++)
                array.Add(r.Next(0, 10000));
            int z = 0;
            foreach (var item in array)
            {
                Console.Write($"[{item} ]");
                if (sqr(item) == true)
                {
                    z++;
                    Console.WriteLine(" ");
                    Console.WriteLine($"{z}.number{item}");
                }
            }
           

           
         
         
        }
        static bool sqr(int num)
        {
            long left = 1;
            long right = num;
            while (left <= right)
            {
                long middle =left+ (right-left) / 2;
                if (middle*middle==num)
                {
                    return true;
                }

                if (middle * middle < num)
                {
                    left = middle + 1;
                }
                else right = middle - 1;
            }

            return false;
        }
    }
}