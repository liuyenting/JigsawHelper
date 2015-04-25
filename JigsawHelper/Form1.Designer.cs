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
            this.OriginalImage.TabIndex = 0;
            this.OriginalImage.TabStop = false;
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
            this.TestImage.TabIndex = 0;
            this.TestImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 325);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalImage;
        private System.Windows.Forms.GroupBox OriginalImageGroupBox;
        private System.Windows.Forms.GroupBox TestImageGroupBox;
        private System.Windows.Forms.PictureBox TestImage;
    }
}

