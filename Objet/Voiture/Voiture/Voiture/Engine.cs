using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    internal class Engine
    {
        bool isOn;
        public bool switchStartStop()
        {
            isOn = !isOn;
            return isOn;
        }
    }
}
