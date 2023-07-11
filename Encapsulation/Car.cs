using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        public Car(string model)
        {
            this.Model = model;
        }

        public Car(int year)
        {
            this.Year = year;
        }
        private string model;
        private int year;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
    }

}
