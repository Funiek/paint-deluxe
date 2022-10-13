using PaintDeluxe.Interfaces;

namespace PaintDeluxe.Models
{
    public class Figure : IFigure
    {
        public Point point1 { get; set; }
        public Point point2 { get; set; }

        public Figure() { }

        public Figure(Point p1, Point p2)
        {
            point1 = p1;
            point2 = p2;
        }

        public virtual void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point1, point2);
        }
    }
}
