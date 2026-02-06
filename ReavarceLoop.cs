using System;
class Program22
{
    public static void Main(String[] args)
    {
        string a="shubham";
        Console.WriteLine(a);
        for(int i = a.Length-1; i>=0;i--)
        {
            Console.WriteLine(a[i]);
        }
    }
}