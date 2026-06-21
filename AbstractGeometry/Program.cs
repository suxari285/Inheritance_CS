using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Design;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                    Console.WindowLeft, Console.WindowTop,
                    Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e =new PaintEventArgs(graphics, window_rect);
            Pen pen = new Pen(Color.AliceBlue, 5);
            e.Graphics.DrawRectangle(pen, 300, 300, 250, 130);

            //////////////////////////////////////////////////////////////////////////////////////////////

            Rectangle rectangle = new Rectangle(500, 320, 400, 200, 5, Color.Red);
            rectangle.Info(e);

            Circle circle = new Circle(100,600,600,3,Color.Blue);
            circle.Info(e);

            Square square = new Square(150,350,350,10,Color.GreenYellow);
            square.Info(e);
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);
    }
}
