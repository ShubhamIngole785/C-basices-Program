using System;
using System.Runtime.Versioning;
class Faary
{
    static int grater_num(int n1,int n2,int n3)
    {
        if(n1>n2 && n1>n3)
        {
           // Console.WriteLine(n1);
            return n1;
        }
        else if (n2>n1 && n2 > n3)
        {
            //Console.WriteLine(n2);
            return n2;
        }
        else{
           // Console.WriteLine(n3);
            return n3;
            
        }

        // int [] arry={10,20,30,40,50};
        // int gre=1;
        // for(int i = 0; i <arry.Length; i++)
        // {
        //     if (gre < arry[i])
        //     {
        //         //Console.WriteLine(gre);
        //         gre=arearry[i];
        //     }

        // }
        //   return gre;
    }
    static void Main(string[] args)
    {
        int out1 = grater_num(10,20,30);

        Console.WriteLine(out1);
    }
}