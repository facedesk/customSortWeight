using System;
using System.Collections.Generic;
using System.Linq;

namespace brewers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }
        public static string orderWeight(string numbers)
        {
            string[] toCalculate = numbers.Split(' ');
            Array.Sort(toCalculate, weightedComparison);
            return String.Join(" ",toCalculate);
        }
        private static int weightedComparison(string x, string y)
        {
            int ix = getWeight(x);
            int iy = getWeight(y);
            if(ix!=iy)
            {
                return ix.CompareTo(iy);
            }
            else
            {
                return x.CompareTo(y);
            }
        }
        public static int getWeight(string value)
        {
            return value.ToCharArray().Select(e => (int)Char.GetNumericValue(e)).Sum();
        }
    }
}
