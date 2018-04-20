using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Employee
    {
        public double taxRateMultyply = 0.18;
        public double experienceRateMultyplay = 0.1;

        private string firstName;
        private string lastName;

        private double salary;
        private string position;
        private int experience;
        private double experienceRate;
        private double taxCharge;

        private double positionRate;

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = GetSalary();
                salary = value;
            }
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private double GetExperienceRate()
        {
            if (experience == 0)
            {
                experienceRate = 1;
                return experienceRate;
            }
            else
            {
                experienceRate = experience * experienceRateMultyplay;
                return experienceRate;
            }
        }

        private double GetPositionRate()
        {
            switch (position)
            {
                case "Cleaner":
                    positionRate = 1000;
                    break;
                case "Security":
                    positionRate = 2000;
                    break;
                case "Nurs":
                    positionRate = 3000;
                    break;
            }
            return positionRate;
        }

        private double GetTaxCharge()
        {
            taxCharge = (experienceRate * positionRate + positionRate) * taxRateMultyply;
            return taxCharge;
        }

        private double GetSalary()
        {
            positionRate = GetPositionRate();
            experienceRate = GetExperienceRate();
            taxCharge = GetTaxCharge();
            salary = (experienceRate * positionRate + positionRate) - taxCharge;
            return salary;
        }

        public void GetInfo()
        {
            GetSalary();
            Console.WriteLine("Firstname:{0}", firstName);
            Console.WriteLine("Lastname:{0}", lastName);
            Console.WriteLine("Position:{0}", position);
            Console.WriteLine("Salary:{0}", salary);
            Console.WriteLine("TaxCharge:{0}", taxCharge);
            Console.WriteLine("_____________________");
        }
    }
}
