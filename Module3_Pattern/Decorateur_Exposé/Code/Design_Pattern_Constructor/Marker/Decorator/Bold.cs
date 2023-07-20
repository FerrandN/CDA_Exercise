using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Decorator
{
    public class Bold : Decorator
    {

        public Bold(Container objectToDecorate) : base(objectToDecorate)
        {

        }

        private string AddBold()
        {
            return " Gras";
        }

        private string AddMarkBold()
        {
            return "<b> " + this.Text + " </b>";
        }

        public override Container ChangeObject()
        {
            this.Font += this.AddBold();
            this.MarkedText = AddMarkBold();

            return this;
        }

    }
}
