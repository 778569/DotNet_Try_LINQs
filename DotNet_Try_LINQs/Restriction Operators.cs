using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Try_LINQs
{
    public class Restriction_Operators
    {

        public void Test01()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;

            var MethodSyntax = numbers.Where(x => x < 5);

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (var x in MethodSyntax)
            {
                Console.WriteLine(x);
            }
        }


        public void Test02()
        {
            List<int> numbers = new List<int>(){ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;

            var MethodSyntax = numbers.Where(x => x < 5);

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (var x in MethodSyntax)
            {
                Console.WriteLine(x);
            }
        }


        public void Test03()
        {
            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shortDigits = digits.Where((digit, index) => digit.Length < index);

            //var shortDigits = digits.Where((x, index) => x.Length < index);


            var Names = numbers.Select(x => digits[x]);

            Console.WriteLine("Short digits:");
            foreach (var d in Names)
            {
                Console.WriteLine($"The word {d} is shorter than its value.");
            }
        }

    }
}
