using System;
using Microsoft.VisualBasic;
class Program
{

    public static void Main(string[] args)
    {
        int cho;
        Console.WriteLine("Enter your choice");
        cho=Convert.ToInt32(Console.ReadLine());
        switch (cho)
        {
            case 1:Console.WriteLine("Shubham");break;
            case 2:Console.WriteLine("pavan");break;
            default:Console.WriteLine("Invilade user id");break;
        }
    }
}