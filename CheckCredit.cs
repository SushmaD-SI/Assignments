using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CheckCredit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the purchase price : ");
            int price = Convert.ToInt32(Console.ReadLine());


            if (price > 100000 ) 
            {
                Console.WriteLine("ERROR!!!");
            }
            else
            {
                Console.WriteLine("Approved");
            }
        }
    }
}
