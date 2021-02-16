using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class MainForm : Form
    {
        private Bitmap adjustBitmap;

        public MainForm()
        {
            InitializeComponent();
            ChangeControls();
        }

        #region PROCESSING

        private Bitmap AdjustBrightnessLuminosity(Image image, int brightnessValue, int luminosityValue)
        {
            float luminosity = luminosityValue / 100.0f;
            float brightness = brightnessValue / 100.0f;
            var bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);

            using (var g = Graphics.FromImage(bitmap))
            using (var attributes = new ImageAttributes())
            {
                float[][] matrix = {
                    new float[] { brightness, 0, 0, 0, 0},
                    new float[] {0, brightness, 0, 0, 0},
                    new float[] {0, 0, brightness, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {luminosity, luminosity, luminosity, 0, 1}
                };

                ColorMatrix colorMatrix = new ColorMatrix(matrix);
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);
                return bitmap;
            }
        }

        private void ImageAdjusting()
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image?.Dispose();
                pictureBox.Image = AdjustBrightnessLuminosity(adjustBitmap, trkBrightness.Value, trkLuminosity.Value);
                pictureBox.Refresh();  
            }
        }

        private void ResetSettings()
        {
            trkLuminosity.Value = 0;
            trkBrightness.Value = 100;
            ImageAdjusting();
            ChangeControls();
        }
        #endregion

        private void ChangeControls()
        {
            Brightness.Text = trkLuminosity.Value.ToString();
            Contrast.Text = trkBrightness.Value.ToString();
        }

        private void Track_Scroll(object sender, EventArgs e)
        {
            ImageAdjusting();
            ChangeControls();
        }        

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                adjustBitmap?.Dispose();
                adjustBitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                pictureBox.Image = (Bitmap)adjustBitmap.Clone();
                ResetSettings();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetSettings(); 
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Save("output.jpg");
            }
        }
    }
}
