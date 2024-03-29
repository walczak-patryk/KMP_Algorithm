﻿using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace AZ_KMP
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Ala ma kota, a kot ma Ale";
            //string pattern = "kota";

            string text = "0123456789";
            string pattern = "23";

            //var lines = ReadWrite.ReadFile();

            //string text = "blablacblblacblacblcablacblc";
            //string pattern = "blacblc";
            var result1 = Algorithms.KMP(text, pattern);
            var result2 = Algorithms.NaiveAglorithm(text, pattern);

            //if (lines.Count == 0)
            //    return;

            //var results = new List<List<int>>();

            //foreach(var instance in lines)
            //{
            //    var result = Algorithms.KMP(instance.Item1, instance.Item2);
            //    if (result != null && result.Count > 0)
            //    {
            //        foreach (var res in result)
            //            Console.WriteLine($"Znaleziono wzorzec na indeksie {res}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nie znaleziono wzorca.");
            //    }
            //    results.Add(result);
            //}
            //ReadWrite.WriteFile(results);
            //Console.WriteLine("Zakończono!");
            //Console.ReadKey();
        }
    }

    class Test
    {
        void MoveTheTestToAnotherProject()
        {
            string text = "0123456789";
            string pattern = "23";
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var (result1, comparisons) = Algorithms.KMP(text, pattern);
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}
