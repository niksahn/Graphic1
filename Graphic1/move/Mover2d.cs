using MathNet.Numerics.LinearAlgebra;

namespace Graphic1
{
    internal class Mover2d : Mover
    {
        override protected Matrix<double> getMoveMatrix(double dx, double dy, double dz)
        {
            return getMatrix(new double[,] { { 1.0, 0.0, 0.0, 0.0 }, { 0.0, 1.0, 0.0, 0.0 }, { 0.0, 0.0, 1.0, 0.0 }, { dx, dy, dz, 1.0 } });
        }

        override protected Matrix<double> getScaleMatrix(double kx, double ky, double kz)
        {
            return getMatrix(new double[,] { { kx, 0.0, 0.0, 0.0 }, { 0.0, ky, 0.0, 0.0 }, { 0.0, 0.0, kz, 0.0 },  { 0.0, 0.0, 0.0, 1.0 } });
        }

        override protected Matrix<double> getRotateMatrixZ(double degree)
        {
            return getMatrix(new double[,] { { Math.Cos(degree), -Math.Sin(degree), 0.0, 0.0 }, 
                { Math.Sin(degree), Math.Cos(degree), 0.0, 0.0 }, 
                { 0.0, 0.0, 1.0, 0.0 },
            { 0.0, 0.0, 0.0, 1.0} });
        }
        override protected Matrix<double> getRotateMatrixY(double degree)
        {
            return getMatrix(new double[,] { { Math.Cos(degree), 0.0, Math.Sin(degree), 0.0 },
                { 0.0, 1.0, 0.0, 0.0 },
                { -Math.Sin(degree), 0.0, Math.Cos(degree), 0.0 }, 
            {0.0, 0.0, 0.0, 1.0 } });
        }
        override protected Matrix<double> getRotateMatrixX(double degree)
        {
            return getMatrix(new double[,] {{1.0, 0.0, 0.0, 0.0 },
                {0.0, Math.Cos(degree), -Math.Sin(degree), 0.0 }, 
                {0.0, Math.Sin(degree), Math.Cos(degree), 0.0 }, 
                {0.0, 0.0, 0.0, 1.0 } });
        }
    }
}
