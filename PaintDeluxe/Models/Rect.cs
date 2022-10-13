namespace PaintDeluxe.Models
{
    public class Rect : Figure
    {
        public Rect() : base() { }
        public Rect(Point p1, Point p2) : base(p1, p2)
        {
        }

        public override void Draw(Graphics g, Pen p)
        {
            // Prawy gorny
            if (point1.X < point2.X && point1.Y > point2.Y)
                g.DrawRectangle(p, point1.X, point2.Y, point2.X - point1.X, point1.Y - point2.Y);
            // Lewy gorny
            else if (point1.X > point2.X && point1.Y > point2.Y)
                g.DrawRectangle(p, point2.X, point2.Y, point1.X - point2.X, point1.Y - point2.Y);
            // Prawy dolny
            else if (point1.X < point2.X && point1.Y < point2.Y)
                g.DrawRectangle(p, point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
            // Lewy dolny
            else if (point1.X > point2.X && point1.Y < point2.Y)
                g.DrawRectangle(p, point2.X, point1.Y, point1.X - point2.X, point2.Y - point1.Y);
        }
    }
}
