namespace ransomRandomNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            List<char> note1 = new List<char>();
            List<char> note2 = new List<char>();
            Dictionary<char,int> dict = new Dictionary<char,int>();
            for (int i = 0; i < r.Next(500); i++)
            {
                    note1.Add(chars[r.Next(chars.Length)]);
                  
            }

            for (int i = 0;i<r.Next(500);i++)
            {
                note2.Add(chars[r.Next(chars.Length)]);
            }
        



            foreach (var c in note1)
            {
                Console.Write(c);

            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            foreach (var c in note2)
            {
                Console.Write(c);

            }

            /*foreach (var c in note2)
            {
                dict[c]++;
            }

            foreach (var c in dict)
            {
                Console.WriteLine(c);
            }*/

            Console.ReadLine();

        }
    }
}