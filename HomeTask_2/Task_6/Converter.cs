using System;
namespace Task_6
{
    internal class Converter
    {
        // Fields of class Converter
        double usd, eur, rub;

        /// <summary>
        /// User constructor
        /// </summary>
        /// <param name="usd"></param>
        /// <param name="eur"></param>
        /// <param name="rub"></param>
        public Converter(double usd, double eur, double rub)
        {
            // Initialize fields of class
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        /// <summary>
        /// Method of converting money -> UAH
        /// </summary>
        /// <param name="eurSum"></param>
        /// <param name="rubSum"></param>
        /// <param name="usdSum"></param>
        public void ConvertToUAH(double usdSum = 0, double rubSum=0, double eurSum = 0)
        {
            if (eurSum + rubSum == 0) Console.WriteLine($"{usdSum} USD = {usdSum * usd} UAH");
            if (eurSum + usdSum == 0) Console.WriteLine($"{rubSum} RUB = {rubSum * rub} UAH");
            if (rubSum + usdSum == 0) Console.WriteLine($"{eurSum} EUR = {eurSum * eur} UAH");
        }

        /// <summary>
        /// Method of converting money from UAH to USD, EUR or RUB
        /// </summary>
        /// <param name="uahSum"></param>
        /// <param name="toUsd"></param>
        /// <param name="toEur"></param>
        /// <param name="toRub"></param>
        public void ConvertFromUAH(double uahSum, bool toUsd=true, bool toEur=false, bool toRub=false)
        {
            if (!(toUsd | toEur)) Console.WriteLine($"{uahSum} UAH = {uahSum / rub} RUB");
            if (!(toUsd | toRub)) Console.WriteLine($"{uahSum} UAH = {uahSum / eur} EUR");
            if (!(toRub | toEur)) Console.WriteLine($"{uahSum} UAH = {uahSum / usd} USD");
        }
    }
}