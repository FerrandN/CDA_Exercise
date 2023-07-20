namespace FormeFigure
{
    public abstract class Figure
    {

        protected double x;
        protected double y;

        public Figure(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public abstract void SeDessiner();
    }
}