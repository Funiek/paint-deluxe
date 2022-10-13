namespace PaintDeluxe.Models
{
    public class Line : Figure
    {
        public Line() : base() { }
        public Line(Point p1, Point p2) : base(p1, p2)
        {
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, point1, point2);
        }
    }
}
