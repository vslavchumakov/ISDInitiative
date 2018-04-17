using System;
namespace Task_6
{
    class Program
    {
        #region Hometask_02_6
        //
        // Author: Shemet Viktoriya
        //
        // Description: 
        // Required: Create a class called Converter.
        // In the body of the class, create user constructor which takes three double arguments,
        // and initializes the fields corresponding to the rate of 3 major currencies,
        // in relation to the hryvnia - public converter (double usd, double eur, double rub).
        // Write a program that will perform the conversion from the hryvnia to one of 
        // these currencies, and the program must convert from the specified currencies to the hryvnia.
        //
        #endregion

        static void Main(string[] args)
        {
            Converter converter = new Converter(26.2, 32.45, 0.42); // current exchange rate

            // Calling the conversion method USD -> UAH
            converter.ConvertToUAH(1000);

            // Calling the conversion method  UAH -> USD
            converter.ConvertFromUAH(10000);

            // Delay
            Console.ReadKey();
        }
    }
}
