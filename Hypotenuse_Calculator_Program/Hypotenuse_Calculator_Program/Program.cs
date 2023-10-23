namespace Hypotenuse_Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter side A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side A:");
            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The Hypotenuse is: " + c);
        }
    }
}