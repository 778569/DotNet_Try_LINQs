using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Try_LINQs
{
    public class Projection_Operators
    {
        public void selectClause()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne = from n in numbers
                              select n + 1;

            var MethodSyn = numbers.Select(n => n + 1);

            Console.WriteLine("Numbers + 1:");
            foreach (var i in MethodSyn)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
