using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JigsawHelper
{
    public partial class MainForm : Form
    {
        private Bitmap originalImage, testImage;
        private int columns, rows;

        public MainForm()
        {
            InitializeComponent();

            // Set default column and row count
            columns = rows = 10;

            // Set the display for new value
            ColumnsValue.Text = columns.ToString();
            RowsValue.Text = rows.ToString();
        }

        private void OriginalImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = "z:\\public\\";
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png;|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadImage(OriginalImage, dialog.FileName, out originalImage);
                    DrawGrids(OriginalImage, originalImage);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void TestImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = "z:\\public\\";
            dialog.Filter = "Images (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png;|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadImage(TestImage, dialog.FileName, out testImage);
                    DrawGrids(TestImage, testImage);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            FindSimilar();
        }

        private string notAValidIntegerMessage = "Not a valid integer. Using previous value.";
        private string errorCaption = "Error";

        private void ColumnsValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int tmp;
            if(int.TryParse(textBox.Text, out tmp))
                columns = tmp;
            else
            {
                MessageBox.Show(notAValidIntegerMessage, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = columns.ToString();
                textBox.SelectAll();
            }
        }

        private void RowsValue_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int tmp;
            if(int.TryParse(textBox.Text, out tmp))
                rows = tmp;
            else
            {
                MessageBox.Show(notAValidIntegerMessage, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = rows.ToString();
                textBox.SelectAll();
            }
        }

        private void LoadImage(PictureBox target, string path, out Bitmap storage)
        {
            Bitmap image = (Bitmap)Bitmap.FromFile(path);
            target.Image = image;
            target.ImageLocation = path;

            storage = image;
        }


        private void OriginalImage_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            if((sender as PictureBox).Image != null)
                DrawGrids(sender as PictureBox, originalImage);
        }

        private void DrawGrids(PictureBox target, Bitmap image)
        {
            int imageXSize = image.Size.Width;
            int imageYSize = image.Size.Height;

            int containerXSize = OriginalImage.Size.Width;
            int containerYSize = OriginalImage.Size.Height;

            float imageRatio = imageXSize / (float)imageYSize; // image W:H ratio
            float containerRatio = containerXSize / (float)containerYSize; // container W:H ratio

            // Scale factor and filler size
            float scaleFactor;
            float xOffset = 0, yOffset = 0;

            if(imageRatio >= containerRatio)
            {
                // Horizontal image
                scaleFactor = containerXSize / (float)imageXSize;
                float scaledHeight = imageYSize * scaleFactor;

                // Calculate filler size
                yOffset = Math.Abs(containerYSize - scaledHeight) / 2;
                /*
                unscaled_p.X = (int)(p.X / scaleFactor);
                unscaled_p.Y = (int)((p.Y - filler) / scaleFactor);
                */
            }
            else
            {
                // Vertical image
                scaleFactor = containerYSize / (float)imageYSize;
                float scaledWidth = imageYSize * scaleFactor;
                xOffset = Math.Abs(containerXSize - scaledWidth) / 2;
                /*
                unscaled_p.X = (int)((p.X - filler) / scaleFactor);
                unscaled_p.Y = (int)(p.Y / scaleFactor);
                */
            }

            int xCellSize = (int)(imageXSize / columns * scaleFactor);
            int yCellSize = (int)(imageYSize / rows * scaleFactor);

            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(Color.White);
            for(int y = 0; y < rows; ++y)
            {
                graphics.DrawLine(pen, xOffset, y*yCellSize + yOffset,
                                       columns*yCellSize + xOffset, y*yCellSize + yOffset);
            }

            for(int x = 0; x < columns; ++x)
            {
                graphics.DrawLine(pen, x*xCellSize + xOffset, yOffset,
                                       x*xCellSize + xOffset, rows*xCellSize + yOffset);
            }
            graphics.Dispose();

            target.Image = image;
        }

        private void FindSimilar()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>("z:\\public\\test.jpeg");
            Image<Bgr, byte> template = new Image<Bgr, byte>(testImage);
            Image<Bgr, byte> imageToShow = source.Copy();

            using(Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCOEFF_NORMED))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                // You can try different values of the threshold. I guess somewhere between 0.75 and 0.95 would be good.
                if(maxValues[0] > 0.9)
                {
                    // This is a match. Do something with it, for example draw a rectangle around it.
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 3);
                }
            }

            // Show imageToShow in an ImageBox (here assumed to be called imageBox1)
            OriginalImage.Image = imageToShow.ToBitmap();
        }

        
    }
}
