using System;
//Создать класс Converter. 
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и инициализирует поля соответствующие курсу 3-х основных валют,
//по отношению к гривне - public Converter(double usd, double eur, double rub). Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в гривну. 

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в конвертер!");
            Console.WriteLine("Введите курсы валют: ");
            Console.Write("Usd = ");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Eur = ");
            double eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Pln = ");
            double pln = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            Converter converter = new Converter(usd, eur, pln);
            Console.WriteLine("Выберите тип валюты: ");
            Console.WriteLine("1. Rub to Usd ");
            Console.WriteLine("2. Usd to Rub ");
            Console.WriteLine("3. Rub to Eur ");
            Console.WriteLine("4. Eur to Rub ");
            Console.WriteLine("5. Rub to Pln ");
            Console.WriteLine("6. Pln to Rub ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.WriteLine("Введите количество валюты в рублях для обмена: ");
                    double summRubUsd = Convert.ToDouble(Console.ReadLine());
                    converter.RubToUsd(summRubUsd);
                    break;
                case "2":
                    Console.WriteLine("Введите количество валюты в долларах для обмена: ");
                    double summUsdRub = Convert.ToDouble(Console.ReadLine());
                    converter.UsdToRub(summUsdRub);
                    break;
                case "3":
                    Console.WriteLine("Введите количество валюты в рублях для обмена: ");
                    double summRubEur = Convert.ToDouble(Console.ReadLine());
                    converter.RubToEur(summRubEur);
                    break;
                case "4":
                    Console.WriteLine("Введите количество валюты в евро для обмена: ");
                    double summEurRub = Convert.ToDouble(Console.ReadLine());
                    converter.EurToRub(summEurRub);
                    break;
                case "5":
                    Console.WriteLine("Введите количество валюты в рублях для обмена: ");
                    double summRubPln = Convert.ToDouble(Console.ReadLine());
                    converter.RubToPln(summRubPln);
                    break;
                case "6":
                    Console.WriteLine("Введите количество валюты в злотых для обмена: ");
                    double summPlnRub = Convert.ToDouble(Console.ReadLine());
                    converter.PlnToRub(summPlnRub);
                    break;
            }
        }
    }
}
