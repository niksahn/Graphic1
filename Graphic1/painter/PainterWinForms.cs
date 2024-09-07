using System.Drawing;

namespace Graphic1
{
    internal class PainterWinForms : Painter
    {
        Graphics graphics { get; }
        public PainterWinForms(Graphics g): base()
        {
            graphics = g;
        }

        protected override void drawLine(int x0, int y0, int x1, int y1)
        {
            Pen gPen = new Pen(Color.Blue, 1);
            graphics.DrawLine(gPen, new Point(x0, y0), new Point(x1, y1));
        }
    }
}
