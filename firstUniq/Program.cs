namespace firstUniq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sonuç vermiyor
            var dict = new Dictionary<char, int>();
           
        
            List<string > dict1 = new List<string >();
            int n = 0;
            string str;
            str = Console.ReadLine();
            int z = 0;
            #region sol1


            

            foreach (var c in str)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict.Add(c,1);
            }

         /*   foreach (var c in str)
            {
                if (!(dict[c] == 1))
                {
                    z++;
                    str.
                   *//* Console.WriteLine(str.IndexOf(c));*//*
                }
                    

            }
*/
            Console.WriteLine($"{z}kadar tekrar etti");

         /*   var nondupli = dict1.GroupBy(i => i).Where(g => g.Count() < 1).Select(g => g.Key);

            foreach (var nn in nondupli)
            {
                Console.WriteLine(nn);
            }*/



            /*    foreach (var c in str)
                {
                    if (dict1[c] == 1)
                    {
                        n = str.IndexOf(c);
                    }
                }
    
                Console.WriteLine("n adet var" + n);*/

            #endregion

            #region sol2



            #endregion
        }
    }

 
}