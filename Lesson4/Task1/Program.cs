using System;
//Создайте класс AbstractHandler. 
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия,
//создания, редактирования, сохранения определенного формата документа. 

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите вид документа: ");
            Console.WriteLine("     XML         TXT        DOC" );
            string type = Console.ReadLine();
            AbstractHandler doc = null;
            switch (type)
            {
                case "XML":
                    {
                        doc = new XMLHandler();
                        break;
                    }
                case "TXT":
                    {
                        doc = new TXTHandler();
                        break;
                    }
                case "DOC":
                    {
                        doc = new DOCHandler();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Недопустимое значение!");
                        break;
                    }
            }
            doc.Open();
            doc.Create();
            doc.Change();
            doc.Save();
        }
    }
}
