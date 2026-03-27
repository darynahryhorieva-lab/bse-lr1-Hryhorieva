using System;

class Program
{
    static void Main()
    {
        int height = 10;
        
        for (int i = 1; i <= height; i++)
        {

            for (int k = 1; k <= height - i; k++)
                Console.Write(" ");
            
            for (int j = 1; j <= 2 * i - 1; j++)
                Console.Write("*");
            
            Console.WriteLine();
        }
        
        for (int i = 1; i <= 3; i++)
        {
            for (int k = 1; k <= height - 2; k++)
                Console.Write(" ");
            Console.WriteLine("|||");
        }
        Console.ReadLine();
    }
}