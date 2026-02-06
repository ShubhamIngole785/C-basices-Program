// if else even odd progrm
using System;
class Program6
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter a number:");
        num=Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    
    }
}
