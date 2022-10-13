using PaintDeluxe.Interfaces;
using PaintDeluxe.Models;

namespace PaintDeluxe
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Pen _pen;
        private IFigure _figure;
        private Point _firstClick;
        private Point _lastClick;
        public Form1()
        {
            InitializeComponent();

            _bitmap = new Bitmap(890, 521);

            _graphics = Graphics.FromImage(_bitmap);
            pictureBox.Image = _bitmap;

            _pen = new Pen(Color.Black, 2);
            _figure = new Line();
        }

        private void liniaBtn_Click(object sender, EventArgs e)
        {
            _figure = new Line();
        }

        private void prostokatBtn_Click(object sender, EventArgs e)
        {
            _figure = new Rect();
        }

        private void okragBtn_Click(object sender, EventArgs e)
        {
            _figure = new Circle();
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {

        }

        private void wczytajBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Jezeli pierwszy klik
            if (_figure.point1.IsEmpty || !_figure.point2.IsEmpty)
            {
                // Jezeli figura zawiera zainicjalizowany ktorys punkt to utworz nowa figure
                if (!_figure.point1.IsEmpty || !_figure.point2.IsEmpty) 
                    createNewFigure();

                _figure.point1 = new Point(e.Location.X, e.Location.Y);
            }
            else
            {
                _figure.point2 = new Point(e.Location.X, e.Location.Y);
                _figure.Draw(_graphics, _pen);

                pictureBox.Refresh();
            }
        }

        private void createNewFigure()
        {
            if (_figure is Line) _figure = new Line();
            else if (_figure is Rect) _figure = new Rect();
            else if (_figure is Circle) _figure = new Circle();
        }
    }
}