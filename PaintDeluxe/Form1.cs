using PaintDeluxe.Interfaces;
using PaintDeluxe.Models;
using PaintDeluxe.Utils;
using System.Drawing.Imaging;

namespace PaintDeluxe
{
    public partial class Form1 : Form
    {
        private Bitmap? _bitmap;
        private Graphics _graphics;
        private Pen _pen;
        private IFigure _figure;
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
            if (_bitmap != null)
            {
                FileHandler.SaveBitmap(_bitmap);

                _bitmap = new Bitmap(890, 521);
                _graphics = Graphics.FromImage(_bitmap);
                pictureBox.Image = _bitmap;
            }
                
        }

        private void wczytajBtn_Click(object sender, EventArgs e)
        {
            _bitmap = FileHandler.LoadBitmap();
            if (_bitmap == null) return;

            _graphics = Graphics.FromImage(_bitmap);
            pictureBox.Image = _bitmap;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Jezeli pierwszy klik
            if (_figure.point1.IsEmpty || !_figure.point2.IsEmpty)
            {
                // Jezeli figura zawiera zainicjalizowany ktorys punkt to utworz nowa figure
                if (!_figure.point1.IsEmpty || !_figure.point2.IsEmpty) 
                    CreateNewFigure();

                _figure.point1 = new Point(e.Location.X, e.Location.Y);
            }
            else
            {
                _figure.point2 = new Point(e.Location.X, e.Location.Y);
                _figure.Draw(_graphics, _pen);

                pictureBox.Refresh();
            }
        }

        private void CreateNewFigure()
        {
            if (_figure is Line) _figure = new Line();
            else if (_figure is Rect) _figure = new Rect();
            else if (_figure is Circle) _figure = new Circle();
        }

        private void wyczyscBtn_Click(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(890, 521);
            _graphics = Graphics.FromImage(_bitmap);
            pictureBox.Image = _bitmap;
        }

        private void rysujBtn_Click(object sender, EventArgs e)
        {
            if(punkt1x.Text == "" || punkt1y.Text == "" || punkt2x.Text == "" || punkt2y.Text == "")
            {
                MessageBox.Show("Uzupelni wszystkie pola!!!");
                return;
            }

            try
            {
                int p1x, p1y, p2x, p2y;
                int.TryParse(punkt1x.Text, out p1x);
                int.TryParse(punkt1y.Text, out p1y);
                int.TryParse(punkt2x.Text, out p2x);
                int.TryParse(punkt2y.Text, out p2y);

                _figure.point1 = new Point(p1x, p1y);
                _figure.point2 = new Point(p2x, p2y);
                _figure.Draw(_graphics, _pen);

                pictureBox.Refresh();

                CreateNewFigure();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}