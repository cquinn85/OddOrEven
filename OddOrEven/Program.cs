using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a number:");
            IsOdd();
        }

        public static void IsOdd()
        {
            var num = int.Parse(Console.ReadLine());
            var rem = num % 2;

            if(rem == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }
           
        }
    }

}
