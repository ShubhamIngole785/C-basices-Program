using System;
class Sum5
{
    static int sum_of_five()
    {
        int sum=0;
        for(int i = 1; i <= 5; i++)
        {
            sum = sum+i;
            
        }
         //Console.WriteLine(sum);
         
         return sum;
        
    }
    static void Main(string[] args)
    {
       int ans= sum_of_five();
       Console.WriteLine(ans);
    }
}