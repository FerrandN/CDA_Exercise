using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    [Serializable]
    public class DenominateurEgalAZeroException : Exception
    {
        public DenominateurEgalAZeroException(string message): base("Le denominateur est egal à 0") { }
        public DenominateurEgalAZeroException() { }
    }
}
