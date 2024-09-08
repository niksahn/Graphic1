using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic1
{
    internal class Mover2d : Mover
    {
        override protected Matrix<double> getMoveMatrix(double dx, double dy)
        {
            return getMatrix(new double[,] { { 1.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0 }, { dx, dy, 1.0 } });
        }

        override protected Matrix<double> getScaleMatrix(double kx, double ky)
        {
            return getMatrix(new double[,] { { kx, 0.0, 0.0 }, { 0.0, ky, 0.0 }, { 0.0, 0.0, 1.0 } });
        }

        override protected Matrix<double> getRotateMatrix(double degree)
        {
            return getMatrix(new double[,] { { Math.Cos(degree), -Math.Sin(degree), 0.0 }, { Math.Sin(degree), Math.Cos(degree), 0.0 }, { 0.0, 0.0, 1.0 } });
        }
    }
}
