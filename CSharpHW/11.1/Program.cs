//1. Создайте консольное приложение.Создайте базовый класс Printer с одним виртуальным методом Print
//  принимающим один строковой аргумент и выводящим значение аргумента в консоль.Создайте производные классы ColourPrinter и PhotoPrinter
//   которые наследуют поведение базового класса и реализуют виртуальный метод Print из базового класса, оттенить работу соответствующим сообщением в консоли.
//   Класс ColourPrinter должен иметь дополнительный метод Print принимающий текст и цвет.
//   Класс PhotoPrinter должен иметь дополнительный метод Print принимающий фото.
//   Создайте екземпляры каджого из классов и продемонстируйте работу методов.

using System;

namespace _11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("hi");

            ColourPrinter cprinter = new ColourPrinter();
            cprinter.Print("hi");
            cprinter.Print("bla", "red");
            Console.WriteLine(cprinter.Text);
            Console.WriteLine(cprinter.Colour);


            PhotoPrinter phprinter = new PhotoPrinter();
            phprinter.Print("hi");
        }
    }

    public class Printer
    {
        public string Argument;

        public virtual void Print (string argument)
        {
            Console.WriteLine(argument);
        }
    }

    public class ColourPrinter : Printer
    {
        public string Text;
        public string Colour;
        public string[] TextArray;
        public string[] TextColorArray;

        public override void Print (string argument)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(argument);
        }

        public void Print(string text, string colour)
        {
            Text = text;
            Colour = colour;
        }
    }

    public class PhotoPrinter : Printer
    {
        public object Photo;
        public object[] PhotoArray;

        public override void Print(string argument)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(argument);
        }

        public void Print(object photo)
        {
            Photo = photo;
        }
    }

    
}
