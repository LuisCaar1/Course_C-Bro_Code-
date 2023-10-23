﻿namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objects = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          Objects can have field & methods (characteristics & actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 16;


            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

        }
    }

    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}