using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaourts
{
    internal class Yaourt
    {
        public string poll
        {
            get;set;
        }
        
        public int votes { get; set; }
        public string[] results { get; set; }
    }
}
