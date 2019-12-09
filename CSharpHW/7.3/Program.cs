/**Создайте класс ShapeDescriptor а также Point (описывает координаты).
   Класс ShapeDescriptor должен имень несколько конструкторов с различным количеством точек.
   Класс ShapeDescriptor должен иметь свойство ShapeType определяющее тип фигуры. */

using System;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var point1 = new Point(3,5);
            var point2 = new Point (4,6);
            var point3 = new Point (5,7);

            var shape1 = new ShapeDescriptor(point1);
            var shape2 = new ShapeDescriptor(point1, point2);
            var shape3 = new ShapeDescriptor(point1, point2, point3);

            ShapeDescriptor.ShapeType(shape1);
            ShapeDescriptor.ShapeType(shape2);
            ShapeDescriptor.ShapeType(shape3);      
        }
    }
    class Point
    {
        public int x = 0;
        public int y = 0;
        public Point (int x, int y)
        {

        }
    }

    class ShapeDescriptor
    {
        public string shape
            {get; set;}
        public ShapeDescriptor(Point a)
        {
            this.shape = "Dot";
        }

        public ShapeDescriptor(Point a, Point b)
        {
            this.shape = "Line";
        }

        public ShapeDescriptor(Point a, Point b, Point c)
        {
            this.shape = "Triangle";
        }

        public static void ShapeType(ShapeDescriptor inputshape)
        {
            
            Console.WriteLine(inputshape.shape);
        }
    }
}
