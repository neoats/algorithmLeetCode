  namespace firstBadVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();
            List<int> x = new List<int>();
            int low = 0;
            int high = 0;
            int mid = x.Count-1;
            int a = r1.Next(50, 100);
            int b = r1.Next(0, 50);
            int c = r1.Next(0, 100);


            Console.WriteLine($"a={a}\nb={b}\nc={c}\n");
            if (a > b)
            {
               
                for (int i = b; i <= a; i++)
                {
                    x.Add(i);

                    while (a >= b)
                    {
                        mid = (x.Min() + x.Max()) / 2;
                        if (mid == c)
                        {
                            return;
                        }
                        else if (mid < c)
                        {
                            low = mid + 1;
                        }
                        else
                        {
                            high = mid - 1;
                        }


                        Console.WriteLine($"{high}\n{low}");
                        return;


                    }
                }
                x.Sort();
           
                Console.WriteLine($"{x.Min()}\n{x.Max()}\n\n");
              
              




                /*x.ForEach(i1 => Console.WriteLine(i1));*/


            }
           /* else if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    x.Add(i);
                 

                   
                }
                x.Sort();
                foreach (var i1 in x)
                {
                    Console.WriteLine(i1);
                }

            }*/

            Console.ReadLine();
        }
    }
}