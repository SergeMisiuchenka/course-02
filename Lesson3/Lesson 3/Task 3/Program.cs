using System;
//Создать класс Vehicle.  
//В теле класса создайте поля:  координаты и параметры средств передвижения (цена, скорость, год выпуска).  
//Создайте 3 производных класса Plane, Саг и Ship.  
//Для класса Plane должна быть определена высота и количество пассажиров.  
//Для класса Ship — количество пассажиров и порт приписки.  
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Корабль: ");
            Ship titanik = new Ship(1960, 22500, 30) {Passager = 500, Port =  "New York" };
            Console.WriteLine("Цена {0}, скорость {1}, год {2}, пассажиры {3}, порт {4} ",titanik.Price, titanik.Speed, titanik.Year, titanik.Passager, titanik.Port);

            Console.Write("Автомобиль: ");
            Car car = new Car(1960, 22500, 30);
            Console.WriteLine("Цена {0}, скорость {1}, год {2}", car.Price, car.Speed, car.Year);

            Console.Write("Самолет: ");
            Plane plane = new Plane(2000, 100000, 500) { Hight = 10000, Passage = 300 };
            Console.WriteLine("Цена {0}, скорость {1}, высота {3}, пассажиры {2} ",plane.Price, plane.Speed, plane.Hight, plane.Passage);
        }
    }
}
