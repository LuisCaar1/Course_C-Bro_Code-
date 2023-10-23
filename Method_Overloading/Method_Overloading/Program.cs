﻿namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method overloading = methods share same name, but different parameters
            //                     name + parameters = signature
            //                     methods must have a unique signature

            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
           
        }

        static double Multiply(double a, double b) 
        { 
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

    }


}