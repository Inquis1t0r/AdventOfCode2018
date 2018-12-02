using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2
{
    class day2
    {
        static void Main(string[] args)
        {

            var lines = File.ReadLines("input.txt");
            Regex regex = new Regex("");

            foreach (var line in lines)
            {
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    int count = Regex.Matches(line, c).Count;
                }

            }
        }
    }
}
