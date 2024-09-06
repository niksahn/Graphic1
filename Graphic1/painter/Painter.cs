using System.Drawing;

namespace Graphic1
{
    abstract class Painter
    {
        public void paint(double[,] points, int[,] matrix, Converter converter) {
            var convertedCoordinates = converter.convertToWindow(points);
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 1) drawLine((int)convertedCoordinates[i, 0], (int)convertedCoordinates[i, 1], (int)convertedCoordinates[j, 0], (int)convertedCoordinates[j, 1]);
                }
            }
        }

        protected abstract void drawLine(int x0,int y0, int x1, int y1);
    }
}
