using System;
class Program
{
    static void Sumof2Numnbers( ) // function defination
    {
        Console.WriteLine("enter a:");
        int a =int.Parse(Console.ReadLine());
        Console.WriteLine("enter b:");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine("sum is:"+c);

    }
    static void Main()
    {
     Sumof2Numnbers(); // function call
    }
}