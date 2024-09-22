using System;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrEmpty(_firstName))
                {
                    _firstName = "Unknown";
                } else
                {
                    _firstName = value;
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(_lastName))
                {
                    _lastName = "Unknown";
                } else
                {
                    _lastName = value;
                }
            }
        }
        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value > 0.0)
                {
                    _monthlySalary = value;
                }
            }
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                _firstName = "Unknown";
            }
            else
            {
                _firstName = firstName;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                _lastName = "Unknown";
            }
            else
            {
                _lastName = lastName;
            }
            if (monthlySalary > 0)
            {
                _monthlySalary = monthlySalary;
            } else
            {
                _monthlySalary = 0.0;
            }
        }

        public double RaiseSalary(int raisePercentage)
        {
            if(raisePercentage > 0 && raisePercentage <= 20)
            {
                _monthlySalary += (_monthlySalary * raisePercentage / 100);
                return 0;
            }
            return 1;
        }

        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}
