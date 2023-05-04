namespace jewelStonesRandomString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region firstsol


            int count = 0;
            Random r = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            List<char> t1 = new List<char>();
            List<char> t2 = new List<char>();
            /* HashSet<char> t1 = new HashSet<char>();
            HashSet<char> t2 = new HashSet<char>();*/
            for (int i = 0; i <  50; i++)
            {
                t1.Add(chars[r.Next(chars.Length)]);
            }
            for (int i = 0; i < 50; i++)
            {
                t2.Add(chars[r.Next(chars.Length)]);
            }
            foreach (var t in t1)
            {
                Console.Write(t);
            }

            Console.WriteLine(" \n");
            foreach (var t in t2)
            {
                Console.Write(t);
            }
            Console.WriteLine(" \n");
            foreach (char c in t1)
            {
                foreach (char ch in t2)
                {
                    if (ch == c)
                    {
                        Console.Write(c);
                        count++;
                    }
                }
            }
            Console.WriteLine($"\n{count}");

            #endregion
            #region secsol



            #endregion
        }
    }
}