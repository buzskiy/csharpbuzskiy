using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
              var Car = new Car();
              Car.Color = "Blue";
            Console.WriteLine($"Car color is {Car.Color}");
            TuningAtelier.TuneCar(Car);
        }
    }

    class Car 
    {
        public string Model {get;set;}
        public string Year {get;set;}
        public string Color {get;set;}
    }
    static class TuningAtelier
    {
        public static void TuneCar(Car Car)
        {
            Car.Color = "Red";
            Console.WriteLine($"Car color is changed to {Car.Color}");   
        }
    }
}