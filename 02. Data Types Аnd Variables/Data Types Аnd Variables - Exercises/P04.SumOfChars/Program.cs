﻿using System;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int currentCharCode = (int)currentChar;
                sum += currentCharCode;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
