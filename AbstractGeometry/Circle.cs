using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Circle:Shape,IHaveDiameter
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
        public double GetDiameter()
        {
            return Radius*2;
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
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, (float)Radius*2, (float)Radius*2);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус: {Radius}");
            Console.WriteLine($"Диаметр: {GetDiameter()}");
            //DrawRadius(e);
            DrawDiameter(e);
            base.Info(e);
        }
        public void DrawDiameter(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawLine
                (
                    pen,
                    StartX + (int)Radius + (int)(Radius * Math.Cos(210 * Math.PI/180)),
                    StartY + (int)Radius + (int)(Radius * Math.Sin(210 * Math.PI / 180)),

                    StartX + (int)Radius + (int)(Radius * Math.Cos(30 * Math.PI / 180)),
                    StartY + (int)Radius + (int)(Radius * Math.Sin(30 * Math.PI / 180))
                );
        }

        public void DrawRadius(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine
                (
                    pen,
                    StartX + (int)Radius, StartY + (int)Radius,
                    StartX + (int)Radius + (int)(Radius*Math.Cos(30*Math.PI/180)),
                    StartY + (int)Radius + (int)(Radius*Math.Sin(30*Math.PI/180))
                );
        }
    }
}
