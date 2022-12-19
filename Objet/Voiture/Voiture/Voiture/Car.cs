using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    internal class Car
    {
        int axle;
        int speed;
        Tire[] hisTire = new Tire[4];

        public Car()
        {

        }

        public Car(Tire[] _hisTire)
        {
            hisTire = _hisTire;
        }

        public int ChangeTire(int _tire)
        {
            return _tire;
        }

        public int Roll(bool _isRolling, bool _isOn)
        {
            int wear = 0;
            return wear;
        }

        public bool switchStartStop(bool isOn)
        {
            return isOn;
        }

        public bool VerifyAllAxleGotTire()
        {
            return true;
        }
    }
}
