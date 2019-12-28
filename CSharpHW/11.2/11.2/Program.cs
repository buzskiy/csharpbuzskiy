//2. Создайте консольное приложение.Добавьте ссылку на предыдущий проект.Создайте по расширяющему методу для каждого из классов позволяющих работать с массивами
// соответствующих типов данных(текст, текст и цвет, фото). 


using System;
using _11._1;

namespace _11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ColourPrinter cprinter = new ColourPrinter();
            PhotoPrinter phprinter = new PhotoPrinter();

            string[] texttoprint = new []{ "1", "2" };
            string[] textandcolour = new[] { "1", "red" };
            object[] photos = new[] { "1", "2" };

            ExtensionMethods.PrintText(cprinter, texttoprint);
            ExtensionMethods.PrintTextAndColour(cprinter, textandcolour);
            ExtensionMethods.PrintPhoto(phprinter, photos);


        }
    }

    public static class ExtensionMethods
    {
        public static void PrintText (this ColourPrinter value, string [] text)
        {
        value.TextArray = text;
        }
        public static void PrintTextAndColour(this ColourPrinter value, string[] textandcolour)
        {
            value.TextColorArray = textandcolour; 
        }
        public static void PrintPhoto(this PhotoPrinter value, object[] photos)
        {
            value.PhotoArray = photos;
        }
    }
}
