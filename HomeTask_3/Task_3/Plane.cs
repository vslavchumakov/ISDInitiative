using System;

namespace Task_3
{
    class Plane : Vehicle
    {
        public Plane()
        {
            coordinates = new Coordinates(100, 100, 10000);
            price = 1000000;
            speed = 460;
            dateOfIssue = new DateTime(2000,12,31);
            passengersAmount = 235;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("_______________________________________");
        }
    }
}
