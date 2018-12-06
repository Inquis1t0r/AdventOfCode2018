using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class day4
    {
        static void Main(string[] args)
        {


            var lines = File.ReadLines("input.txt");
            HashSet<int> Guards = new HashSet<int> { };

            foreach (var line in lines)
            {
                String Content = line.Substring(19);
                

                if (line.EndsWith(" begins shift"))
                {

                    int GuardID = int.Parse(Content.Replace("Guard #", "").Replace(" begins shift", ""));

                    if(!Guards.Contains(GuardID))
                        Guards.Add(GuardID);


                }


                var date = DateTime.ParseExact(line.Substring(1, 10), "yyyy-MM-dd", CultureInfo.CurrentCulture);
                Console.WriteLine(date);

            }

            foreach (var guard in Guards)
            {
                Console.WriteLine(guard);
            }

        }
    }
}
