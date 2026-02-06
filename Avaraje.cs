//using && operator program using if else and print averaje 
using System;
class Program8
{
    static void Main(string[] args)
    {
        int marks = 30;
        string name= "Shubham";

        if (marks >= 80 && marks <= 100)
        {
            Console.WriteLine("Topper:"+ name +" "+marks+"%");
       
    }
    else if(marks >60 && marks <= 80)
        {
            Console.WriteLine("Avarage:"+name + " "+marks+"%");
        }
        else if(marks >=10 && marks <=60)
        {
            Console.WriteLine("Fail:"+name+ ""+marks+"%");
        }



}
}
