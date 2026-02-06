using System;
class Program16
{
    static void Main(string[] args)
    {
        int a=1;
        go:
        if (a <= 100)
        {
            Console.WriteLine(a+" ");
            a++;
            goto go;
        }
    }

}