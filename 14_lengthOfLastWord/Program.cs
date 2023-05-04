using System.Collections;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace _14_lengthOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            const char sp = ' ';
            int z = 0;
            List<string> note1 = new List<string>();
           
           
            while (note1.Count <30 )
            {
                
                for (int i = 0; i < r.Next(5,10); i++)
                {
                    note1.Add(chars[r.Next(chars.Length)].ToString());
                   


                }
                note1.Add(sp.ToString());



            }

            var x = note1.ToString();



            note1.ForEach(p=>Console.Write(p));
            Console.WriteLine(" ");
            Console.WriteLine(note1.Count);
            Console.WriteLine(lastwordcount(note1).Count);
            Console.WriteLine(" ");
            note1.ForEach(p => Console.Write($"[{p}]"));
            Console.WriteLine(" ");
            Console.WriteLine($"[{note1.Last()}]");
            Console.WriteLine(" ");


            spacefinder(x);

        }

        public static void spacefinder(string str)
        {var z = 0;
            foreach (var c in str)
            {
                if (c==' ')
                {
                    z++;
                  
                } 
            }
            Console.WriteLine($"{z} kadar space var");
        }

        public static List<string> lastwordcount(List<string> str)
        {
            var newlist = new List<string>();

            for (var i = str.Count - 1; i >= 0; i--)
                if (str[i] != " ")
                    newlist.Add(str[i]);


            return newlist;
        } 
    }
}