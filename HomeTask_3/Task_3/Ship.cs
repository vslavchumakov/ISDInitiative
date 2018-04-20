using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Ship : Vehicle
    {
        private string portOfRegistration;

        public Ship()
        {
            coordinates = new Coordinates(100, 100, 100);
            price = 10000000;
            speed = 15000;
            dateOfIssue = new DateTime(2000, 12, 31);
            passengersAmount = 1000;
            portOfRegistration = "Guam";
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Speed: {0} kn", speed);
            Console.WriteLine("Port of registration: {0}", portOfRegistration);
            Console.WriteLine("_______________________________________");
        }
    }
}
