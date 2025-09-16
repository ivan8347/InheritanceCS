using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Triangle_90: Triangle
    {
        
        public Triangle_90(double side_1, double side_2, 
            int startX, int startY, int lineWidht, Color color) :
            base(side_1, side_2, 90,
            startX, startY, lineWidht,  color)
        { }
    }
}
