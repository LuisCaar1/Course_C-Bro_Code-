namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array = a variable that can store multiple values. Fixed size

            String[] cars = new string[3];
            
            //String [] cars = {"BMW", "Mustang", "Corvette"};

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            /*
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            */

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}