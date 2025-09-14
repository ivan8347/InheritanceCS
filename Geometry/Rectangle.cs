using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    internal class Rectangle : Shape,IHaveDiagonal
    {
        double widht;
        double height;
        public double Widht { get => widht; set => widht = FilterSize(value); }
        public double Height { get => height; set => height = FilterSize(value); }

        public Rectangle(double widht, double height,
            int startX, int startY, int lineWidht, Color color) :
           base(startX, startY, lineWidht, color)
        {
            Widht = widht;
            Height = height;
        }
        public double GetDiagonal()
        { 
            return  Math.Sqrt   (widht*widht + height*height); 

        }
        public override double GetArea()
        {
            return Widht * Height;
        }
        public override double GetPerimeter()
        {
            return (Widht + Height) * 2;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color,LineWidth);
            e.Graphics.DrawRectangle(pen,StartX,StartY,(float)Widht,(float)height);
        }
        public void DrawDiagonal(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine(pen, StartX, StartY, (int)(StartX + Widht), (int)(StartY + Height));
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Ширина: {Widht} ");
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Диагональ: {GetDiagonal()}");
            base.Info(e);
            DrawDiagonal(e);
        }


    }
}
