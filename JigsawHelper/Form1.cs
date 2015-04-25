using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace JigsawHelper
{
    public partial class MainForm : Form
    {
        private Image originalImage, testImage;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "z:\\public\\";
            openFileDialog.Filter = "Images (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png;|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    originalImage = Image.FromFile(openFileDialog.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

                // Update the picture box
                OriginalImage.Image = (Image)originalImage.Clone();
                OriginalImage.Refresh();
            }
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

        private void OriginalImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Black);

            if(originalImage != null)
            {
                int imageXSize = originalImage.Size.Width;
                int imageYSize = originalImage.Size.Height;

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
            }

            // Redraw the image by calling the original painter
            base.OnPaint(e);
        }

        private void TestImage_Click(object sender, EventArgs e)
        {
            // TODO: Use WIA to monitor for new image
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "z:\\public\\";
            openFileDialog.Filter = "Images (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png;|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    testImage = Image.FromFile(openFileDialog.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

                // Update the picture box
                TestImage.Image = (Image)testImage.Clone();
                //TestImage.Refresh();
            }
        }
    }
}
