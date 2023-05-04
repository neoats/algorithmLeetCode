using System;
using System.Collections;

namespace _11_plusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {   int r1 = 0;
            Random r = new Random();
            List<int> myarray = new List<int>();
            for (int i = 0; i < r.Next(2, 10); i++)
            {
                    myarray.Add(r.Next(0,9));
                if (myarray.First() == 0)
                    myarray.Insert(0, r.Next(1, 9));
            }


            myarray.ForEach(p => Console.Write($"[{p}] "));
            Console.WriteLine(" ");
         /*   var za = plusone(myarray);
            za.ForEach(p => Console.Write($"[{p}] "));*/
            /*Console.WriteLine(plusone(myarray));*/





        }

        #region sol1
        //converts array to string first and then to number
        //needs to convert to array
        /*    static List<int> plusone(List<int> array)

            {
                List<int> myarray = new List<int>();
                string a = null;

                int output;
                foreach (var item in array)
                {
                    a += item.ToString();
                }
                output = int.Parse(a)+1;
                a = output.ToString();
                for (int i = a.Length; i >= 0; i--)
                {
                    myarray.Add(a[i]);
                }

                return myarray;
            }*/


        #endregion
        #region sol2
        static public int pOne(List<int> array)
        {
            var length = array.Count;
            for (int i = length -1; i >= 0; i--)
            {
                if (array[i]<9)
                {
                    array[i]++;
                }
                array[i] = 0;
            }
            var exparray= new List<int>[length+1];
            exparray[0].Add(1);
            return exparray;
        }



        #endregion

    }
}