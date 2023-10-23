namespace Conditional_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conditional operator = used in conditional assigment if a condition is true/false

            //  (Condition) ? x : y

            double temperatue = 20;
            String message;
            /*
            if (temperatue >= 15)
            {
                message = "It's warm outside";
            }
            else
            {
                message = "Its cold outside";
            }
            */

            message = (temperatue >= 15) ? "It's warm outside" : "Its cold outside";

            Console.WriteLine(message);

           

        }
    }
}