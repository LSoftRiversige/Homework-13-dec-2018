using System;
using System.Collections.Generic;

// https://github.com/LSoftRiversige/Homework-13-dec-2018.git

namespace HomeWorkLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            LinqLS.FloatToInt(new float[] { 1.14f, 2.99f, 33, 44, 555, 0 }).DisplayToConsole();

            LinqLS.NumsToBool(new int[] { 1, 2, 3, 4, 5, -1 }).DisplayToConsole();

            IEnumerable<string> vowelless = LinqLS.ExtractVowels(new List<string> { "привет", "одесса", "мир", "информатика"});
            vowelless.DisplayToConsole();



            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
