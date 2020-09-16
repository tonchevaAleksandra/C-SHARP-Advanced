﻿using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<string> honor = new Action<string>((name) =>
            //     {

            //     });

            Action<string> print = x => Console.WriteLine($"Sir {x}");
            Console.ReadLine()
                  .Split()
                  .ToList()
                  .ForEach(print);

        }
    }
}
