using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    internal class Tire
    {
        int angle;
        bool isRolling;
        int rotationPerMinute;
        int size;
        int speed;
        int wear;

        public int BorrowingRates(int _wear)
        {
            return _wear;
        }

        public int Turn(int _angle)
        {
            return _angle;
        }
    }
}
