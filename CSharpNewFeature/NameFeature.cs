using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp6NewFeature
{
    public class NameFeature
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string UniqueName2 { get; set; } = "11";
        public string UniqueName { get; set; } = null;

        public Dictionary<int, string> webErrors = new Dictionary<int, string>
        {
            [404] = "Page not Found",
            [302] = "Page moved, but left a forwarding address.",
            [500] = "The web server can't come out to play today.",
            [506] = "506"
        };
    }
}
