namespace Expression
{
    public abstract class Expression
    {
        public abstract int Evalue();
        public abstract string FormateDeGauche();

        public string Formate()
        {
            return this.FormateDeGauche() + " = " + this.Evalue();
        }
    }
}