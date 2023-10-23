namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x; //declaration
            x = 123; //initialization

            int y = 321; // eclaration + initialization

            int z = x + y;

            int age = 21; // Whole Integer
            double height = 300.5; //Decimal number
            bool alive = false; //true or false
            char symbol = '@'; //Characters
            String name = "LuisCarrasco";//Strings

            Console.WriteLine("Hello, my name is " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("My height is " + height + " cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);

            String username = symbol + name;

            Console.WriteLine("Your username is: " + username);

            Console.ReadKey();  

        }
    }
}