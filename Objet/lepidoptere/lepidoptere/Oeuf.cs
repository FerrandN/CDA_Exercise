using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lepidoptere
{
    internal class Oeuf : StadeEvolution
    {
        public Oeuf()
        {

        }

        public override string SeDeplacer()
        {
            return "";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
