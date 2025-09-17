using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Equilateral_Triangle:Triangle
    {
        public Equilateral_Triangle(double side_1,int startX,int startY,int lineWidht,Color color)
            :base(side_1, side_1,60,startX,startY,lineWidht,color) { }
    }
}
