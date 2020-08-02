using System;
using static System.Math;
using static System.Console;

namespace CSharp6NewFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NameFeature name = new NameFeature();
                name.FirstName = "Jan";
                name.LastName = "Wang";
                WriteLine(name.FullName);
                WriteLine(Max(2, 3));
                var uName = name?.UniqueName2;
                WriteLine(uName);
                WriteLine(name?.UniqueName ?? "uniqueName");
                WriteLine(nameof(name));
                WriteLine(nameof(name.FullName));
                WriteLine(name.webErrors[506]);
            }
            catch(Exception e) when(e.Message.Contains("301"))
            {
                WriteLine("Site Moved");
            }
            WriteLine("Hello World!");
        }
    }
}
