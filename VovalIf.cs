using System;
class Program17
{
    public static void Main(string[] args)
    {
        char ch;
        Console.WriteLine("Enter a char");
        ch=Convert.ToChara(Console.ReadLine());
        if(ch=='a' ||ch=='e' ||ch=='i' ||ch=='o' ||ch=='u'|| ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
        {
            Console.WriteLine("Number is voval:"+ch);
        }
        else
        {
            Console.WriteLine("Number is consonant:"+ch);
        }

        
    }
}