using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Sum

    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the no. of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] elements = new int[n];

            int sum =0;
            for (int i = 0; i<n;i++)
            {
                Console.WriteLine("Enter the value");

                elements[i] = Convert.ToInt32(Console.ReadLine());

                
            }


            for(int i= 0;i<n;i++)
            {
                sum+=elements[i];
               
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
