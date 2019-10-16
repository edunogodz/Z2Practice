using System;

namespace Z2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            //myAnimal.Name = "Fred";
            //myAnimal.SetAnimalName("");

            Console.WriteLine(myAnimal.Name);
        }
    }

    class Animal
    {
        public string Name { get;}

        //private string _name;

        public Animal()
        {
            Name = "No Name";
        }

        public Animal(string name)
        {
            Name = name;
        }
        //public void SetAnimalName(string name)
        //{
        //    Name = name;
        //}
    }
}

