using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Decorator
{
    public class Italic : Decorator
    {
        public Italic(Container objectToDecorate) : base(objectToDecorate)
        {

        }

        private string AddItalic()
        {
            return " Italic";
        }

        private string AddMarkItalic()
        {
            return "<i> " + this.Text + " </i>";
        }

        public override Container ChangeObject()
        {
            this.Font += this.AddItalic();
            this.MarkedText = AddMarkItalic();

            return this;
        }
    }
}
