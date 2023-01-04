using System;
 
//Создайте класс Printer.  
//В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.  
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра,
//строки, переданные в качестве аргументов методов, выводились разными цветами.  
//Обязательно используйте приведение типов. 
namespace Task_1
{
    class Program
    {
        static void Main()
        {
            PrinterBase printer = new PrinterBase();
            printer.Print("hi");

            Printer2 printer2 = printer as Printer2;
            Console.ForegroundColor = ConsoleColor.Green;
            printer2.Print("HI HI");
            Console.ResetColor();
        }
    }
}
