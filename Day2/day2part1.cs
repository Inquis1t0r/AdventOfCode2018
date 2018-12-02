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

            string alphabet = "abcdefghijklmnopqrstuvwxyzA";



            int coeff3 = 0;
            int coeff2 = 0;
            int checksum = 0;

            foreach (var line in lines)
            {
                Boolean check2 = false;
                Boolean check3 = false;

                foreach (char c in alphabet)
                {

                    int counter = line.Count(x => x == c);


                    if (counter == 3 && !check3)
                    {
                        check3 = true;
                        coeff3 += 1;
                    }

                    else if (counter == 2 && !check2)
                    {
                        check2 = true;
                        coeff2 += 1;
                    }

                }

            }
            checksum = coeff3 * coeff2;
            Console.WriteLine(checksum);

        }
    }
}
