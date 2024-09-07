﻿using MathNet.Numerics.LinearAlgebra;
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
            var m = getMatrix(points);
            var mm = getMoveMatrix(dx, dy);
            var mmm = m.Multiply(mm);
            var mmmm = mmm.ToArray();
            return mmmm;
         }

        public double[,] scale(double[,] points, double kx, double ky)
        {
            return  getMatrix(points).Multiply(getScaleMatrix(kx, ky)).ToArray();
        }

       public double[,] rotate(double[,] points, int degree, double dx0,double dy0)
       {
            var smesh = new double[] { -dx0, -dy0 };
            if (smesh[0] != 0 || smesh[1] != 0)
            {
                return getMatrix(points)
                                .Multiply(getMoveMatrix(smesh[0], smesh[1]))
                                .Multiply(getRotateMatrix(degree))
                                .Multiply(getMoveMatrix(-smesh[0], -smesh[1]))
                                .ToArray();
            }
            else
            {
                return getMatrix(points).Multiply(getRotateMatrix(degree)).ToArray();
            }
        }
    }
}
