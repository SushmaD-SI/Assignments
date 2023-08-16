using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Delete
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the index to delete");
            int index = Convert.ToInt32(Console.ReadLine());

            while (index < n - 1)
            {
                arr[index] = arr[index + 1];
                index++;
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
        