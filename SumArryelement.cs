using System;
using System.Diagnostics.Contracts;
class Program24
{
    public static void Main(string[] args)
    {   
        int []arry = {10,20,30,40,50,60};
        int sum=0;
        for(int i=0;i<arry.Length;i++)
        {
            sum = sum+arry[i];
        }
         Console.WriteLine(sum);
        
    }
}