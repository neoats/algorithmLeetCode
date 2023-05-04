namespace checkıfıtısaStraightLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Random r = new Random();
            *//*  List<int> series = new List<int>();*//*
              int[,] series2 = new int[r.Next(20),r.Next(20)];
            *//*  for (int i = 0; i < r.Next(30); i++)
              {
                  series.Add(r.Next(9));
                  series.ForEach(p=>Console.Write($"[{p}] "));
              }*//*

              Console.WriteLine(" ");
               for (int i = 0; i < series2.Length; i++)
               {
                   for (int j = 0; j < r.Next(20); j++)
                   {
                       series2[i,j] = r.Next(1, 10);
                       Console.Write($"[{series2[i,j]}] ");
                   }
               }

               foreach (var serie in series2)
              {
                   Console.WriteLine($"[{serie}] ");
              }*/
            var c = 0;
         
            Random rnd = new Random();
            int[,] serie = new int[rnd.Next(2,10), rnd.Next(2,10)];
            for (int i = 0; i < serie.GetLength(0); i++)
            {
                for (int j = 0; j < serie.GetLength(1); j++)
                {
                  /*  serie[i, j] = rnd.Next(1, 10);*/

                    Console.WriteLine("[{0}, {1}] = {2}", i, j, serie[i, j]);
                    if (i==j)
                    {
                        c++;
                        Console.WriteLine($"[{0}, {1}]", i+c, j+c, serie[i, j]);
                    }
                }
            }
            
            




            Console.WriteLine(" ");
            Console.WriteLine(c);
            Console.WriteLine(" ");
            Console.WriteLine(serie.Length);
            if (serie.GetLength(0) <=2)
            {
                Console.WriteLine(" hello");
                
            }
        }
       
    }
}