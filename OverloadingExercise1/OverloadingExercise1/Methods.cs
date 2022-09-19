using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExercise1
{
    internal class Methods
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Addition(decimal x, decimal y) //able to add two decimals together
        {
            return x + y;
        }
        public static double Addition(double num1, double num2) //able to add two doubles together
        {
            return num1 + num2;
        }

        public static string Addition(int num1, int num2, bool isTrue) //accepts two integers and one boolean, returns dollar amount
        {
            int sum = num1 + num2;

            if (isTrue == true && (sum > 1))
                return (sum) + " dollars";

            else if (isTrue == true && sum == 1)
                return (sum + " dollar");

            else return $"{num1 + num2}";
        }
    }
}
