using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Alphabeticalorder
    {

        public static void Main(string[] args)
        {
            String s = Console.ReadLine();


            char[] c = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                c[i] = s[i];
            }


            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i]);
            }

            foreach (char a in s)
            {

            }
            Console.ReadKey();

        }
    }

}
