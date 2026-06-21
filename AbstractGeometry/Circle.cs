using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }
        public Circle
            (
                double radius,
                int startX, int startY, int lineWidth, Color color
            ) : base(startX, startY, lineWidth, color)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double GetPerimetr()
        {
            return Math.PI * Radius * 2;
        }
        public override void Draw(PaintEventArgs e)
        {
            //Console.WriteLine("Нужно нарисовать прямоугольник");
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, (float)Radius, (float)Radius);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус: {Radius}");
            base.Info(e);
        }
    }
}
