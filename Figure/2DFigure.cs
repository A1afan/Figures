using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figure
{
    abstract class _2DFigure : MyFigure
    {
    }

    class Rctngl : _2DFigure
    {
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            device.DrawRectangle(new Pen(clr), new Rectangle(location, size));
        }

        public override double Square()
        {
            return size.Width * size.Height;
        }



    }
    class Romb : _2DFigure
    {
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            Point[] points = new Point[4];
            points[0] = new Point(location.X + size.Width / 2, location.Y);
            points[1] = new Point(location.X + size.Width, location.Y + size.Height / 2);
            points[2] = new Point(location.X + size.Width / 2, location.Y + size.Height);
            points[3] = new Point(location.X, location.Y + size.Height / 2);
            device.DrawPolygon(pen, points);
        }

        public override double Square()
        {
            return Math.Sqrt(Math.Pow(size.Width / 2, 2) + Math.Pow(size.Height / 2, 2)) * size.Height;
        }

    }
    class Trapeze : _2DFigure
    {
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            Point[] points = new Point[4];
            points[0] = new Point(location.X, location.Y + size.Height);
            points[1] = new Point(location.X + size.Width / 3, location.Y);
            points[2] = new Point(location.X + 2 * size.Width / 3, location.Y);
            points[3] = new Point(location.X + size.Width, location.Y + size.Height);
            device.DrawPolygon(pen, points);
        }

        public override double Square()
        {
            return 2 * size.Width / 3 * size.Height;
        }
    }

    abstract class Triangle : _2DFigure
    {
        double a, b, c;
        protected Point[] points = new Point[3];

        protected void Calculate()
        {
            a = Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2) + Math.Pow(points[1].Y - points[0].Y, 2));
            b = Math.Sqrt(Math.Pow(points[2].X - points[1].X, 2) + Math.Pow(points[2].Y - points[1].Y, 2));
            c = Math.Sqrt(Math.Pow(points[0].X - points[2].X, 2) + Math.Pow(points[0].Y - points[2].Y, 2));
        }
        public override double Square()
        {
            Calculate();
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class RectTriangle : Triangle
    {
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            points[0] = new Point(location.X + size.Width / 2, location.Y);
            points[1] = new Point(location.X + size.Width, location.Y + size.Height);
            points[2] = new Point(location.X, location.Y + size.Height);
            device.DrawPolygon(pen, points);

        }
    }

    class EquilTriangle : Triangle
    {
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            points[0] = new Point(location.X, location.Y);
            points[1] = new Point(location.X, location.Y + size.Height);
            points[2] = new Point(location.X + size.Width, location.Y + size.Height);
            device.DrawPolygon(pen, points);
        }
    }

    class CommonTriangle : Triangle
    {
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            points[0] = new Point(location.X, location.Y + size.Height);
            points[1] = new Point(location.X + size.Width / 4, location.Y);
            points[2] = new Point(location.X + size.Width, location.Y + size.Height);
            device.DrawPolygon(pen, points);
        }

    }

    class Ellipse : _2DFigure
    {
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            device.DrawEllipse(pen, new Rectangle(location, size));
        }

        public override double Square()
        {
            return Math.PI * size.Width * size.Height / 4;
        }
    }

    class Cube : _2DFigure
    {
        Point[] points = new Point[4];
        double a, b, c;
        protected void Calculate()
        {
            points[0] = new Point(location.X, location.Y);
            points[1] = new Point(location.X + size.Width / 3, location.Y - size.Height / 3);
            points[2] = new Point(location.X, location.Y + size.Height);
            points[3] = new Point(location.X + size.Width, location.Y);

            a = Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2) + Math.Pow(points[1].Y - points[0].Y, 2));
            b = Math.Sqrt(Math.Pow(points[2].X - points[0].X, 2) + Math.Pow(points[2].Y - points[0].Y, 2));
            c = Math.Sqrt(Math.Pow(points[3].X - points[0].X, 2) + Math.Pow(points[3].Y - points[0].Y, 2));
        }
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            device.DrawRectangle(pen, new Rectangle(location, size));
            device.DrawLine(pen, location, new Point(location.X + size.Width / 3, location.Y - size.Height / 3));
            device.DrawLine(pen, new Point(location.X + size.Width, location.Y), new Point(location.X + 4 * size.Width / 3, location.Y - size.Height / 3));
            device.DrawLine(pen, new Point(location.X + size.Width, location.Y + size.Height), new Point(location.X + 4 * size.Width / 3, location.Y + 2 * size.Height / 3));
            device.DrawLine(pen, new Point(location.X, location.Y + size.Height), new Point(location.X + size.Width / 3, location.Y + 2 * size.Height / 3));
            device.DrawLine(pen, new Point(location.X + size.Width / 3, location.Y - size.Height / 3), new Point(location.X + 4 * size.Width / 3, location.Y - size.Height / 3));
            device.DrawLine(pen, new Point(location.X + 4 * size.Width / 3, location.Y - size.Height / 3), new Point(location.X + 4 * size.Width / 3, location.Y + 2 * size.Height / 3));
            device.DrawLine(pen, new Point(location.X + 4 * size.Width / 3, location.Y + 2 * size.Height / 3), new Point(location.X + size.Width / 3, location.Y + 2 * size.Height / 3));
            device.DrawLine(pen, new Point(location.X + size.Width / 3, location.Y - size.Height / 3), new Point(location.X + size.Width / 3, location.Y + 2 * size.Height / 3));
        }

        public override double Square()
        {
            Calculate();
            return 2 * (a * b + b * c + a * c);
        }
    }

    class Paralelogram : _2DFigure
    {
        public override void Draw(Color clr)
        {
            Pen pen = new Pen(clr);
            Point[] points = new Point[4];
            points[0] = new Point(location.X, location.Y);
            points[1] = new Point(location.X + size.Width / 2, location.Y);
            points[2] = new Point(location.X + size.Width, location.Y + size.Height);
            points[3] = new Point(location.X + size.Width / 2, location.Y + size.Height);
            device.DrawPolygon(pen, points);
        }
        public override double Square()
        {
            return Math.Sqrt(Math.Pow(size.Width / 2, 2) + Math.Pow(size.Height / 2, 2)) * size.Height;
        }
    }
}


