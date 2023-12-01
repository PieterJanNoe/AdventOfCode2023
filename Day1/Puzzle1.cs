using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Day1
{
    public class Puzzle1
    {
        public static void Main()
        {
            string fileloc = @"C:\Users\PX6393\source\repos\AdventOfCode2023\Day1\Data\input.txt";

            var result = 0;

            IEnumerable<string> lines = File.ReadLines(fileloc);
            foreach (string line in lines)
            {
                Console.WriteLine("line: " + line);
                var number  = new String(line.Where(Char.IsDigit).ToArray());

                Console.WriteLine("Number: " + number.ToString());
                if (number.Length > 2) {
                    number = number[0] + "" + number[number.Length -1];
                } else if (number.Length < 2)
                {
                    number = number[0] + "" +number[0];
                }

                Console.WriteLine("First & Last: " + number.ToString());
                result += Int32.Parse(number);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Result: " + result);
                Console.ResetColor();
                Console.WriteLine("\n");
            }
            Console.WriteLine("total amount:" + result);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
