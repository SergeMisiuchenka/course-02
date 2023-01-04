using System;
//Создать класс, представляющий учебный класс ClassRoom.  
//Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil  от класса базового класса Pupil и переопределите 
//каждый из методов, в зависимости от успеваемости ученика.   
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.  
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.  

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Pupil p1 = new BadPupil();
            Pupil p2 = new ExcelentPupil();
            Pupil p3 = new GoodPupil();
            Pupil p4 = new BadPupil();

            ClassRoom students = new ClassRoom(p1, p2, p3, p4);
            students.Relax();
            Console.WriteLine("-------------");
            students.Read();
            Console.WriteLine("-------------");
            students.Write();
            Console.WriteLine("-------------");
            students.Study();
            Console.WriteLine("-------------");
        }
    }
}
