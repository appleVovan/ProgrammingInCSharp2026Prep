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
                if (value >= 0)
                    age = value;
                else
                    throw new Exception();
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

        private void Foo()
        {

        }

        internal void Bar()
        {

        }

        protected void Gas()
        {

        }

        public void Talk(string value)
        {

        }

        public int Talk(int value)
        {
            return 0;
        }

        public void Talk(int times, string value = "woof", bool sit = false)
        {

        }

        public DogBreed Breed { get => breed; set => breed = value; }

        public void MyMethod()
        {
            int val1 = Age;
            Age = 5;

            Breed = DogBreed.Labrador;

            switch (breed)
            {
                case DogBreed.Poodle:
                    break;
                case DogBreed.Labrador:
                    break;
                case DogBreed.Labradoodle:
                    break;
            }
        }
    }
}
