using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Graphic1
{
    internal abstract class Mover
    {
        double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
        protected Matrix<double> getMatrix(double[,] matrix)
        {
            return Matrix<double>.Build.DenseOfArray(matrix);
        }

        abstract protected Matrix<double> getMoveMatrix(double dx, double dy, double dz);
        abstract protected Matrix<double> getScaleMatrix(double kx, double ky, double kz);
        abstract protected Matrix<double> getRotateMatrixZ(double angle);
        abstract protected Matrix<double> getRotateMatrixY(double angle);
        abstract protected Matrix<double> getRotateMatrixX(double angle);

        public double[,] move(double[,] points, double dx, double dy, double dz)
         {
            var m = getMatrix(points);
            var mm = getMoveMatrix(dx, dy, dz);
            var mmm = m.Multiply(mm);
            var mmmm = mmm.ToArray();
            return mmmm;
         }

        public double[,] scale(double[,] points, double kx, double ky, double kz, double dx0, double dy0, double dz0)
        {
            var smesh = new double[] { -dx0, -dy0, -dz0 };
            if (smesh[0] != 0 || smesh[1] != 0) {
                return 
                   getMatrix(points)
                   .Multiply(getMoveMatrix(smesh[0], smesh[1], smesh[2]))
                    .Multiply(getScaleMatrix(kx, ky, kz))
                   .Multiply(getMoveMatrix(-smesh[0], -smesh[1], -smesh[2]))
                    .ToArray();
            }
            return getScaleMatrix(kx, ky, kz).Multiply(getMatrix(points).Transpose()).Transpose().ToArray();
        }

       public double[,] rotateZ(double[,] points, int degree, double dx0,double dy0, double dz0)
       {
            var smesh = new double[] { -dx0, -dy0, -dz0 };
            var angle = DegreesToRadians(degree);
            if (smesh[0] != 0 || smesh[1] != 0)
            {
                return getMatrix(points)
                                .Multiply(getMoveMatrix(smesh[0], smesh[1], smesh[2]))
                                .Multiply(getRotateMatrixZ(angle))
                                .Multiply(getMoveMatrix(-smesh[0], -smesh[1], -smesh[2]))
                                .ToArray();
            }
            else
            {
                return getMatrix(points).Multiply(getRotateMatrixZ(angle)).ToArray();
            }
        }

        public double[,] rotateY(double[,] points, int degree, double dx0, double dy0, double dz0)
        {
            var smesh = new double[] { -dx0, -dy0, -dz0 };
            var angle = DegreesToRadians(degree);
            if (smesh[0] != 0 || smesh[1] != 0)
            {
                return getMatrix(points)
                                .Multiply(getMoveMatrix(smesh[0], smesh[1], smesh[2]))
                                .Multiply(getRotateMatrixY(angle))
                                .Multiply(getMoveMatrix(-smesh[0], -smesh[1], -smesh[2]))
                                .ToArray();
            }
            else
            {
                return getMatrix(points).Multiply(getRotateMatrixY(angle)).ToArray();
            }
        }

        public double[,] rotateX(double[,] points, int degree, double dx0, double dy0, double dz0)
        {
            var smesh = new double[] { -dx0, -dy0, -dz0 };
            var angle = DegreesToRadians(degree);
            if (smesh[0] != 0 || smesh[1] != 0)
            {
                return getMatrix(points)
                                .Multiply(getMoveMatrix(smesh[0], smesh[1], smesh[2]))
                                .Multiply(getRotateMatrixX(angle))
                                .Multiply(getMoveMatrix(-smesh[0], -smesh[1], -smesh[2]))
                                .ToArray();
            }
            else
            {
                return getMatrix(points).Multiply(getRotateMatrixX(angle)).ToArray();
            }
        }

    }
}
