﻿using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int eded = 34543;
        int reverse = 0;
        int qaliq = 0;
        int eded_2 = eded;
        while (eded > 0)
        {
            qaliq = eded % 10;
            reverse = (reverse * 10) + qaliq;
            eded = eded / 10;
        }
        if (eded_2 == reverse)
        {
            Console.WriteLine("polindromdur");
        }
        else
        {
            Console.WriteLine("polindrom deyil");
        }
    }
}