using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Gender
{
    Male,
    Female
}

namespace Dog
{
    class Dog
    {
        public string Name;
        public string Owner;
        public int Age;
        public Gender Gender;

        public Dog(string dogName, string dogOwner, int dogAge, Gender dogGender, string dogPronoun)
        {
            Name = dogName;
            Owner = dogOwner;
            Age = dogAge;
            Gender = dogGender;
            Pronoun = dogPronoun;
        }

        public Dog()
        {
        }

        public void Bark(int times)
        {

            if (times > 0)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine("Woof!");
                }
            }
            Console.ReadLine();
        }

        public void GetTag()
        {
            // check age
            if (Age > 1)
            {
                switch (Gender)
                {
                    case Gender.Male:
                        Console.WriteLine("If lost, call {0}. His name is {1} and he is {2} years old.", Owner, Name, Age);
                        break;
                    case Gender.Female:
                        Console.WriteLine("If lost, call {0}. Her name is {1} and she is {2} years old.", Owner, Name, Age);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            else
            {
                switch (Gender)
                {
                    case Gender.Male:
                        Console.WriteLine("If lost, call {0}. His name is {1} and he is {2} year old.", Owner, Name, Age);
                        break;
                    case Gender.Female:
                        Console.WriteLine("If lost, call {0}. Her name is {1} and she is {2} year old.", Owner, Name, Age);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
 }
