using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    internal class Circle: Shape,IHaveDiameter
    {
        double radius;

        public double Radius { get => radius; set => radius = FilterSize(value); }
            
        public Circle (double radius,int startX,int startY,int lineWidth,Color color)
            : base (startX, startY, lineWidth, color)
        {
            Radius = radius;
        }
        public double GetDiameter()
        {
            return Radius *2;
        }
        public override double GetArea()
        {
            return Math.PI * (radius * radius);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

       /* public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color,LineWidth);
            int diameter = (int)(Radius * 2);
            int topLeftX = (int)(StartX - Radius);
            int topLeftY = (int)(StartY - Radius);
            e.Graphics.DrawEllipse(pen, topLeftX, topLeftY, diameter , diameter );
        }*/
        public override void Draw(PaintEventArgs e)
        {
            // Создаем кисть для заливки
            using (Brush brush = new SolidBrush(Color.Yellow))
            {
                int diameter = (int)(Radius * 2);
                int topLeftX = (int)(StartX - Radius);
                int topLeftY = (int)(StartY - Radius);
                // Заполняем круг
                e.Graphics.FillEllipse(brush, topLeftX, topLeftY, diameter, diameter);
                // Обводим контур
                Pen pen = new Pen(Color, LineWidth);
                e.Graphics.DrawEllipse(pen, topLeftX, topLeftY, diameter, diameter);
            }
        }
        public void DrawDiameter(PaintEventArgs e)
        {
            Pen pen = new Pen(Color,1);
            e.Graphics.DrawLine(pen, StartX,(int)( StartY+Radius), StartX ,(int)(StartY - Radius) );
            e.Graphics.DrawLine(pen, (int)(StartX - Radius),StartY, (int)(StartX + Radius),StartY  );
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус: {Radius}");
            Console.WriteLine($"Дигональ: {GetDiameter()}");
            base.Info(e);
            DrawDiameter(e);
        }


    }
}
