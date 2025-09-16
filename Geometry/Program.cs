
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd= GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (Console.WindowLeft,Console.WindowTop,Console.WindowWidth,Console.WindowHeight);
            PaintEventArgs e = new PaintEventArgs(graphics,window_rect);
           // e.Graphics.DrawLine(new Pen(Color.AliceBlue, 10), 100, 100, 500, 500);



            //Console.WriteLine("\n\n\n\n\n");
            // Shape shape = new Shape(0, 0, 0, Sistem.Drawing.Color.Aquamarine);
           /* Console.WriteLine("Прямоугольник");
            Rectangle rectangle = new Rectangle(150, 100, 500, 300, 3, Color.Aquamarine);
            rectangle.Info(e);
            Console.WriteLine("\n");
            Console.WriteLine("Квадрат");
            Square square = new Square(80,700,40,3,Color.Red);
            square.Info(e);
            Console.WriteLine("\n");
            Console.WriteLine("Круг");
            Circle circle = new Circle(40, 890, 85, 3, Color.Blue);
            circle.Info(e);
            Console.WriteLine("\n");*/
           /* Console.WriteLine("Треугольник");
            Triangle triangle = new Triangle(150,100,110,750,400,3,Color.Green);
            triangle.Info(e);
            Console.WriteLine("\n");*/
            Console.WriteLine("Прямоугольный треугольник");
            Triangle_90 triangle_90 = new Triangle_90(150,100,600,200,3,Color.Coral);
            triangle_90.Info(e);
            Console.WriteLine("\n");
           // Isosceles_triangle isosceles_Triangle = new Isosceles_triangle(150,30,850,200,3,Color.OrangeRed);
           // isosceles_Triangle.Info(e);
           // Console.WriteLine("\n");



            while (true)
            {
                //rectangle.Draw(e);
                //square.Draw(e);
                //circle.Draw(e);
                //triangle.Draw(e);
            }
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
    }
}
