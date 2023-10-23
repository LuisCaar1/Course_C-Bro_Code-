namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String interpolation = allows us to insert variables into a string literal
            //                       precede a string literal with $
            //                       {} are placeholders

            String firstName = "Bro";
            String lastName = "Code";
            int age = 21;

            /*
            Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            Console.WriteLine("You are " + age + " years old");*/

            Console.WriteLine($"Hello {firstName} {lastName}. ");
            Console.WriteLine($"You are {age} years old");

        }
    }
}