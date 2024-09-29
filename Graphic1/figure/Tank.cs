using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic1
{
    internal class Tank : PaintableFigure
    {
        protected override double[,] points { get; set; } =
        { 
            { -3.0, 0.0, 0.0, 1.0 },// A
            { -3.0, 3.0, 0.0, 1.0 }, // B
            { 3.0, 3.0, 0.0, 1.0 },  // C
            { 3.0, 0.0, 0.0, 1.0 },  // D
            { -7.0, 0.0, 0.0, 1.0 }, // E
            { 7.0, 0.0, 0.0, 1.0 },  // F
            { -7.0, -3.0, 0.0, 1.0 },// G
            { 7.0, -3.0, 0.0, 1.0 }, // H
            { 10.0, 0.0, 0.0, 1.0 }, // I
            { -10.0, 0.0, 0.0, 1.0 },// J
            { 3.0, 2.0, 0.0, 1.0 },  // K
            { 9.0, 2.0, 0.0, 1.0 },  // L
            { 9.0, 1.0, 0.0, 1.0 },  // M
            { 3.0, 1.0, 0.0, 1.0 },  // N
            { 10.0, 2.0, 0.0, 1.0 }, // O
            { 10.0, 1.0, 0.0, 1.0 }, // P
            { 2.0, 3.0, 0.0, 1.0 },  // Q
            { 2.0, 3.58, 0.0, 1.0 }, // R
            { 1.0, 3.58, 0.0, 1.0 }, // S
            { 1.0, 3.0, 0.0, 1.0 },  // T
            { -3.0, 0.0, 3.0, 1.0 },// A1
            { -3.0, 3.0, 3.0, 1.0 }, // B1
            { 3.0, 3.0, 3.0, 1.0 },  // C1
            { 3.0, 0.0, 3.0, 1.0 },  // D1
            { -7.0, 0.0, 3.0, 1.0 }, // E1
            { 7.0, 0.0, 3.0, 1.0 },  // F1
            { -7.0, -3.0, 3.0, 1.0 },// G1
            { 7.0, -3.0, 3.0, 1.0 }, // H1
            { 10.0, 0.0, 3.0, 1.0 }, // I1
            { -10.0, 0.0, 3.0, 1.0 },// J1
            { 3.0, 2.0, 3.0, 1.0 },  // K1
            { 9.0, 2.0, 3.0, 1.0 },  // L1
            { 9.0, 1.0, 3.0, 1.0 },  // M1
            { 3.0, 1.0, 3.0, 1.0 },  // N1
            { 10.0, 2.0, 3.0, 1.0 }, // O1
            { 10.0, 1.0, 3.0, 1.0 }, // P1
            { 2.0, 3.0, 3.0, 1.0 },  // Q1
            { 2.0, 3.58, 3.0, 1.0 }, // R1
            { 1.0, 3.58, 3.0, 1.0 }, // S1
            { 1.0, 3.0, 3.0, 1.0 }, // T1
        };
        protected override int[,] matrix { get;} = {
          //        0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39
          //        A  B  C  D  E  F  G  H  I  J  K  L  M  N  O  P  Q  R  S  T  A1 B1 C1 D1 E1 F1 G1 H1 I1 J1 K1 L1 M1 N1 O1 P1 Q1 R1 S1 T1
          /* A */  {0, 1 ,0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* B */  {1, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* C */  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* D */  {1, 0 ,0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* E */  {0, 0 ,0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* F */  {0, 0 ,0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },       
          /* G */  {0, 0 ,0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* H */  {0, 0 ,0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* I */  {0, 0 ,0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* J */  {0, 0 ,0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* K */  {0, 0 ,1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* L */  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* M */  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
          /* N */  {0, 0 ,0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
          /* O */  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
          /* P */  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
          /* Q */  {0, 0 ,1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
          /* R */  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
          /* S */  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
          /* T */  {0, 1 ,1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
          /* A1*/  {1, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 ,0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* B1*/  {0, 1 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
          /* C1*/  {0, 0 ,1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
          /* D1*/  {0, 0 ,0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 ,0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
          /* E1*/  {0, 0 ,0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* F1*/  {0, 0 ,0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* G1*/  {0, 0 ,0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* H1*/  {0, 0 ,0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* I1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* J1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
          /* K1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
          /* L1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
          /* M1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
          /* N1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
          /* O1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
          /* P1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
          /* Q1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
          /* R1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0 },
          /* S1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
          /* T1*/  {0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 ,1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
        };
        protected override Poligon[] poligons { get; } = new Poligon[]  
        {
           //Лицевая сторона
           new Poligon(9, 4, 6, Color.Green),
           new Poligon(5, 7, 8, Color.Green),
           new Poligon(6, 7, 5, Color.Green),
           new Poligon(6, 4, 5, Color.Green),

           new Poligon(1, 2, 0, Color.GreenYellow),
           new Poligon(0, 2, 3, Color.GreenYellow),

           new Poligon(18, 19, 17, Color.Brown),
           new Poligon(16, 19, 17, Color.Brown),

           new Poligon(10, 13, 14, Color.GreenYellow),
           new Poligon(13, 14, 15, Color.GreenYellow),


            // Зад
            new Poligon(29, 24, 26, Color.Green),
            new Poligon(25, 27, 28, Color.Green),
            new Poligon(26, 27, 25, Color.Green),
            new Poligon(26, 24, 25, Color.Green),

            new Poligon(21, 22, 20, Color.GreenYellow),
            new Poligon(20, 22, 23, Color.GreenYellow),

            new Poligon(38, 39, 37, Color.Brown),
            new Poligon(36, 39, 37, Color.Brown),

            new Poligon(30, 33, 34, Color.GreenYellow),
            new Poligon(33, 34, 35, Color.GreenYellow),

            //Bottom

              new Poligon(6, 7, 27, Color.Green),
              new Poligon(6, 27, 26, Color.Green),

              new Poligon(6, 9, 26, Color.Green),
              new Poligon(29, 9, 26, Color.Green),

              new Poligon(7, 8, 28, Color.Green),
              new Poligon(7, 28, 27, Color.Green),

              new Poligon(13, 15, 35, Color.Green),
              new Poligon(13, 33, 35, Color.Green),

              //Top

              new Poligon(8, 9, 28, Color.Green),
              new Poligon(29, 28, 9, Color.Green),

              new Poligon(1, 2, 22, Color.Green),
              new Poligon(22, 21, 1, Color.Green),

              new Poligon(10, 14, 24, Color.Green),
              new Poligon(10, 20, 24, Color.Green),

              new Poligon(18, 17, 37, Color.Brown),
              new Poligon(18, 38, 37, Color.Brown),

              // Front

              new Poligon(14, 15, 34, Color.Green),
              new Poligon(34, 35, 15, Color.Green),

              new Poligon(2, 3, 23, Color.Green),
              new Poligon(23, 22, 2, Color.Green),

              new Poligon(17, 16, 36, Color.Green),
              new Poligon(36, 37, 17, Color.Green),

               new Poligon(18, 19, 39, Color.Green),
              new Poligon(39, 38, 18, Color.Green),

               new Poligon(1, 0, 20, Color.Green),
              new Poligon(20, 21, 1, Color.Green),

            //// Верхняя поверхность корпуса танка - Зеленый цвет
            //new Poligon(1, 2, 22, Color.Green),
            //new Poligon(2, 23, 22, Color.Green),
            //new Poligon(2, 3, 23, Color.Green),
            //new Poligon(3, 24, 23, Color.Green),
            //new Poligon(3, 0, 24, Color.Green),
            //new Poligon(0, 21, 24, Color.Green),
            //new Poligon(0, 1, 21, Color.Green),
            //new Poligon(1, 22, 21, Color.Green),

            //// Нижняя поверхность корпуса танка - Зеленый цвет
            //new Poligon(20, 21, 41, Color.Green),
            //new Poligon(21, 42, 41, Color.Green),
            //new Poligon(21, 22, 42, Color.Green),
            //new Poligon(22, 43, 42, Color.Green),
            //new Poligon(22, 23, 43, Color.Green),
            //new Poligon(23, 44, 43, Color.Green),
            //new Poligon(23, 24, 44, Color.Green),
            //new Poligon(24, 45, 44, Color.Green),
            //new Poligon(24, 21, 45, Color.Green),
            //new Poligon(21, 42, 45, Color.Green),

            //// Боковые поверхности корпуса танка - Зеленый цвет
            //new Poligon(1, 22, 2, Color.Green),
            //new Poligon(2, 22, 23, Color.Green),
            //new Poligon(2, 23, 3, Color.Green),
            //new Poligon(3, 23, 24, Color.Green),
            //new Poligon(0, 1, 20, Color.Green),
            //new Poligon(1, 21, 20, Color.Green),
            //new Poligon(3, 0, 20, Color.Green),
            //new Poligon(24, 3, 20, Color.Green),
            //new Poligon(21, 24, 20, Color.Green),

            //// Задняя поверхность корпуса танка - Зеленый цвет
            //new Poligon(0, 1, 20, Color.Green),
            //new Poligon(1, 21, 20, Color.Green),
            //new Poligon(21, 41, 20, Color.Green),
            //new Poligon(20, 41, 40, Color.Green),
            //new Poligon(0, 20, 40, Color.Green),

            //// Передняя поверхность корпуса танка - Зеленый цвет
            //new Poligon(3, 2, 5, Color.Green),
            //new Poligon(2, 5, 4, Color.Green),
            //new Poligon(2, 23, 4, Color.Green),
            //new Poligon(23, 44, 4, Color.Green),
            //new Poligon(24, 3, 5, Color.Green),
            //new Poligon(24, 5, 45, Color.Green),
            //new Poligon(45, 5, 6, Color.Green),
            //new Poligon(44, 45, 6, Color.Green),
            //new Poligon(44, 6, 7, Color.Green),
            //new Poligon(43, 44, 7, Color.Green),
            //new Poligon(43, 7, 8, Color.Green),
            //new Poligon(42, 43, 8, Color.Green),
            //new Poligon(42, 8, 9, Color.Green),
            //new Poligon(41, 42, 9, Color.Green),
            //new Poligon(41, 9, 10, Color.Green),
            //new Poligon(40, 41, 10, Color.Green),

            //// Башня танка - Темно-зеленый цвет
            //new Poligon(16, 17, 36, Color.DarkOliveGreen),
            //new Poligon(17, 37, 36, Color.DarkOliveGreen),
            //new Poligon(17, 18, 37, Color.DarkOliveGreen),
            //new Poligon(18, 38, 37, Color.DarkOliveGreen),
            //new Poligon(18, 19, 38, Color.DarkOliveGreen),
            //new Poligon(19, 39, 38, Color.DarkOliveGreen),
            //new Poligon(19, 16, 39, Color.DarkOliveGreen),
            //new Poligon(16, 36, 39, Color.DarkOliveGreen),

            //// Верхняя поверхность башни
            //new Poligon(36, 37, 38, Color.DarkOliveGreen),
            //new Poligon(36, 38, 39, Color.DarkOliveGreen),

            //// Люк на башне - Темно-зеленый цвет
            //new Poligon(17, 18, 37, Color.DarkOliveGreen),
            //new Poligon(18, 38, 37, Color.DarkOliveGreen),

            //// Пушка танка - Серый цвет
            //new Poligon(10, 11, 30, Color.Gray),
            //new Poligon(11, 31, 30, Color.Gray),
            //new Poligon(11, 12, 31, Color.Gray),
            //new Poligon(12, 32, 31, Color.Gray),
            //new Poligon(12, 13, 32, Color.Gray),
            //new Poligon(13, 33, 32, Color.Gray),
            //new Poligon(13, 14, 33, Color.Gray),
            //new Poligon(14, 34, 33, Color.Gray),
            //new Poligon(14, 15, 34, Color.Gray),
            //new Poligon(15, 35, 34, Color.Gray),

            //// Верхняя поверхность пушки
            //new Poligon(30, 31, 32, Color.Gray),
            //new Poligon(30, 32, 33, Color.Gray),
            //new Poligon(30, 33, 34, Color.Gray),
            //new Poligon(30, 34, 35, Color.Gray),
        };
    
        public Tank(Converter _convert, Painter _painter, Mover _mover) : base(_convert, _painter, _mover) { }
    }
}
