using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Occurrences
    {

        public static void Main(string[] args)
        {



            int count = 0;
            String m = Console.ReadLine();
            char c = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i].Equals(c))
                {
                    count++;
                }

                Console.WriteLine(count);
            }
        }



    }
}