using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArr = {1,2,3,4,5,6};
            Console.WriteLine("Sum of Even Numbers: "+ SumOfEvenNumbers(intArr));

            //Out of 3 numbers find max value. Create an array of those number and call Array.Max()    
            Console.WriteLine("Max Value: "+ intArr.Max());

            //String Reversal
            Console.WriteLine("Reverse of Mansuri: "+ ReverseString("Mansuri"));
            //Palindrome
            IsPalindromeString("icu");
        }

        static long SumOfEvenNumbers(int[] intArray){
            return intArray.Where(i => i%2 == 0).Sum(i => (long)i);
        }

        static string ReverseString(string str){
            char[] charArr = str.ToCharArray();
            
            return new string(charArr.Reverse().ToArray());
        }

        static void IsPalindromeString(string str)
        {
            char[] charsArr = str.ToCharArray();
            string reverseStr = new string(charsArr.Reverse().ToArray());
                
            if(str == reverseStr)
                Console.WriteLine("Its a Palindrome string: " +reverseStr);
            else
                Console.WriteLine("Its NOT a Palindrome string: " +reverseStr);
        }
        
    }
}
