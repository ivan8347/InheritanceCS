using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class Triangle : Shape, IHaveMedian
    {
        double side_1;
        double side_2;
        double angleDeg;


        public double Side_1 { get => side_1; set => side_1 = FilterSize(value); }
        public double Side_2 { get => side_2; set => side_2 = FilterSize(value); }
        public double AngleDeg { get => angleDeg; set => angleDeg = value; }
        public double Side3()
        {
            return Math.Sqrt((side_1 * side_1) + (side_2 * side_2) - 2 * side_1 * side_2 * Math.Cos(angleDeg * Math.PI / 180));
        }
        public Triangle(double side_1, double side_2, double angleDeg,
            int startX, int startY, int lineWidht, Color color) :
            base(startX, startY, lineWidht, color)
        {
            Side_1 = side_1;
            Side_2 = side_2;
            AngleDeg = angleDeg;
        }
        public double[] GetMedian()
        {
            return new double[] { GetMedianA(), GetMedianB(), GetMedianC() };

        }
        public double GetMedianA()
        {
            double a = Side3(); 
            double b = side_1;
            double c = side_2;
            return 0.5 * Math.Sqrt(2 * b * b + 2 * c * c - a * a);
        }
        public double GetMedianB()
        {
            double a = Side3(); 
            double b = side_1;
            double c = side_2;
            return 0.5 * Math.Sqrt(2 * a * a + 2 * c * c - b * b);
        }
        public double GetMedianC()
        {
            double a = Side3(); 
            double b = side_1;
            double c = side_2;
            return 0.5 * Math.Sqrt(2 * b * b + 2 * a * a - c * c);
        }
        public override double GetArea()
        {
            return 0.5 * side_1 * side_2 * Math.Sin(angleDeg * Math.PI / 180);
        }
        public override double GetPerimeter()
        {
            return side_1 + side_2 + Side3();
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            double side3 = Side3();
            double angleRad = angleDeg * Math.PI / 180;
            PointF A = new PointF(StartX, StartY);
            PointF B = new PointF
             (
                StartX + (float)(side_1 * Math.Cos(angleRad)),
                StartY - (float)(side_1 * Math.Sin(angleRad))
             );
            PointF C = new PointF
             (
               StartX + (float)(side_2 * Math.Cos(0)), // по горизонтали
               StartY - (float)(side_2 * Math.Sin(0))
             );
            C = new PointF(StartX + (float)side_2, StartY);

            PointF[] points = { A, B, C };
            e.Graphics.DrawPolygon(pen, points);
            using (Font font = new Font("Arial", 12))
            {
                // Рисуем метки
                e.Graphics.DrawString("A", font, Brushes.White, A.X - 10, A.Y + 10);
                e.Graphics.DrawString("B", font, Brushes.White, B.X + 5, B.Y - 15);
                e.Graphics.DrawString("C", font, Brushes.White, C.X, C.Y + 10);
            }
        }
        public void DrawMedian(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 2);
            double angleRad = angleDeg * Math.PI / 180;
            PointF A = new PointF(StartX, StartY);

            PointF B = new PointF
             (
                StartX + (float)(side_1 * Math.Cos(angleRad)),
                StartY - (float)(side_1 * Math.Sin(angleRad))
             );
            PointF C = new PointF
             (
               StartX + (float)(side_2 * Math.Cos(0)), 
               StartY - (float)(side_2 * Math.Sin(0))
             );
            C = new PointF(StartX + (float)side_2, StartY);
            // Средина стороны, противоположной вершине
            PointF midSide_1 = new PointF(
                (B.X + C.X) / 2,
                (B.Y + C.Y) / 2
             );
            PointF midSide_2 = new PointF(
               (A.X + C.X) / 2,
               (A.Y + C.Y) / 2
            );
            PointF midSide_3 = new PointF(
               (B.X + A.X) / 2,
               (B.Y + A.Y) / 2
            );
            e.Graphics.DrawLine(pen, A, midSide_1);
            e.Graphics.DrawLine(pen, B, midSide_2);
            e.Graphics.DrawLine(pen, C, midSide_3);
        }
       
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Сторона AB: {Side_1}");
            Console.WriteLine($"Сторона AC: {Side_2}");
            Console.WriteLine($"Сторона BC: {Side3()}");
            Console.WriteLine($"Угол: {angleDeg}");
            Console.WriteLine($"Медиана 1: {GetMedianA()}");
            Console.WriteLine($"Медиана 2: {GetMedianB()}");
            Console.WriteLine($"Медиана 3: {GetMedianC()}");

            base.Info(e);
            DrawMedian(e);
        }
    }
}
