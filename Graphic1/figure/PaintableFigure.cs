namespace Graphic1
{
    abstract class PaintableFigure
     {
        abstract protected double[,] points { get; set; }
        abstract protected int[,] matrix { get; }
        private Painter painter { get; set; }
        private Converter convert { get; set; }
        private Mover mover { get; set; }

        protected PaintableFigure(Converter _convert, Painter _painter, Mover _mover)
        {
            painter = _painter;
            convert = _convert;
            mover = _mover;
        }

        public void move(double dx, double dy)
        {
            points = mover.move(points, dx, dy); 
        }

        public void scale(double kx, double ky)
        {
            points = mover.scale(points, kx, ky);
        }

        public void rotate(int degree)
        {
            points = mover.rotate(points, degree);
        }

        public void paint()
        {
            painter.paint(points,matrix, convert);
        }
    }
}
