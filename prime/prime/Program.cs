
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter frist number:");
            double num1 = double.Parse (Console.ReadLine());
            Console.WriteLine("inter scound number:");
            double num2= double.Parse(Console.ReadLine());
            
            for (double i = num1;i<=num2;i++)
            {
              if(  prime(i))
                Console.WriteLine(i);
            }
        }

        public static bool prime(double n)
        {
            if (n ==1 || n == 0)
            {
                return false;

            }
            for (int i =2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
