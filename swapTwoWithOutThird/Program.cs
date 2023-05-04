namespace swapTwoWithOutThird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} , {b}");

            #region sol1

            /*        a = a + b;
                    b = a - b;
                    a = a - b;
                    Console.WriteLine($"{a} , {b}");
            */

            #endregion

            #region sol2

            /*   a = a * b;
               b = a / b;
               a = a / b;
               Console.WriteLine($"{a} , {b}");*/


            #endregion

            #region sol3

            /*    a = a ^ b;
                b = b ^ a;

                Console.WriteLine($"{a} , {b}");
                a = a ^ b;
                Console.WriteLine($"{a} , {b}");*/
            #endregion

            #region sol4

            /*        Console.WriteLine($"{x(a, b)} , {y(a, b)}");
                    int x(int a, int b)
                    {
                       a = b;

                        return a;
                    }
                    int y(int a, int b)
                    {
                        b = a;

                        return b;
                    }*/

            #endregion

            #region sol5

            Console.WriteLine($"{x(ref a,ref b)} , {y(ref a, ref b)}");
            int x(ref int a, ref int b)
            {
                a = b;

                return a;
            }
            int y(ref int a,ref int b)
            {
                b = a;

                return b;
            }

            #endregion
        }
    }
}