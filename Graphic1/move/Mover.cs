using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic1
{
    internal abstract class Mover
    {
        protected Matrix<double> getMatrix(double[,] matrix)
        {
            return Matrix<double>.Build.DenseOfArray(matrix);
        }

        abstract protected Matrix<double> getMoveMatrix(double dx, double dy);
        abstract protected Matrix<double> getScaleMatrix(double kx, double ky);
        abstract protected Matrix<double> getRotateMatrix(int degree);

         public double[,] move(double[,] points, double dx, double dy)
         {
            return getMatrix(points).Multiply(getMoveMatrix(dx, dy)).AsArray();
         }

        public double[,] scale(double[,] points, double kx, double ky)
        {
            return  getMatrix(points).Multiply(getScaleMatrix(kx, ky)).AsArray();
        }

       public double[,] rotate(double[,] points, int degree)
        {        
            return getMatrix(points).Multiply(getRotateMatrix(degree)).AsArray();
        }
    }
}
