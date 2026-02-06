// print gratest value using if else 
using System;
using System.Threading.Tasks.Dataflow;
class Program
{
    static void Main(string[] args)
    {
        int a = 50;
        int b = 20;
        int c = 30;
        //    if (a > b)
        //     {
        //         Console.WriteLine("Greater value:"+a);
        //     }
        //    else if(b > c)
        //     {
        //         Console.WriteLine("Greater value"+b);
        //     }
        //     else
        //     {
        //             Console.WriteLine("Greater value"+c);
        //     }
        // if (a > b && a > c)
        // {
        //     Console.WriteLine("Greater value:"+a);

        // }
        // else if(a < b && a < c)
        // {
        //     Console.WriteLine("greater is "+c);
        // }
        // else
        // {
        //     Console.WriteLine("greater is "+b);
        // }

        if (a < b && a < c)
        {
            if (b > c)
            {
                Console.WriteLine("Greter value:" + b);
            }
            else
            {
                Console.WriteLine("Greter value:" + c);
            }
        }
        else
        {
            Console.WriteLine("Greter value :" + a);
        }

    }
}