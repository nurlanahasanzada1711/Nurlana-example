using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int count = 0;
        int eded = 20;
        for (int i = 2; i < eded / 2; i++)
        {
            if (eded % i == 0)
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine("murekkeb ededdir");
        }
        else
        {
            Console.WriteLine("sade ededdir");
        }
    }
}
