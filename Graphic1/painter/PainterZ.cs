﻿using Graphic1;
using Graphic1.painter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphic1
{
    internal class PainterZ : Painter
    {
        Graphics graphics { get; }

        public PainterZ(Graphics g) : base()
        {
            graphics = g;
        }
        override public void paint(double[,] points, int[,] matrix, Converter converter, Poligon[] poligons, PainterProect.Proect p = PainterProect.Proect.XOZ)
        {
            var convertedCoordinates = converter.convertToWindow(points);
            var width = FindMinValueInFirstColumn(convertedCoordinates);
            var height = FindMaxValueInSecondColumn(convertedCoordinates);
            var pixels = TriangleRasterizer.rasterize(convertedCoordinates, poligons);
            var buffer = new ZBuffer((int) width+500,(int)height+500);
            // var buffer = new ZBuffer((int)FindHeight(convertedCoordinates)+1000,(int)FindWidth(convertedCoordinates) + 1000);
            pixels = buffer.Render(pixels);
            using (var pixel = new Bitmap((int) width+2000,(int) height+2000, graphics))
            {
                pixels.ForEach(x => { pixel.SetPixel((int)x.Item1, (int)x.Item2, x.Item4); });
                graphics.DrawImage(pixel,0, 0);
            };
          }
        protected override void drawLine(int x0, int y0, int x1, int y1)
        {
            
        }

        static double FindMinValueInFirstColumn(double[,] array)
        {
            // Предполагаем, что хотя бы одна строка существует
            double max = Double.MinValue;
            double min = Double.MaxValue;

            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[i, 0] > max)
                {
                    max = array[i, 0];
                }
                if (array[i, 0] < min)
                {
                    min = array[i, 1];
                }
            }

            return max - min;
        }


        static double FindMaxValueInSecondColumn(double[,] array)
        {
            // Предполагаем, что хотя бы одна строка существует
            double max = Double.MinValue;
            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[i, 1] > max)
                {
                    max = array[i, 1];
                }
            
            }

            return max;
        }
    }

    internal class ZBuffer
    {
        int[,] zBuffer;
        Color [,] frameBuffer;
        public ZBuffer(int width, int height)
        {
            zBuffer = new int[width,height];
            frameBuffer = new Color[width,height];
            Clear(width,height);
        }

        public void Clear(int width, int height)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    zBuffer[x, y] = int.MaxValue;
                    frameBuffer[x, y] = Color.White;
                }
            }
        }

        public List<(int, int, int, Color)> Render(List<(int,int,int, Color)> pixels)
        {
            List<(int, int, int, Color)> rezult = new List<(int, int, int, Color)>();
            pixels.ForEach(x => { RenderPixel(x.Item1,x.Item2,x.Item3, x.Item4); });
            for(int i = 0; i < frameBuffer.GetLength(0); i++)
            {
                for(int j = 0; j < frameBuffer.GetLength(1); j++)
                {
                    rezult.Add((i, j, 0, frameBuffer[i,j]));
                }
            }
            return rezult;
        }

        public void RenderPixel(int x, int y, int z, Color c)
        {
            if (z < zBuffer[x, y])
            {
               
                zBuffer[x, y] = z;
                frameBuffer[x, y] = c;
            }
        }
    }
 }


public static class TriangleRasterizer
{
    static Vector3 CalculateNormal(Vector3 v0, Vector3 v1, Vector3 v2)
    {
        Vector3 edge1 = v1 - v0;
        Vector3 edge2 = v2 - v0;
        Vector3 normal = Vector3.Cross(edge1, edge2);

        // Корректируем направление вектора
        if (normal.Z < 0)
        {
            normal = -normal;
        }
        return  Vector3.Normalize(normal);
    }

    public static Vector3 CalculateLighting(Vector3 normal, Vector3 lightPos, Vector3 viewPos,
                                       Vector3 vertexPos, Vector3 ambientColor, Vector3 lightColor,
                                       float k_a, float k_d, float k_s, float shininess)
    {
        // Фоновое освещение
        Vector3 ambient = k_a * ambientColor;

        // Диффузное освещение
        Vector3 lightDir = Vector3.Normalize(lightPos - vertexPos);
        float diff = Math.Max(Vector3.Dot(normal, lightDir), 0.0f);
        Vector3 diffuse = k_d * diff * lightColor;

        // Зеркальное освещение
        Vector3 viewDir = Vector3.Normalize(viewPos - vertexPos);
        Vector3 reflectDir = Vector3.Reflect(-lightDir, normal);
        float spec = (float)Math.Pow(Math.Max(Vector3.Dot(viewDir, reflectDir), 0.0f), shininess);
        Vector3 specular = k_s * spec * lightColor;

        // Итоговое освещение
        Vector3 finalColor = ambient + diffuse + specular;
        return finalColor;
    }

    private static Vector3 vector((int, int, int) v)
    {
        return new Vector3(v.Item1, v.Item2, v.Item3);
    }

    public static List<(int, int, int, Color)> rasterize(double[,] points, Poligon[] poligons)
    {
        List<(int, int, int, Color)> pixels = new List<(int, int, int, Color)>();

        foreach (Poligon p in poligons)
        {
            try
            {
                var v1 = ((int)points[p.V1, 0], (int)points[p.V1, 1], (int)points[p.V1, 2]);
                var v2 = ((int)points[p.V2, 0], (int)points[p.V2, 1], (int)points[p.V2, 2]);
                var v3 = ((int)points[p.V3, 0], (int)points[p.V3, 1], (int)points[p.V3, 2]);
                pixels.AddRange(Rasterize(v1.Item1, v1.Item2, v1.Item3, v2.Item1, v2.Item2, v2.Item3, v3.Item1, v3.Item2, v3.Item3, p.Color));
            }
            catch (Exception ex) { }
        }
        return pixels;
    }


    public static List<(int x, int y, int z, Color c)> Rasterize(int x0, int y0, int z0, int x1, int y1, int z1, int x2, int y2, int z2, Color color0)
    {
        var points = new List<(int x, int y, int z, Color)>();

        // Упорядочиваем точки по y-координатам
        if (y1 < y0) { Swap(ref x0, ref y0, ref z0, ref x1, ref y1, ref z1); }
        if (y2 < y0) { Swap(ref x0, ref y0, ref z0, ref x2, ref y2, ref z2); }
        if (y2 < y1) { Swap(ref x1, ref y1, ref z1, ref x2, ref y2, ref z2); }

        Vector3 normal = CalculateNormal(new Vector3(x0, y0, z0), new Vector3(x1, y1, z1), new Vector3(x2, y2, z2));

        // Вычисляем градиенты
        float dx1 = (y1 - y0) > 0 ? (float)(x1 - x0) / (y1 - y0) : 0;
        float dz1 = (y1 - y0) > 0 ? (float)(z1 - z0) / (y1 - y0) : 0;

        float dx2 = (y2 - y0) > 0 ? (float)(x2 - x0) / (y2 - y0) : 0;
        float dz2 = (y2 - y0) > 0 ? (float)(z2 - z0) / (y2 - y0) : 0;

        float dx3 = (y2 - y1) > 0 ? (float)(x2 - x1) / (y2 - y1) : 0;
        float dz3 = (y2 - y1) > 0 ? (float)(z2 - z1) / (y2 - y1) : 0;

        // Верхний треугольник
        for (int y = y0; y <= y1; y++)
        {
            float xs = x0 + (y - y0) * dx1;
            float xe = x0 + (y - y0) * dx2;
            float zs = z0 + (y - y0) * dz1;
            float ze = z0 + (y - y0) * dz2;

            if (xs > xe)
            {
                Swap(ref xs, ref xe);
                Swap(ref zs, ref ze);
            }

            for (int x = (int)xs; x <= (int)xe; x++)
            {

                float z = zs + ((x - xs) / (xe - xs)) * (ze - zs);

                // points.Add((x, y, (int)Math.Round(z), color0));
                points.Add((x, y, (int)Math.Round(z), calculateLight(normal,x,y, (int)Math.Round(z))));
            }
        }

        // Нижний треугольник
        for (int y = y1 + 1; y <= y2; y++)
        {
            float xs = x1 + (y - y1) * dx3;
            float xe = x0 + (y - y0) * dx2;
            float zs = z1 + (y - y1) * dz3;
            float ze = z0 + (y - y0) * dz2;

            if (xs > xe)
            {
                Swap(ref xs, ref xe);
                Swap(ref zs, ref ze);
            }

            for (int x = (int)xs; x <= (int)xe; x++)
            {
                float z = zs + ((x - xs) / (xe - xs)) * (ze - zs);

                // points.Add((x, y, (int)Math.Round(z), color0));
                points.Add((x, y, (int)Math.Round(z), calculateLight(normal, x, y, (int)Math.Round(z))));
            }
        }

        return points;
    }

    private static Color calculateLight(Vector3 normal, int x, int y, int z)
    {
        Vector3 lightPos = new Vector3(100.0f, 100.0f, 100.0f); // Позиция источника света
        Vector3 viewPos = new Vector3(1, 0, 0); // Позиция наблюдателя (камеры)
        Vector3 vertexPos = new Vector3(x, y, z); // Позиция вершины полигона
        Vector3 ambientColor = new Vector3(0.1f, 10.1f, 0.1f); // Цвет фонового освещения
        Vector3 lightColor = new Vector3(10.0f, 10.0f, 10.0f); // Цвет света

        float k_a = 8.2f;    //  фоновое освещение
        float k_d = 10.7f;    //  диффузное освещение
        float k_s = 6.3f;    //  зеркальное отражение
        float shininess = 32.0f; //  степень блеска

        Vector3 color = CalculateLighting(normal, lightPos, viewPos, vertexPos, ambientColor, lightColor, k_a, k_d, k_s, shininess);
        return Color.FromArgb((int)color[0],(int) color[1],(int) color[2]);
    }

private static void Swap(ref int x1, ref int y1, ref int z1, ref int x2, ref int y2, ref int z2)
    {
        (x1, x2) = (x2, x1);
        (y1, y2) = (y2, y1);
        (z1, z2) = (z2, z1);
    }

    private static void Swap(ref float a, ref float b)
    {
        (a, b) = (b, a);
    }
    private static void Swap(ref Color a, ref Color b)
    {
        (a, b) = (b, a);
    }
}
