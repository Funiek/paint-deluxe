namespace PaintDeluxe.Models
{
    public class Circle : Figure
    {
        public Circle(Point p1, Point p2) : base(p1, p2)
        {
        }

        public override void Draw(Graphics g, Pen p)
        {
            base.Draw(g, p);
        }
    }
}
