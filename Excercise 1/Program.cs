﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5; // number of rows, can be changed as needed

        // upper half of diamond
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // lower half of diamond
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}