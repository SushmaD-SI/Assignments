using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Substring
    {
        public static void Main(string[] args)
        {
            String s = Console.ReadLine();

            char[] delimiters = { ',' };

            String[] s2 = s.Split(delimiters);

            foreach (string item in s2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(s2); 

        }
    }
}
