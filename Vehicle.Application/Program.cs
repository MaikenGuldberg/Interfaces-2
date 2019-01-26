using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Vehicle.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorBike myBike = new MotorBike(new GasEngine(100));
            myBike.SetSpeed(90);
            Console.WriteLine("Current speed is: " + myBike.CurrentSpeed().ToString());
            myBike.RunAtHalfSpeed();
            Console.WriteLine("Current speed is: " + myBike.CurrentSpeed().ToString());
            Console.ReadLine();
        }
    }
}
