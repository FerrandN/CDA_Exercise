using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lepidoptere
{
    internal class Chenille : StadeEvolution
    {
        public Chenille()
        {

        }

        public string SeDeplacer()
        {
            return "";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
