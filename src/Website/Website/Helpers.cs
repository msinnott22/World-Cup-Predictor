using System;
using System.Linq;

namespace Website
{
    public class Helpers
    {
        private static Random _random;

        public Helpers()
        {
            _random = new Random();
        }

        public string GenerateCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}