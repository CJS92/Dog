// This is a project for IT 2040.
// Cody Sloan
// 02/15/2019

using System;

public enum Gender
{
    Male,
    Female
}

namespace Dog
{
    public class Dog
    {
        public string name;
        public string owner;
        public int age;
        readonly Gender gender;

        public Dog(string dogName, string dogOwner, int dogAge, Gender dogGender)
        {
            name = dogName;
            owner = dogOwner;
            age = dogAge;
            gender = dogGender;
        }

        public Dog()
        {
        }


        public void Bark(int to)
        {
            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }

            Console.ReadLine();
        }
    }

    class MainClass
        {
            public static void Main(string[] args)
            {
            var dog = new Dog();

            dog.Bark = "{0}";

            Console.ReadLine();
        }
        }
    }
