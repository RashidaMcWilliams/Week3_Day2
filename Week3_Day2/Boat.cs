using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2
{
    class Boat
    {
        public int numberOfPassengers;

        private string name;
        private double engineSize;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public Boat()
        {

        }

        public Boat (int numberOfPassengers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }

        public void Move()
        {
            Console.WriteLine(name + " moves forward.");
        }

        private double CalculateMPG()
        {
            //code to calculate the MPG
            double MPG = engineSize * 2.73d;
            return MPG;
        }

        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine size: " + engineSize);
            Console.WriteLine("MPG: " + CalculateMPG());
            Console.WriteLine();
        }
    }
}
