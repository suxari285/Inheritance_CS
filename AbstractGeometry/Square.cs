using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Square:Rectangle
    {
        public double Side { get; set; }
        public Square
            (
                double side,
                int startX, int startY, int lineWidth, Color color
            ) : base(side,side,startX, startY, lineWidth, color)
        {
            Side = side;
        }
        public override double GetArea()
        {
            return Side*Side;
        }
        public override double GetPerimetr()
        {
            return Side * 4;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Side, (float)Side);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Сторона квадрата: {Side}");
            base.Info(e);
        }
    }
}
