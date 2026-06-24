using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Rectangle:Shape,IHaveDiagonal
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle
            (
                double width, double height,
                int startX,int startY, int lineWidth, Color color
            ):base(startX,startY,lineWidth,color)
        {
            Width = width;
            Height = height;
        }
        public double GetDiagonal()
        {
            return Math.Sqrt(Width*Width+Height*Height);
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimetr()
        {
            return 2*(Width+Height);
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color,LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
            DrawDiagonal(e);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Ширина прямоугольника: {Width}");
            Console.WriteLine($"Высота прямоугольника: {Height}");
            Console.WriteLine($"Диагональ: {GetDiagonal()}");
            base.Info(e);
        }
        public void DrawDiagonal(PaintEventArgs e)
        {
            Pen pen = new Pen (Color,LineWidth);
            e.Graphics.DrawLine(pen, StartX, StartY, StartX + (float)Width, StartY + (float)Height);
        }
    }
}
