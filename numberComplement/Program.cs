using System.Linq;

namespace numberComplement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(a);*/
            dynamic o = '1', z = '0',bigger =1;
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(comp(val));


            #region solve1
         /*   string binary = Convert.ToString(val, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                binary.Contains()
                Console.Write(binary[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine(binary);*/


            #endregion

            #region solve2

            int comp(int val)
            {
                while (bigger < val)
                {
                    bigger <<= 1;
                    bigger += 1;
                }
                return bigger - val;

            }

            #endregion
        }
    }
}