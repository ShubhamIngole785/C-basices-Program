using System;
class Program18
{
    public static void Main(String[] args)
    {
       int[,] arry={{1,2,3},{4,5,6}};
       foreach(int a in arry)
        {
            
            Console.WriteLine(a);
        }
        // Console.Write(arry[0,0]);
        // Console.Write(arry[0,1]);
        // Console.WriteLine(arry[0,2]);
        // Console.Write(arry[1,0]);
        // Console.Write(arry[1,1]);
        // Console.Write(arry[1,2]);
        int i,j;

        Console.WriteLine("\n your 2D array is:\n");
        for(i=0;i<arry.GetLength(0);i++)
        {
            for(j=0;j<arry.GetLength(1);j++)
            {
                Console.Write(arry[i,j]+"  ");
            }
            Console.WriteLine();
        }

    }
}