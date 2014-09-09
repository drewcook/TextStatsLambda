﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //call textstats
            TextStats("Mexican food can be very yummy at times.  It's not all about Ms. Jemima's syrup anymore.  Again, it is all nonsuperficial when it comes to nachos.");

            //keep console open
            Console.ReadKey();
        }

        //functions go here
        static void TextStats(string input)
        {
            //create list out of input
            List<string> list = input.Split(' ').ToList();
            //print out number of characters
            Console.WriteLine(input.Length);
            //print out number of words
            Console.WriteLine(list.Count);
            //print out number of vowels
            Console.WriteLine(list.Where(x => x.Contains("aeiouAEIOU")));
            //print out number of consonants
            Console.WriteLine(string.Join(", ", list.Where(x => !x.Contains("aeiouAEIOU., !'?;"))));
            //print out number of special characters
            Console.WriteLine(list.Where(x => x.Contains(".,?!;'")));
            //print out longest word
            Console.WriteLine(list.OrderByDescending(x => x.Length).First());
            //print out shortest word
            Console.WriteLine(list.OrderBy(x => x.Length).First());

        }
    }
}
