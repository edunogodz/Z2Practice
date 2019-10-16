using System;

namespace Z2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car
            {
                Color = "Blue"
            };

            Car myCar2 = new Car
            {
                Color = "Red"
            };

            //_ = new Car
            //{
            //    Color = "Red"
            //};

            //_ = new Car
            //{
            //    Color = "Green"
            //};

            //Math myMath = new Math();
            //myMath.DoThings();
            //myMath.myString = "Hello";

            int total = Math.Add(5, 3);
                        
            int total2 = Math.Add(6, 12);

            Console.WriteLine(total);
            Console.WriteLine(total2);
        }
    }
}

 class Car
{
    public string Color { get; set; }
}

static class Math
{
    //public string myString { get; set; }
    public static int Add(int a,int b)
    {
        return a + b;
    }

    //public void DoThings()
    //{

    //}
}