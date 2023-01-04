using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Vehicle
    {
        readonly int pointX, pointY, year, price, speed;
        public int PointX
        {
            get
            {
                return pointX;
            }
        }
        public int PointY
        {
            get
            {
                return pointY;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
        }
        public Vehicle(int pointX, int pointY, int year, int price, int speed)
        {
            this.pointX = pointX;
            this.pointY = pointY;
            this.year = year;
            this.price = price;
            this.speed = speed;
        }
        public Vehicle(int year, int price, int speed)
            : this(0, 0, year, price, speed)
        {
        }
    }
    class Ship : Vehicle
    {
        public Ship(int pointX, int pointY, int year, int price, int speed)
            : base (pointX, pointY, year, price, speed)
        {
        }
        public Ship(int year, int price, int speed)
           : base(year, price, speed)
        {
        }
        private int passager;
        public int Passager
        {
            get
            {
                return passager;
            }
            set
            {
                if (passager < 0)
                {
                    Console.WriteLine("Пассажиров нет на корабле");
                }
                else
                {
                    passager = value;
                }
            }
        }
        private string port;
        public string Port
        {
            get
            {
                if (port == null)
                {
                    Console.WriteLine("Порт не задан");
                }
                return port;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Укажите порт");
                }
                else
                {
                    port = value;
                }
            }
        }
    }
    class Plane : Vehicle
    {
        public Plane(int pointX, int pointY, int year, int price, int speed)
            : base(pointX, pointY, year, price, speed)
        {
        }
        public Plane(int year, int price, int speed)
            : base (year, price, speed)
        {
        }
        public int Hight
        { get; set; }

        private int passager;
        public int Passage
        {
            get
            {
                return passager;
            }
            set
            {
                if (passager < 0)
                {
                    Console.WriteLine("Пассажиров нет на самолете");
                }
                else
                {
                    passager = value;
                }
            }
        }
    }
    class Car : Vehicle
    {
        public Car(int pointX, int pointY, int year, int price, int speed)
            : base(pointX, pointY, year, price, speed)
        {
        }
        public Car(int year, int price, int speed)
            : base(year, price, speed)
        {
        }
    }
}
