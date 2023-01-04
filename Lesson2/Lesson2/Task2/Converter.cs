using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Converter
    {
        double usd, eur, rub, pln;
        public Converter(double usd, double eur, double pln)
        {
            this.eur = eur;
            this.usd = usd;
            this.pln = pln;
        }
        public void RubToUsd (double summ)
        {
            Console.WriteLine(summ / usd);
        }
        public void UsdToRub(double summ)
        {
            Console.WriteLine(summ * rub);
        }
        public void RubToEur(double summ)
        {
            Console.WriteLine(summ / eur);
        }
        public void EurToRub(double summ)
        {
            Console.WriteLine(summ * rub);
        }
        public void RubToPln(double summ)
        {
            Console.WriteLine(summ / pln);
        }
        public void PlnToRub(double summ)
        {
            Console.WriteLine(summ * pln);
        }
    }
}
