
namespace ImageProcessing
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
            adjustBitmap?.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trkLuminosity = new System.Windows.Forms.TrackBar();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.OpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Brightness = new System.Windows.Forms.TextBox();
            this.LabelLuminosity = new System.Windows.Forms.Label();
            this.LabelBrightness = new System.Windows.Forms.Label();
            this.Contrast = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLuminosity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox, 4);
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(831, 426);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // trkLuminosity
            // 
            this.trkLuminosity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkLuminosity.Location = new System.Drawing.Point(73, 435);
            this.trkLuminosity.Maximum = 100;
            this.trkLuminosity.Minimum = -100;
            this.trkLuminosity.Name = "trkLuminosity";
            this.trkLuminosity.Size = new System.Drawing.Size(586, 25);
            this.trkLuminosity.TabIndex = 1;
            this.trkLuminosity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkLuminosity.Scroll += new System.EventHandler(this.Track_Scroll);
            // 
            // trkBrightness
            // 
            this.trkBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkBrightness.Location = new System.Drawing.Point(73, 466);
            this.trkBrightness.Maximum = 500;
            this.trkBrightness.Minimum = 1;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Size = new System.Drawing.Size(586, 25);
            this.trkBrightness.TabIndex = 2;
            this.trkBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkBrightness.Value = 1;
            this.trkBrightness.Scroll += new System.EventHandler(this.Track_Scroll);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.PowderBlue;
            this.OpenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFile.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Location = new System.Drawing.Point(702, 435);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(132, 25);
            this.OpenFile.TabIndex = 3;
            this.OpenFile.Text = "Open";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Brightness
            // 
            this.Brightness.BackColor = System.Drawing.SystemColors.Control;
            this.Brightness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Brightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Brightness.Location = new System.Drawing.Point(665, 435);
            this.Brightness.Name = "Brightness";
            this.Brightness.ReadOnly = true;
            this.Brightness.Size = new System.Drawing.Size(31, 20);
            this.Brightness.TabIndex = 4;
            // 
            // LabelLuminosity
            // 
            this.LabelLuminosity.AutoSize = true;
            this.LabelLuminosity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLuminosity.Location = new System.Drawing.Point(3, 432);
            this.LabelLuminosity.Name = "LabelLuminosity";
            this.LabelLuminosity.Size = new System.Drawing.Size(64, 31);
            this.LabelLuminosity.TabIndex = 5;
            this.LabelLuminosity.Text = "Luminosity";
            this.LabelLuminosity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelBrightness
            // 
            this.LabelBrightness.AutoSize = true;
            this.LabelBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelBrightness.Location = new System.Drawing.Point(3, 463);
            this.LabelBrightness.Name = "LabelBrightness";
            this.LabelBrightness.Size = new System.Drawing.Size(64, 31);
            this.LabelBrightness.TabIndex = 6;
            this.LabelBrightness.Text = "Brightness";
            this.LabelBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Contrast
            // 
            this.Contrast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contrast.Location = new System.Drawing.Point(665, 466);
            this.Contrast.Name = "Contrast";
            this.Contrast.ReadOnly = true;
            this.Contrast.Size = new System.Drawing.Size(31, 20);
            this.Contrast.TabIndex = 7;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.LightCoral;
            this.Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reset.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Location = new System.Drawing.Point(702, 497);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(132, 25);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Controls.Add(this.Reset, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Contrast, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelBrightness, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelLuminosity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkLuminosity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trkBrightness, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Brightness, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenFile, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 525);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(702, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "ImageProcessing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLuminosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar trkLuminosity;
        private System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox Brightness;
        private System.Windows.Forms.Label LabelLuminosity;
        private System.Windows.Forms.Label LabelBrightness;
        private System.Windows.Forms.TextBox Contrast;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

