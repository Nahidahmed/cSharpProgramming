using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArr = {1,2,3,4,5,6};
            Console.WriteLine("Sum of Even Numbers in the array: "+ SumOfEvenNumbers(intArr));
        }

        static long SumOfEvenNumbers(int[] intArray){
            return intArray.Where(i => i%2 == 0).Sum(i => (long)i);
        }
    }
}
