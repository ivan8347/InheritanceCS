
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



            Console.WriteLine("\n\n\n\n\n");
            // Shape shape = new Shape(0, 0, 0, Sistem.Drawing.Color.Aquamarine);
            Rectangle rectangle = new Rectangle(150, 100, 20, 40, 3, Color.Aquamarine);
            rectangle.Info(e);
            Console.WriteLine("\n");
            Square square = new Square(80,220,40,3,Color.Red);
            square.Info(e);
            Console.WriteLine("\n");
            Circle circle = new Circle(40, 390, 85, 3, Color.Blue);
            circle.Info(e);
            Console.WriteLine("\n");



           /* while (true)
            {
                rectangle.Draw(e);
                square.Draw(e);
                circle.Draw(e);
            }*/
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
    }
}
