namespace PaintDeluxe.Interfaces
{
    public interface IFigure
    {
        public Point point1 { get; set; }
        public Point point2 { get; set; }
        void Draw(Graphics g, Pen p);
    }
}
