namespace PaintDeluxe.Models
{
    public class Circle : Figure
    {
        public Circle() : base() { }
        public Circle(Point p1, Point p2) : base(p1, p2)
        {
        }

        public override void Draw(Graphics g, Pen p)
        {
            // c2  = a2 + b2
            double radius = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            g.DrawEllipse(p, point1.X - (int)radius, point1.Y - (int)radius, (int)radius * 2, (int)radius * 2);
        }
    }
}
