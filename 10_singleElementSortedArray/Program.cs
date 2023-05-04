namespace _10_singleElementSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Random r  = new Random();
         List<int> numbers = new List<int>();
         Dictionary<int,int> dict = new Dictionary<int,int>();
         for (int i = 0; i < r.Next(40,200); i++)
         {
             numbers.Add(r.Next(0,100));
         }
         numbers.ForEach(p=>Console.Write($"{p} "));
         foreach (var number in numbers)
         {
             if (dict.ContainsKey(number))
                 dict[number]++;
             else
                 dict.Add(number,1);
         } 
         Console.WriteLine("\n\n");

         foreach (var item in dict)
         {
             Console.Write($"{item} ");
         }
        }
    }
}