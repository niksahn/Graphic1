using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Graphic1.painter.PainterProect;

namespace Graphic1.painter
{
    internal class PainterProect: Painter
    {
        Graphics graphics { get; }

        public PainterProect(Graphics g) : base()
        {
            graphics = g;
        }

        override public void paint(double[,] points, int[,] matrix, Converter converter, Poligon[] poligons,Proect proect = Proect.XOY)
        {
            var proector = new Proector().proect(points, proect);
            var convertedCoordinates = converter.convertToWindow(proector);
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        switch (proect)
                        {
                            case Proect.YOZ:
                                {
                                    drawLine((int)convertedCoordinates[i, 1], (int)convertedCoordinates[i, 2], (int)convertedCoordinates[j, 1], (int)convertedCoordinates[j, 2]);
                                    break;
                                }
                            case Proect.XOZ:
                                {
                                    drawLine((int)convertedCoordinates[i, 0], (int)convertedCoordinates[i, 2], (int)convertedCoordinates[j, 0], (int)convertedCoordinates[j, 2]);
                                    break;
                                }
                            case Proect.XOY:
                                {
                                    drawLine((int)convertedCoordinates[i, 0], (int)convertedCoordinates[i, 1], (int)convertedCoordinates[j, 0], (int)convertedCoordinates[j, 1]);
                                    break;
                                }
                        }
                    }
                }
            }
        }

        protected override void drawLine(int x0, int y0, int x1, int y1)
        {
            Pen gPen = new Pen(Color.Blue, 1);
            graphics.DrawLine(gPen, new Point(x0, y0), new Point(x1, y1));
        }
        public enum Proect
        {
            XOY,YOZ,XOZ
        }
    }

    internal class Proector
    {
        protected Matrix<double> getMatrix(double[,] matrix)
        {
            return Matrix<double>.Build.DenseOfArray(matrix);
        }
        public double[,] proect(double[,] points, Proect p)
        {
            var m = getMatrix(points);
            Matrix<double> mm = getMatrix(new double[1,0]);
            switch (p)
            {
                case Proect.YOZ:
                    {
                        mm = getYOZMatrix();
                        break;
                    }
                case Proect.XOZ:
                    {
                        mm = getXOZMatrix();
                        break;
                    }
                case Proect.XOY:
                    {
                        mm = getXOYMatrix();
                        break;
                    }
            };
            var mmm = m.Multiply(mm);
            var mmmm = mmm.ToArray();
            return mmmm;
        }

        public Matrix<double> getXOYMatrix()
        {
            return getMatrix(
                new double[,] {
                { 1.0, 0.0, 0.0, 0.0 }, 
                { 0.0, 1.0, 0.0, 0.0 }, 
                { 0.0, 0.0, 0.0, 0.0 }, 
                { 0.0, 0.0, 0.0, 1.0 } 
            });
        }

        public Matrix<double> getYOZMatrix()
        {
            return getMatrix(
            new double[,] {
                { 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 1.0, 0.0, 0.0 },
                { 0.0, 0.0, 1.0, 0.0 },
                { 0.0, 0.0, 0.0, 1.0 }
            });
        }

        public Matrix<double> getXOZMatrix()
        {
            return getMatrix(
            new double[,] {
                { 1.0, 0.0, 0.0, 0.0 },
                { 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 0.0, 1.0, 0.0 },
                { 0.0, 0.0, 0.0, 1.0 }
            });
        }
    }
}
