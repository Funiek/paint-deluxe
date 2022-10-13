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

            _pen = new Pen(Color.Black, 1);
            _figure = new Figure(new Point(0, 0), new Point(0, 0));
        }

        private void liniaBtn_Click(object sender, EventArgs e)
        {
            var formPopUp = new Form();
            formPopUp.Show(this);
        }

        private void prostokatBtn_Click(object sender, EventArgs e)
        {
            var p1 = new Point(200, 200);
            var p2 = new Point(300, 300);
            
            _figure = new Line(p1, p2);
            _figure.Draw(_graphics, _pen);

            pictureBox.Refresh();
        }

        private void okragBtn_Click(object sender, EventArgs e)
        {
            var p1 = new Point(500, 500);
            var p2 = new Point(400, 500);
            _figure = new Rect(p1, p2);
            _figure.Draw(_graphics, _pen);

            pictureBox.Refresh();
        }

        private void zapiszBtn_Click(object sender, EventArgs e)
        {

        }

        private void wczytajBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(_firstClick.IsEmpty)
            {
                _firstClick.X = e.Location.X;
                _firstClick.Y = e.Location.Y;
            }
            else
            {
                _lastClick.X = e.Location.X;
                _lastClick.Y = e.Location.Y;

                _figure = new Rect(_firstClick, _lastClick);
                _figure.Draw(_graphics, _pen);

                pictureBox.Refresh();

                zeroPoint(ref _firstClick);
                zeroPoint(ref _lastClick);
                
            }
        }

        private void zeroPoint(ref Point point )
        {
            point.X = 0;
            point.Y = 0;
        }
    }
}