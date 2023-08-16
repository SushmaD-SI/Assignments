namespace Assignment
{
    internal class ReversedArray
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter  number of values");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine("Enter  the  value");

                string input= Console.ReadLine();
                int ConvertedInput = Convert.ToInt32(input);

                numbers[i] = ConvertedInput;

            }
            Console.WriteLine("The reversed array is : ");
            for (int j = n-1; j >= 0; j--)
            {

                Console.WriteLine( numbers[j]);

            } 
            Console.ReadLine();

        }
    }
}