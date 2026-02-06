using System;
class Program19
{
    static void Main(string[] args)
    {
        int[,] arry={{20,30,40},{50,60,70}};
        foreach(int a in arry)
        {
        Console.WriteLine(a);
        }
        for(int i=0;i<arry.GetLength(0);i++)
        {
        for(int j=0;j<arry.GetLength(1);j++)
            {
                Console.Write(arry[i,j]+"  ");
            } 
            Console.WriteLine();           
        }
    }
}