using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Задание 4. Требуется:
    // Создать классы Point и Figure.
    // Класс Point должен содержать два целочисленных поля и одно строковое поле.
    // Создать три свойства с одним методом доступа get.
    // Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
    // Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
    // Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
    // void PerimeterCalculator(), который рассчитывает периметр многоугольника.
    // Написать программу, которая выводит на экран название и периметр многоугольника.
    /// </summary>
    class Program
    {
        /// <summary>
        /// метод выводит информация о созданной фигуре
        /// </summary>
        /// <param name="figure"></param>
        private static void ShowInformationFigure(Figure figure)
        {
            Console.WriteLine("Name: " + figure.Name + "\nPerimeter : " + figure.PerimeterCalculator());
            Console.WriteLine("\n-----------------------");
        }

        /// <summary>
        /// точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Figure figure1 = new Figure(new Point(0, 0, "1"),
                                        new Point(10, 0, "2"),
                                        new Point(0, 10, "3"));
            ShowInformationFigure(figure1);

            Figure figure2 = new Figure(new Point(0, 0, "1"),
                                        new Point(10, 22, "2"),
                                        new Point(2, 9, "3"),
                                        new Point(6, 7, "4"));
            ShowInformationFigure(figure2);

            Figure figure3 = new Figure(new Point(0, -3, "1"),
                                        new Point(-10, 22, "2"),
                                        new Point(2, 9, "3"),
                                        new Point(16, -2, "4"),
                                        new Point(1, 14, "5"));
            ShowInformationFigure(figure3);
            Console.ReadKey();
        }
    }
}
