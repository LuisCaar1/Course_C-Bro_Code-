namespace IF_Statement_Example_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If statement = a basic form of decision making

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if(name != "")
            {
                Console.WriteLine("Hello " + name);
                
                
            }
            else 
            {
                Console.WriteLine("You did not enter your name");
            }
        }
    }
}