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
            string alphabet = "abcdefghijklmnopqrstuvwxyz"; //TODO Aplbaheb interfavce



            foreach (var line in lines)
            {

                foreach (char c in alphabet)
                {
                    Console.WriteLine(line.Count(x => x == c));
                }

            }
        }
    }
}
