using static Graphic1.painter.PainterProect;

namespace Graphic1
{
    public struct Poligon
    {
        public int V1, V2, V3;

        public Color Color;
        public Poligon(int v1, int v2, int v3, Color color)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            Color = color;
        }
    }
    abstract class PaintableFigure
     {
        abstract protected double[,] points { get; set; }
        abstract protected int[,] matrix { get; }
        private Painter painter { get; set; }
        private Converter convert { get; set; }
        private Mover mover { get; set; }

        abstract protected Poligon[] poligons { get; }

        private double[] center =  { 0.0, 0.0, 0.0 };

            protected PaintableFigure(Converter _convert, Painter _painter, Mover _mover)
        {
            painter = _painter;
            convert = _convert;
            mover = _mover;
        }

        public void move(double dx, double dy, double dz)
        {
            points = mover.move(points, dx, dy, dz);
            center = new double[] { center[0] + dx, center[1] + dy, center[2] + dz };
        }

        public void scale(double kx, double ky, double kz)
        {
            points = mover.scale(points, kx, ky, kz, center[0], center[1], center[2]);
        }

        public void rotateZ(int degree)
        {
            points = mover.rotateZ(points, degree, center[0], center[1], center[2]);
        }

        public void rotateY(int degree)
        {
            points = mover.rotateY(points, degree, center[0], center[1], center[2]);
        }

        public void rotateX(int degree)
        {
            points = mover.rotateX(points, degree, center[0], center[1], center[2]);
        }

        public void paint(Proect p = Proect.XOY)
        {
            painter.paint(points,matrix, convert,poligons ,p);
            var coords = convert.convertToWindow(points);
        }
    }
}
