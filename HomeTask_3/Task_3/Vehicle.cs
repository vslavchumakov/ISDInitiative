using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    /*Создать класс Vehicle.
    В теле класса создайте поля: координаты и параметры средств передвижения(цена, скорость, год выпуска).
    Создайте 3 производных класса Plane, Саг и Ship.
    Для класса Plane должна быть определена высота и количество пассажиров.
    Для класса Ship — количество пассажиров и порт приписки.
    Написать программу, которая выводит на экран информацию о каждом средстве передвижения.*/
    class Vehicle
    {
        protected Coordinates coordinates;
        protected int price;
        protected int speed;
        protected DateTime dateOfIssue;
        protected int passengersAmount;

        public Vehicle()
        {
           
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Coordinates: x-{0}, y-{1}, z-{2}", coordinates.X, coordinates.Y, coordinates.Z);
            Console.WriteLine("Price: {0} $", price);
            Console.WriteLine("Date of issue: {0}", dateOfIssue);
            Console.WriteLine("Passengers amount: {0}", passengersAmount);
        }
    }
}
