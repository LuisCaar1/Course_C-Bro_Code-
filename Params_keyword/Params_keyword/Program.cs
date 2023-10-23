﻿using System.ComponentModel.Design;

namespace Params_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //params keyword = a method parameter that takes a variable number of arguments.
            //                   The parameter type must be a single - dimensional array

            double total = CheckOut(3.99, 5.75, 15, 1, 10.25);

            Console.WriteLine(total);
        }

        static double CheckOut(params double[] prices) 
        {
            double total = 0;

            foreach (double price in prices)
            {
                total = total + price;
            }
            return total;
        }
    }
}