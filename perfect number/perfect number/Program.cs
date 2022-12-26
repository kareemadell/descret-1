using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter frist number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter ende number");
            double num2 = double.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                for (double i = num1; i <= num2; i++)
                {
                    double sum = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0) sum += j;
                    }
                    if (sum == i) Console.WriteLine("number =  " + i);



                }



            }
            else Console.WriteLine("you have error");
        }
    }
}
