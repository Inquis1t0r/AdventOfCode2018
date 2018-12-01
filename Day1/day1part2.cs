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
            List<int> listOfFrequencies = new List<int>();



            int frequency = 0;
            var lines = File.ReadLines("input.txt");
            foreach (var line in lines)
            { 
                frequency += Convert.ToInt32(line);
                

                if (listOfFrequencies.Contains(frequency))
                    Console.WriteLine(frequency);

                listOfFrequencies.Add(frequency);
            }

            //var hash = new HashSet<int>();
            //var duplicates = listOfFrequencies.Where(item => !hash.Add(item)).ToList().Distinct().ToList();

            //duplicates.ForEach(Console.WriteLine);
        }
    }
}
