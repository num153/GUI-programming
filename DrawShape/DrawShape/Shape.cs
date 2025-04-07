using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShape
{
    public enum ShapeType
    {
        Rectangle,
        Triangle,
        Ellipse,
        Line
    }
    internal class Shape
    {
        public Point p1, p2;
        public Color colorShape;
        public ShapeType nShape;
        
        public Shape() { 
            p1 = p2 = new Point();
        }

        public void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(colorShape);
            switch(nShape)
            {
                case ShapeType.Rectangle:
                    g.FillRectangle(br, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                    break;
                case ShapeType.Ellipse:
                    g.FillEllipse(br, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                    break;

                case ShapeType.Triangle:
                    Point[] arr =
                    {
                    new Point((p2.X + p1.X) / 2, p1.Y), //Dinh
                    new Point(p1.X, p2.Y),              //Trai
                    new Point(p2.X, p2.Y)               //Phai
                };
                    g.FillPolygon(br, arr);
                    break;

                case ShapeType.Line:
                    Pen pen = new Pen(colorShape);
                    g.DrawLine(pen, p1, p2);
                    break;
            }

        }
    }
}
