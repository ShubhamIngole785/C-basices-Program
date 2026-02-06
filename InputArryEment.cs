// Program for taking five input for user store in arry and print
using System;
class Program1
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        int i;
        for (i=0;i<5;i++)
        {
            int n;
            Console.WriteLine("enter "+i+" th element");
            n=Convert.ToInt32(Console.ReadLine());
            arr[i]=n;
        }
        foreach(int x in arr)
        {
            Console.Write4
            (x+" ");
        }    }
}