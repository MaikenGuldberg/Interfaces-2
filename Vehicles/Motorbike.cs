using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class MotorBike
    {
        private IEngine _engine = null;
        public MotorBike(IEngine engine)
        {
            _engine = engine;
        }
        public void RunAtHalfSpeed()
        {
            _engine.SetThrottle(_engine.MaxThrottle / 2);
            Console.WriteLine("Canged to half speed");
        }

        public uint CurrentSpeed()
        {
            return _engine.GetThrottle();
        }

        public void SetSpeed(uint speed)
        {
            _engine.SetThrottle(speed < _engine.MaxThrottle ? speed : _engine.MaxThrottle);
        }
    }
}
