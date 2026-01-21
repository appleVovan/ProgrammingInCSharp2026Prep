using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.Samples
{
    public enum DogBreed
    {
        Poodle = 2,
        Labrador = 4,
        Labradoodle = 6
    }

    internal partial class Dog
    {
        private int age;
        private string name;
        private DogBreed breed;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Name { get => name; set => name = value; }

        public string Identifier
        {
            get
            {
                return $"Name: {Name}, age: {Age}";
            }
        }

        public DogBreed Breed { get => breed; set => breed = value; }

        public void MyMethod()
        {
            int val1 = Age;
            Age = 5;
        }
    }
}
