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
            // Jezeli dlugosc jest wieksza niz wysokosc
            if (Math.Abs(point2.X - point1.X) > Math.Abs(point2.Y - point1.Y))
                g.DrawEllipse(p, point1.X - Math.Abs(point2.X - point1.X), point1.Y - Math.Abs(point2.X - point1.X), Math.Abs((point2.X - point1.X) * 2), Math.Abs((point2.X - point1.X) * 2));
            // Jezeli szerokosc jest wieksza niz dlugosc
            else
                g.DrawEllipse(p, point1.X - Math.Abs(point2.Y - point1.Y), point1.Y - Math.Abs(point2.Y - point1.Y), Math.Abs((point2.Y - point1.Y) * 2), Math.Abs((point2.Y - point1.Y) * 2));
        }
    }
}
