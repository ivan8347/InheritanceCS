using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Isosceles_Triangle : Triangle
    {
       
        public Isosceles_Triangle(double side_1, double angleDeg,
            int startX, int startY, int lineWidht, Color color) :
            base(side_1, side_1, angleDeg,
            startX,  startY, lineWidht, color)
        {
            
        }
  
    }
}
