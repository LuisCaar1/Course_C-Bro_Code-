namespace IF_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statement = a basic form of decision makimg

            Console.WriteLine("Please enter tou age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are now signed up");
            }
            else if (age > 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't born yet!");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up");
            }
        }
    }
}