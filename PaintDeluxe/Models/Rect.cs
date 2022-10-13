namespace PaintDeluxe.Models
{
    public class Rect : Figure
    {
        public Rect(Point p1, Point p2) : base(p1, p2)
        {
        }

        public override void Draw(Graphics g, Pen p)
        {
            Rectangle rectangle;
            g.DrawRectangle(p, point1.X, point1.Y, point2.X - point1.X, point2.Y - point2.Y);
        }
    }
}
