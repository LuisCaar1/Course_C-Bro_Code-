namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exception = errors that occur during execution

            //      try = try some code that is considered "dangerous"
            //      catch = catches and handles exceptions when they occur
            //      finally = always executes regardless if exception is caught or not

            double x;
            double y;
            double result;

            try
            {

                Console.WriteLine("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }
            /*catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by 0, idiot!");
            }*/
            catch (Exception e) //GLOBAL Exception
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }
        }
    }
}