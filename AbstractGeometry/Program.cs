//#define CHECK1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Design;
using System.Windows.Forms;

using System.Threading;

namespace AbstractGeometry
{
    internal class Program
    {
        static bool finish = false;
        static void Main(string[] args)
        {

            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                    Console.WindowLeft, Console.WindowTop,
                    Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            Pen pen = new Pen(Color.AliceBlue, 5);
            e.Graphics.DrawRectangle(pen, 900, 100, 250, 130);

            //////////////////////////////////////////////////////////////////////////////////////////////

#if CHECK1
            Rectangle rectangle = new Rectangle(500, 320, 400, 200, 5, Color.Red);
            rectangle.Info(e);

            Circle circle = new Circle(100, 600, 600, 3, Color.Blue);
            circle.Info(e);

            Square square = new Square(150, 350, 350, 10, Color.GreenYellow);
            square.Info(e); 
#endif
            Shape[] shapes = new Shape[]
            {
                new Rectangle(500, 320, 400, 200, 5, Color.Red),
                new Circle(100, 600, 600, 3, Color.Blue),
                new Square(150, 350, 350, 10, Color.GreenYellow)
            };
            //Info(shapes,e);
            Draw(shapes,e);
            Console.ReadKey();
            finish = true;
            
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);
        static void Info(Shape[] shapes,PaintEventArgs e)
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Info(e);
            }
        }
        static void Draw(Shape[] shapes,PaintEventArgs e)
        {
            while (!finish)
            {
                for (int i = 0; i < shapes.Length; i++)
                {
                    shapes[i].Draw(e);
                }
            }

        }
    }
}
