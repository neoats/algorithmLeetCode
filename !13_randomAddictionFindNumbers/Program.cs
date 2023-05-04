Random r = new Random();
//if the digit range is closer, it gives different results both in addition and find method.
List<int> mylist = new List<int>();
for (int i = 0;i < r.Next(7,15); i++)
    mylist.Add(r.Next(5,20));
//if add numbers scale
int b = r.Next(mylist.Count);
int c = r.Next(mylist.Count);
mylist.ForEach(p => Console.Write($"[{p}] "));
Console.WriteLine("\n");
var d = add();
Console.WriteLine(" ");
/*Console.WriteLine(mylist[b] + "\n" + mylist[c]+ "\n" + (mylist[b] + mylist[c]));*/
Console.WriteLine(d);
Console.WriteLine("\n");
find(d);

/*Console.Write($"[{r.Next(mylist.Count)}] ");*/
int add()
{
    
   int x = mylist[b];
   int y = mylist[c];
   Console.WriteLine($"[{x}] [{y}]");

   return x + y;
}
void find(int d){
    for (int i = 0; i < mylist.Count; i++)
    {
        for (int j = 0; j < mylist.Count; j++)
        {
            if ((mylist[i] + mylist[j]) == d)
            {
                Console.WriteLine($"[{mylist[i]}] [{mylist[j]}]");
                return;
            }

        }
    }

}