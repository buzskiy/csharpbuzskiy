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

            shape1.ShapeType();
            shape2.ShapeType();
            shape3.ShapeType();
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class ShapeDescriptor
    {
        public string Shape {get; set;}
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public ShapeDescriptor(Point a)
        {
            Shape = "Dot";
            A = a;
        }

        public ShapeDescriptor(Point a, Point b)
        {
            Shape = "Line";
            A = a;
            B = b;
        }

        public ShapeDescriptor(Point a, Point b, Point c)
        {
            Shape = "Triangle";
            A = a;
            B = b;
            C = c;
           
        }

        public void ShapeType()
        {
            Console.WriteLine(Shape);
        }
    }
}
