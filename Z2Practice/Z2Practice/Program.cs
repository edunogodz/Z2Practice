using System;
using System.Text;

namespace Z2Practice
{
    class Program
    {
       public static void Main(string[] args)
        {
            ////Animal myAnimal = new Animal();
            //IAnimal myAnimal;
            //Console.WriteLine("What animal are you?");
            //string input = Console.ReadLine();

            //if (input == "Dog")
            //{
            //    myAnimal = new Dog();
            //}
            //else
            //{
            //    myAnimal = new Animal();
            //}

            //myAnimal.Name = "Jessica";
            //myAnimal.Breathe();

            //string exemploLabel =
            //DateTime.Now.ToString("d") + "\n\n" +
            //DateTime.Now.ToString("D") + "\n\n" +
            //DateTime.Now.ToString("t") + "\n\n" +
            //DateTime.Now.ToString("T") + "\n\n" +
            //DateTime.Now.ToString("f") + "\n\n" +
            //DateTime.Now.ToString("F") + "\n\n" +
            //DateTime.Now.ToString("g") + "\n\n" +
            //DateTime.Now.ToString("G") + "\n\n" +
            //DateTime.Now.ToString("M") + "\n\n" +
            //DateTime.Now.ToString("r") + "\n\n" +
            //DateTime.Now.ToString("s") + "\n\n" +
            //DateTime.Now.ToString("u") + "\n\n" +
            //DateTime.Now.ToString("Y") + "\n\n" +
            //DateTime.Now.ToString("dd") + "\n\n" +
            //DateTime.Now.ToString("ddd") + "\n\n" +
            //DateTime.Now.ToString("dddd") + "\n\n" +
            //DateTime.Now.ToString("MM") + "\n\n" +
            //DateTime.Now.ToString("MMM") + "\n\n" +
            //DateTime.Now.ToString("MMMM") + "\n\n" +
            //DateTime.Now.ToString("yy") + "\n\n" +
            //DateTime.Now.ToString("yyyy") + "\n\n" +
            //DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "\n\n" +
            //DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff") + "\n\n" +
            //DateTime.Now.ToString("São Paulo, dddd dd 'de' MMMM 'de' yyyy");

            //Console.WriteLine(exemploLabel);

            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }

        public static string ReverseString(string input)
        {
           // string reversedString = string.Empty;
            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                //reversedString += input[i]; 
                
                sb.Append(input[i]);
            }

            return sb.ToString();// reversedString;
        }
    }

    class Animal : IAnimal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public void Breathe()
        {
            Console.WriteLine("I'm breathing");
        }
    }

    class Dog : IAnimal
    {
        public string Name { get; set; }


        public void Breathe()
        {
            Console.WriteLine("I'm a dog breathing");
        }
    }


    interface IAnimal
    {
        string Name { get; set; }

        void Breathe();

    }

    
}

