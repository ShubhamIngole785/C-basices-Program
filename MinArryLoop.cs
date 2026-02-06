using System;
class Program23
{
    public static void Main(string[] args)
    {

       int [] arr = {-32,-54,-78,-90,-89,-98,-2,-1};
       int min =arr[0];
       
        for(int i=0; i < arr.Length; i++)
        {
            if (arr[i]< min)
            {
                min=arr[i];
            }
        }

       Console.WriteLine(min);
        }
    
}