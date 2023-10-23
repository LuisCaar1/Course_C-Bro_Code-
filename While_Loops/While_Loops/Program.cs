namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // While loop = Repeats some code while some condition remains true
            String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);


        }
    }
}