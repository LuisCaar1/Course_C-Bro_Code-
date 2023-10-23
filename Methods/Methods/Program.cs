namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Methods = performs a section of code, whenever it's called "invoked".
            //  benefits = Let's us reuse code w/o writing it multiple times 

            /*
            String name = "Bro";
            int age = 21;*/

            singHappyBirthday("Carlos", 23);
      
        }

        static void singHappyBirthday(String birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("You are " + yearsOld + " years old");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}