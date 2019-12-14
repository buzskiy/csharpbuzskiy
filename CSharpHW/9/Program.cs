//1. Создайте структуру FileHandle.Стурктура должна содержать FileSize, FileName, FilePath, FileAccessEnum.
//   FileAccessEnum в свою очередь представляет собой флаговое перечисление(Read, Write). 
//   Напишите несколько методов принимающих полный путь к файлу и возвращающих соответствующий FileHandle:
//       OpenForRead - открытие файла на чтение.
//	   OpenForWrite - открытие файла на запись.

//	   OpenFile - открытие файла с указанием FileAccessEnum.
//   Продемонстрируйте использование описанных методов.
//   Продемонстируйте открытие файла в режиме ReadWrite.
   
using System;

namespace _9
{
    class Program
    {
        static void Main()
        {
            FileHandle file = new FileHandle();


            Console.WriteLine("Change structure to read only");
            file.OpenForRead("C:/ReadOnlyFiles/ ");
            Console.WriteLine("FileSize: " + file.FileSize + " FileName: " + file.FileName);
            Console.WriteLine("FilePath: " + file.FilePath + " FileAccessType: " + file.FileAccessType);


            Console.WriteLine("\nChange structure to write only");
            file.OpenForWrite("C:/WriteOnlyFiles/ ");
            Console.WriteLine("FileSize: " + file.FileSize + " FileName: " + file.FileName);
            Console.WriteLine("FilePath: " + file.FilePath + " FileAccessType: " + file.FileAccessType);

            Console.WriteLine("\nSpecify what you want to do with file:");
            var fileaccesstype = Console.ReadLine();
            file.OpenForSpecified("C:/AllFiles/ ", fileaccesstype);
            Console.WriteLine("FileSize: " + file.FileSize + " FileName: " + file.FileName);
            Console.WriteLine("FilePath: " + file.FilePath + " FileAccessType: " + file.FileAccessType);

            Console.WriteLine("\nChange structure to readwrite");
            file.OpenReadWrite("C:/ReadAndWriteFiles/ ");
            Console.WriteLine("FileSize: " + file.FileSize + " FileName: " + file.FileName);
            Console.WriteLine("FilePath: " + file.FilePath + " FileAccessType: " + file.FileAccessType.ToString());

        }


        struct FileHandle
        {
            public string FileSize { get; set; }
            public string FileName { get; set; }
            public string FilePath { get; set; }
            [Flags] public enum FileAccessEnum { Read = 1, Write = 2 }
            public FileAccessEnum FileAccessType { get; set; }

            public FileHandle(string filesize, string filename, string filepath, FileAccessEnum fileaccesstype)
            {
                FileSize = filesize;
                FileName = filename;
                FilePath = filepath;
                FileAccessType = fileaccesstype;
            }

            public void OpenForRead(string filepath)
            {
                FileSize = "3 ";
                FileName = "ReadOnlyFileName ";
                FilePath = filepath;
                FileAccessType = FileAccessEnum.Read;
            }

            public void OpenForWrite(string filepath)
            {
                FileSize = "10 ";
                FileName = "WriteOnlyFileName";
                FilePath = filepath;
                FileAccessType = FileAccessEnum.Write;
            }

            public void OpenForSpecified(string filepath, string fileaccesstype)
            {
                FileSize = "10 ";
                FileName = "WriteOnlyFileName";
                FilePath = filepath;
                FileAccessType = (FileAccessEnum)Enum.Parse(typeof(FileAccessEnum), fileaccesstype);
            }

            public void OpenReadWrite(string filepath)
            {
                FileSize = "10 ";
                FileName = "ReadAndWriteFileName";
                FilePath = filepath;
                FileAccessType = FileAccessEnum.Read | FileAccessEnum.Write;
            }

        }
    }

    

}
