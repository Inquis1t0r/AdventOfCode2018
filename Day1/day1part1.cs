using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class day1
    {
        static void Main(string[] args)
        {
            int frequency = 0;
            var lines = File.ReadLines("input.txt");
            foreach (var line in lines)
            { 
            frequency += Convert.ToInt32(line);
            
            }
            Console.WriteLine(frequency);
        }
    }
}
