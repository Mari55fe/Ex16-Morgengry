using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Morgengry
{
    public class Course : IValuable
    {
        private string name;
        private int durationInMinutes;
        private double course = 825;
        public double CourseHourValue
        {
            get { return course; }
            set { course = value; }
        }

        public Course (string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }

        public Course(string name) : this(name, 0)
        {
        }
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Pris pr påbegyndt time: {CourseHourValue}";
        }

        public double GetValue()
        { 
            double hoursInitialized = Math.Ceiling(DurationInMinutes / 60.0); // en metode på hvordan man runder op 
            double price = hoursInitialized * CourseHourValue;
            return price;
        }
    }
}
