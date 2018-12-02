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

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            Boolean has2, check2 = false;
            Boolean has3, check3 = false;

            int coeff1 = 0;
            int coeff2 = 0;
            int checksum = 0;

            foreach (var line in lines)
            {
  

                foreach (char c in alphabet)
                {

                    int counter = line.Count(x => x == c);

                    while (check3 == !true)
                    {
                        if (counter == 3)
                        {
                            has3 = true;
                            check3 = true;
                            coeff2 += 1;
                        }
                    }


                    while (check2 == !true)
                    {
                        if (counter == 2)
                        {
                            has2 = true;
                            check2 = true;
                            coeff1 += 1;
                        }
                    }

                    Console.WriteLine(line + c);
                }
               
            }
            checksum = coeff1 * coeff2;
            Console.WriteLine(checksum);

        }
    }
}
