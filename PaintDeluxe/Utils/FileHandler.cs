using System.Drawing.Imaging;

namespace PaintDeluxe.Utils
{
    public static class FileHandler
    {
        public static void SaveBitmap(Bitmap bitmap)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "Data Files (*.png)|*.png";
            dialog.DefaultExt = "png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (bitmap)
                {
                    bitmap.Save(dialog.FileName, ImageFormat.Png);
                }
            }
        }

        public static Bitmap? LoadBitmap()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "Data Files (*.png)|*.png";
            dialog.DefaultExt = "png";

            Stream? stream = null;
            Bitmap? bitmap = null;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = dialog.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            return new Bitmap(stream);
                        }
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return null;
        }
    }
}
