using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharp8NewFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };
            WriteLine(words[1..4]);
            WriteLine(words[^2..^0]);
            WriteLine(words[..]);
            WriteLine(words[..4]);
            WriteLine(words[6..]);

            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17

            Point p = new Point();
            p.X = 2;
            p.Y = 3;
            WriteLine(p);
            WriteLine(FromRainbow(Rainbow.Blue));
            WriteLine(RockPaperScissors("rock", "paper"));
        }


        public static string RockPaperScissors(string first, string second)
    =>  (first, second) switch
        {
            ("rock", "paper") => "rock is covered by paper. Paper wins.",
            ("rock", "scissors") => "rock breaks scissors. Rock wins.",
            ("paper", "rock") => "paper covers rock. Paper wins.",
            ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
            ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
            ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
            (_, _) => "tie"
        };

        public static string FromRainbow(Rainbow colorBand) =>
        colorBand switch
        {
        Rainbow.Red => "Red",
        Rainbow.Orange => "Orange",
        Rainbow.Yellow => "Yellow",
        Rainbow.Green => "Green",
        Rainbow.Blue => "Blue",
        Rainbow.Indigo => "Indigo",
        Rainbow.Violet => "Yellow",
        _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
        };
    }
}
