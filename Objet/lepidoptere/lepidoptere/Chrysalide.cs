using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lepidoptere
{
    internal class Chrysalide : StadeEvolution
    {
        public Chrysalide()
        {

        }

        public override string SeDeplacer()
        {
            return "";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
