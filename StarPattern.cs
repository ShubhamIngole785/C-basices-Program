using System;
using System.Runtime.InteropServices.Marshalling;
class Program25
{
    static void Main(string[] args)
    {
        int row=5;
        for(int i = 0; i <= row; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        
    }
    
}