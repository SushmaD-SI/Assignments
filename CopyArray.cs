using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CopyArray
    {

        static void Main(string[] args)
        {
            int[] array1 = { 2,3,7};

            int[] array2 = new int[array1.Length];

            for(int i =0;i<array1.Length;i++)
            {

               

                array2[i] = array1[i]; 

                
            }
            for (int i = 0; i < array1.Length; i++)
            {


                Console.WriteLine(array1[i]);

            }

            for (int i = 0; i < array2.Length;i++)
                {


                Console.WriteLine(array2[i]);

            }


            Console.ReadLine();

        }

    }
}
