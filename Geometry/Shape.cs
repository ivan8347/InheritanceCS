using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    abstract class Shape
    {
        static readonly int MIN_START_X = 10;
        static readonly int MIN_START_Y = 10;
        static readonly int MAX_START_X = 900;
        static readonly int MAX_START_Y = 700;
        static readonly int MIN_LINE_WIDTH = 1;
        static readonly int MAX_LINE_WIDTH = 32;
        static readonly int MIN_SIZE = 50;
        static readonly int MAX_SIZE = 850;
        public Color Color { get; set; }
        int startX;
        int startY;
        int lineWidth;

        public int StartX
        {
            get => startX; set => startX =
                value < MIN_START_X ? MIN_START_X :
                value > MAX_START_X ? MAX_START_X : value;
        }
        public int StartY
        {
            get => startY; set => startY =
                value < MIN_START_Y ? MIN_START_Y :
                value > MAX_START_Y ? MAX_START_Y : value;
        }

        public int LineWidth
        {
            get => lineWidth; set => lineWidth =
                value < MIN_LINE_WIDTH ? MIN_LINE_WIDTH :
                value > MAX_LINE_WIDTH ? MAX_LINE_WIDTH : value;
        }
        protected double FilterSize(double size)
        {
            return
                size < MIN_SIZE ? MIN_SIZE :
                size > MAX_SIZE ? MAX_SIZE :
                size;
        }
        public Shape(int startX, int startY, int lineWidth, Color color)
        {
            StartX = startX;
            StartY = startY;
            LineWidth = lineWidth;
            Color = color;

        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw(PaintEventArgs e);
        public virtual void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Площадь фигуры: {GetArea()}");
            Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
            Draw(e);
        }

    }
}
