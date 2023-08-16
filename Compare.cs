using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Compare
    {
        public static void Main(string[] args{



            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();

            Console.WriteLine(s1.Equals(s2));

            Console.WriteLine(s1.ToLower().Equals(s2.ToLower()));
        }

    }

}