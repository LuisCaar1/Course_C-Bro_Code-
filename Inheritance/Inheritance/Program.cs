namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance = 1 or more child classes recieving fields, methods, ect. from a common parent

            Car car = new Car();
            Bycicle bycicle = new Bycicle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bycicle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}