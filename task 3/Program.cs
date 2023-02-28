using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int en = 5;
        int uzunluq = 5;
        for (int i = 1; i <= en; i++)
        {
            for (int j = 1; j <= uzunluq; j++)
            {
                if (i == 1 || i == en)
                {
                    Console.Write("*");
                }
                else
                    if (j == 1 || j == uzunluq)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}