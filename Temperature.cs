using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Temperature
    {
        static void Main(string[] args)
        {
            int sum = 0,number= 0;
            while (true)
            {
                
                Console.WriteLine("Enter the value ");
                string input = Console.ReadLine();
                if (String.Equals(input, "exit")) break;

                int currentemp = Convert.ToInt32(input);

                if (currentemp < 20  || currentemp > 130)
                {
                    Console.WriteLine("Invalid");
                    continue;
                }

                sum =sum+currentemp;
                number++;

            }

            Console.WriteLine("Then number of temperatures entered is" + number);
            Console.WriteLine("The average is " + (sum / number));
        }
    }
}
