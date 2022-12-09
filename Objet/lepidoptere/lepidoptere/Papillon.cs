using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lepidoptere
{
    internal class Papillon : StadeEvolution
    {
        public override string SeDeplacer()
        {
            throw new NotImplementedException();
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return this;
        }
    }
}
