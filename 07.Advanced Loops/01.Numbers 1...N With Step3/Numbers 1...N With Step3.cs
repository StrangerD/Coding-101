﻿using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i = i + 3)
        {
            Console.WriteLine(i);
        }



    }
}

