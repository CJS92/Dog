// This is a project for IT 2040.
// Cody Sloan
// 02/15/2019

using System;

namespace Dog
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Dog puppy = new Dog(); // create object instance
            puppy.Name = "Max";
            puppy.Owner = "William";
            puppy.Age = 3;
            puppy.Gender = Gender.Male;

            Dog myDog = new Dog(); // create new object
            myDog.Name = "Lexi";
            myDog.Owner = "Ashley";
            myDog.Age = 1;
            myDog.Gender = Gender.Female;

            // display output
            puppy.Bark(3);
            puppy.GetTag();

            Console.WriteLine("\n");
            myDog.Bark(1);
            myDog.GetTag();

            // display exit message
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
