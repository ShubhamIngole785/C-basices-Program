using System;
class Ffactorial
{
   static void factorial()
    {
        int fac=1;
        for(int i = 1; i <= 5; i++)
        {
            fac=fac*i;
        }
        Console.WriteLine(fac);
    }
    static void Main(string[] args)
    {
        factorial();
    }
}