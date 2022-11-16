using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet_bouteille
{
    internal class bouteille
    {
        public bool isOpen = true;
        public bool isEmpty;
        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }

        public bool IsEmpty
        {
            get { return isEmpty; }
            set { isEmpty = value; }
        }
    }
}
