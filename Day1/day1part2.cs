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
        public static void Main()
        {
            int frequency = 0;

            List<int> lines = File.ReadLines("input.txt").Select(int.Parse).ToList();

            HashSet<int> listOfFrequencies = new HashSet<int> { frequency };

            while (true)
            {
                foreach (var line in lines)
                {

                    frequency += Convert.ToInt32(line);


                    if (listOfFrequencies.Contains(frequency))
                    {
                        Console.WriteLine(frequency);
                        Console.ReadKey();
                    }

                    listOfFrequencies.Add(frequency);
                }
            }

        }

    }
}
