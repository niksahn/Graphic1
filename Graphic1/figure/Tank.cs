using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic1
{
    internal class Tank : PaintableFigure
    {
        protected override double[,] points { get; set; } = { { 4.0, 4.0, 1.0, }, { 4.0, -4.0, 1.0, }, { -4.0, -4.0, 1.0, }, { 4.0, 4.0, 1.0, }, { 0.0, 7.0, 1.0, } };
        protected override int[,] matrix { get;} = { 
          //  0  1  2  3  4
            { 0, 1, 0, 1, 1 }, // 0
            { 1, 0, 1, 0, 0 }, // 1
            { 0, 1, 0, 1, 0 }, // 2
            { 1, 0, 1, 0, 1 }, // 3
            { 1, 0, 0, 1, 0 }  // 4
        };
        public Tank(Converter _convert, Painter _painter, Mover _mover) : base(_convert, _painter, _mover) { }
    }
}
