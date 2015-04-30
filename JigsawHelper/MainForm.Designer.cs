namespace JigsawHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.OriginalImageGroupBox = new System.Windows.Forms.GroupBox();
            this.TestImageGroupBox = new System.Windows.Forms.GroupBox();
            this.TestImage = new System.Windows.Forms.PictureBox();
            this.ColumnsValue = new System.Windows.Forms.TextBox();
            this.ColumnsLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.RowsValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            this.OriginalImageGroupBox.SuspendLayout();
            this.TestImageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalImage
            // 
            this.OriginalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalImage.Location = new System.Drawing.Point(3, 16);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(394, 281);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 0;
            this.OriginalImage.TabStop = false;
            this.OriginalImage.Paint += new System.Windows.Forms.PaintEventHandler(this.OriginalImage_Paint);
            this.OriginalImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OriginalImage_MouseDoubleClick);
            // 
            // OriginalImageGroupBox
            // 
            this.OriginalImageGroupBox.Controls.Add(this.OriginalImage);
            this.OriginalImageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.OriginalImageGroupBox.Name = "OriginalImageGroupBox";
            this.OriginalImageGroupBox.Size = new System.Drawing.Size(400, 300);
            this.OriginalImageGroupBox.TabIndex = 1;
            this.OriginalImageGroupBox.TabStop = false;
            this.OriginalImageGroupBox.Text = "Original Image";
            // 
            // TestImageGroupBox
            // 
            this.TestImageGroupBox.Controls.Add(this.TestImage);
            this.TestImageGroupBox.Location = new System.Drawing.Point(418, 13);
            this.TestImageGroupBox.Name = "TestImageGroupBox";
            this.TestImageGroupBox.Size = new System.Drawing.Size(200, 150);
            this.TestImageGroupBox.TabIndex = 2;
            this.TestImageGroupBox.TabStop = false;
            this.TestImageGroupBox.Text = "Test Image";
            // 
            // TestImage
            // 
            this.TestImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestImage.Location = new System.Drawing.Point(3, 16);
            this.TestImage.Name = "TestImage";
            this.TestImage.Size = new System.Drawing.Size(194, 131);
            this.TestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TestImage.TabIndex = 0;
            this.TestImage.TabStop = false;
            this.TestImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TestImage_MouseDoubleClick);
            // 
            // ColumnsValue
            // 
            this.ColumnsValue.Location = new System.Drawing.Point(480, 172);
            this.ColumnsValue.Name = "ColumnsValue";
            this.ColumnsValue.Size = new System.Drawing.Size(135, 20);
            this.ColumnsValue.TabIndex = 3;
            this.ColumnsValue.TextChanged += new System.EventHandler(this.ColumnsValue_TextChanged);
            // 
            // ColumnsLabel
            // 
            this.ColumnsLabel.AutoSize = true;
            this.ColumnsLabel.Location = new System.Drawing.Point(427, 175);
            this.ColumnsLabel.Name = "ColumnsLabel";
            this.ColumnsLabel.Size = new System.Drawing.Size(47, 13);
            this.ColumnsLabel.TabIndex = 4;
            this.ColumnsLabel.Text = "Columns";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(440, 201);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(34, 13);
            this.RowsLabel.TabIndex = 5;
            this.RowsLabel.Text = "Rows";
            // 
            // RowsValue
            // 
            this.RowsValue.Location = new System.Drawing.Point(480, 198);
            this.RowsValue.Name = "RowsValue";
            this.RowsValue.Size = new System.Drawing.Size(135, 20);
            this.RowsValue.TabIndex = 6;
            this.RowsValue.TextChanged += new System.EventHandler(this.RowsValue_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 325);
            this.Controls.Add(this.RowsValue);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.ColumnsLabel);
            this.Controls.Add(this.ColumnsValue);
            this.Controls.Add(this.TestImageGroupBox);
            this.Controls.Add(this.OriginalImageGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Jigsaw Helper";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            this.OriginalImageGroupBox.ResumeLayout(false);
            this.TestImageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalImage;
        private System.Windows.Forms.GroupBox OriginalImageGroupBox;
        private System.Windows.Forms.GroupBox TestImageGroupBox;
        private System.Windows.Forms.PictureBox TestImage;
        private System.Windows.Forms.TextBox ColumnsValue;
        private System.Windows.Forms.Label ColumnsLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.TextBox RowsValue;
    }
}

