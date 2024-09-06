using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic1
{
    internal class Converter
    {
        const double pointSize = 40.0;
        public double x0 = 0;
        public double y0 = 0;
       
        public Converter( double _x0, double _y0) {
            x0 = _x0;
            y0 = _y0;
        }

        public double[,] convertToWindow(double[,] points){
            int rows = points.GetLength(0);
            int columns = points.GetLength(1);
            double[,] convertedPoints = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0) 
                    { 
                        convertedPoints[i, j] = x0 + points[i, j] * pointSize;
                    }
                    else
                    {
                        convertedPoints[i, j] = y0 - points[i, j] * pointSize;
                   };
                   
                }
            }

            return convertedPoints;
        }
    }
}
