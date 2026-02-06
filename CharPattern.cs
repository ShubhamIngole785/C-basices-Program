using System;
class Program26
{
    static void Main(string[] args)
    {
        
        for(int i = 1; i <=5; i++)
        {
           char cha='D' ;
            for(int j=1;j<=i;j++)
            {
            Console.Write(cha+" ");
            cha++;
            }
            Console.Write("\n");
        }
    }
}