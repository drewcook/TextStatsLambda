using System;
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
            TextStats("Mexican nachos are very tasty.");

            //keep console open
            Console.ReadKey();
        }

        //functions go here
        static void TextStats(string input)
        {
            //create list out of input
            List<string> list = input.Split(' ').ToList();
            //print out number of characters
            Console.WriteLine("Number of characters: " + input.Length);
            //print out number of words
            Console.WriteLine("Number of words: " + list.Count);
            //print out number of vowels
            Console.WriteLine("Number of vowels: " + input.Count(x => "aeiou".Contains((x).ToString().ToLower())));
            //print out number of consonants
            Console.WriteLine("Number of consenants: " + input.Count(x => "bcdfghjklmnpqrstvwxyz".Contains((x).ToString().ToLower())));
            //print out number of special characters
            Console.WriteLine("Number of special characters: " + input.Count(x => " ,.;':!?".Contains((x).ToString().ToLower())));
            //print out longest word
            Console.WriteLine("Longest Word: " + list.OrderByDescending(x => x.Length).First());
            //print out shortest word
            Console.WriteLine("Shortest Word: " + list.OrderBy(x => x.Length).First());

        }
    }
}
