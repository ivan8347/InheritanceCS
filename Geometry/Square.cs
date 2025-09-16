using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    internal class Square: Rectangle
    {
        public Square(int side, int startX, int startY, int lineWidht, Color color) :
            base(side, side, startX, startY, lineWidht, color)
        { 

        }
 
    }
}
