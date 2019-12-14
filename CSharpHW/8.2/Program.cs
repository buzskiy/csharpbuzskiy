using System;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarConstructor basicCar = new CarConstructor();

            Engine newEngine = new Engine("superengine ");
            Color newColor = new Color("blue ");
            Transmission newTransmission = new Transmission("automatic ");
            Console.WriteLine(basicCar.BasicEngine + basicCar.BasicColor + basicCar.BasicTransmission);

            basicCar.Construct(newEngine, newColor, newTransmission);
            Console.WriteLine(basicCar.BasicEngine + basicCar.BasicColor + basicCar.BasicTransmission);

            Engine anotherNewEngine = new Engine("engine 2 ");
            basicCar.Reconstruct(anotherNewEngine);
            Console.WriteLine(basicCar.BasicEngine + basicCar.BasicColor + basicCar.BasicTransmission);
        }
    }

    public class Engine
    {
        public string CarEngine { get; set; }

        public Engine()
        {
            CarEngine = "Basic";
        }

        public Engine(string engine)
        {
            CarEngine = engine;
        }
    }

    public class Color
    {
        public string CarColor { get; set; }

        public Color(string color)
        {
            CarColor = color;
        }

    }

    public class Transmission
    {
        public string CarTransmission { get; set; }

        public Transmission(string transmission)
        {
            CarTransmission = transmission;
        }
    }

    public class CarConstructor
    {
        public string BasicColor;
        public string BasicEngine;
        public string BasicTransmission;

        public CarConstructor()
        {
            BasicColor = "basic color ";
            BasicEngine = "basic engine ";
            BasicTransmission = "basic transmission ";
        }

        public void Construct( Engine engine,  Color color,  Transmission transmission)
        {
            
            BasicColor = color.CarColor;
            BasicEngine = engine.CarEngine;
            BasicTransmission = transmission.CarTransmission;
           
        }

        public void Reconstruct(Engine engine)
        {
            BasicEngine = engine.CarEngine;
            
        }

    }

}

