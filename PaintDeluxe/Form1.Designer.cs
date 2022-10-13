namespace PaintDeluxe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.wyczyscBtn = new System.Windows.Forms.Button();
            this.rysujBtn = new System.Windows.Forms.Button();
            this.punkt2label = new System.Windows.Forms.Label();
            this.punkt2y = new System.Windows.Forms.TextBox();
            this.punkt2x = new System.Windows.Forms.TextBox();
            this.punkt1label = new System.Windows.Forms.Label();
            this.punkt1y = new System.Windows.Forms.TextBox();
            this.punkt1x = new System.Windows.Forms.TextBox();
            this.wczytajBtn = new System.Windows.Forms.Button();
            this.zapiszBtn = new System.Windows.Forms.Button();
            this.okragBtn = new System.Windows.Forms.Button();
            this.prostokatBtn = new System.Windows.Forms.Button();
            this.liniaBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.wyczyscBtn);
            this.panel1.Controls.Add(this.rysujBtn);
            this.panel1.Controls.Add(this.punkt2label);
            this.panel1.Controls.Add(this.punkt2y);
            this.panel1.Controls.Add(this.punkt2x);
            this.panel1.Controls.Add(this.punkt1label);
            this.panel1.Controls.Add(this.punkt1y);
            this.panel1.Controls.Add(this.punkt1x);
            this.panel1.Controls.Add(this.wczytajBtn);
            this.panel1.Controls.Add(this.zapiszBtn);
            this.panel1.Controls.Add(this.okragBtn);
            this.panel1.Controls.Add(this.prostokatBtn);
            this.panel1.Controls.Add(this.liniaBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 521);
            this.panel1.TabIndex = 0;
            // 
            // wyczyscBtn
            // 
            this.wyczyscBtn.Location = new System.Drawing.Point(3, 243);
            this.wyczyscBtn.Name = "wyczyscBtn";
            this.wyczyscBtn.Size = new System.Drawing.Size(74, 23);
            this.wyczyscBtn.TabIndex = 13;
            this.wyczyscBtn.Text = "Wyczyść";
            this.wyczyscBtn.UseVisualStyleBackColor = true;
            this.wyczyscBtn.Click += new System.EventHandler(this.wyczyscBtn_Click);
            // 
            // rysujBtn
            // 
            this.rysujBtn.Location = new System.Drawing.Point(3, 424);
            this.rysujBtn.Name = "rysujBtn";
            this.rysujBtn.Size = new System.Drawing.Size(74, 23);
            this.rysujBtn.TabIndex = 12;
            this.rysujBtn.Text = "Rysuj";
            this.rysujBtn.UseVisualStyleBackColor = true;
            this.rysujBtn.Click += new System.EventHandler(this.rysujBtn_Click);
            // 
            // punkt2label
            // 
            this.punkt2label.AutoSize = true;
            this.punkt2label.Location = new System.Drawing.Point(3, 348);
            this.punkt2label.Name = "punkt2label";
            this.punkt2label.Size = new System.Drawing.Size(47, 15);
            this.punkt2label.TabIndex = 11;
            this.punkt2label.Text = "Punkt 2";
            // 
            // punkt2y
            // 
            this.punkt2y.Location = new System.Drawing.Point(3, 395);
            this.punkt2y.Name = "punkt2y";
            this.punkt2y.PlaceholderText = "Wartosc Y";
            this.punkt2y.Size = new System.Drawing.Size(74, 23);
            this.punkt2y.TabIndex = 10;
            // 
            // punkt2x
            // 
            this.punkt2x.Location = new System.Drawing.Point(3, 366);
            this.punkt2x.Name = "punkt2x";
            this.punkt2x.PlaceholderText = "Wartosc X";
            this.punkt2x.Size = new System.Drawing.Size(74, 23);
            this.punkt2x.TabIndex = 9;
            // 
            // punkt1label
            // 
            this.punkt1label.AutoSize = true;
            this.punkt1label.Location = new System.Drawing.Point(3, 275);
            this.punkt1label.Name = "punkt1label";
            this.punkt1label.Size = new System.Drawing.Size(47, 15);
            this.punkt1label.TabIndex = 8;
            this.punkt1label.Text = "Punkt 1";
            // 
            // punkt1y
            // 
            this.punkt1y.Location = new System.Drawing.Point(3, 322);
            this.punkt1y.Name = "punkt1y";
            this.punkt1y.PlaceholderText = "Wartosc Y";
            this.punkt1y.Size = new System.Drawing.Size(74, 23);
            this.punkt1y.TabIndex = 7;
            // 
            // punkt1x
            // 
            this.punkt1x.Location = new System.Drawing.Point(3, 293);
            this.punkt1x.Name = "punkt1x";
            this.punkt1x.PlaceholderText = "Wartosc X";
            this.punkt1x.Size = new System.Drawing.Size(74, 23);
            this.punkt1x.TabIndex = 6;
            // 
            // wczytajBtn
            // 
            this.wczytajBtn.Location = new System.Drawing.Point(3, 495);
            this.wczytajBtn.Name = "wczytajBtn";
            this.wczytajBtn.Size = new System.Drawing.Size(74, 23);
            this.wczytajBtn.TabIndex = 5;
            this.wczytajBtn.Text = "Wczytaj";
            this.wczytajBtn.UseVisualStyleBackColor = true;
            this.wczytajBtn.Click += new System.EventHandler(this.wczytajBtn_Click);
            // 
            // zapiszBtn
            // 
            this.zapiszBtn.Location = new System.Drawing.Point(3, 466);
            this.zapiszBtn.Name = "zapiszBtn";
            this.zapiszBtn.Size = new System.Drawing.Size(74, 23);
            this.zapiszBtn.TabIndex = 4;
            this.zapiszBtn.Text = "Zapisz";
            this.zapiszBtn.UseVisualStyleBackColor = true;
            this.zapiszBtn.Click += new System.EventHandler(this.zapiszBtn_Click);
            // 
            // okragBtn
            // 
            this.okragBtn.Image = global::PaintDeluxe.Properties.Resources.okrag;
            this.okragBtn.Location = new System.Drawing.Point(3, 163);
            this.okragBtn.Name = "okragBtn";
            this.okragBtn.Size = new System.Drawing.Size(74, 74);
            this.okragBtn.TabIndex = 3;
            this.okragBtn.Text = "Okrag";
            this.okragBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.okragBtn.UseVisualStyleBackColor = true;
            this.okragBtn.Click += new System.EventHandler(this.okragBtn_Click);
            // 
            // prostokatBtn
            // 
            this.prostokatBtn.Image = global::PaintDeluxe.Properties.Resources.prostokat;
            this.prostokatBtn.Location = new System.Drawing.Point(3, 83);
            this.prostokatBtn.Name = "prostokatBtn";
            this.prostokatBtn.Size = new System.Drawing.Size(74, 74);
            this.prostokatBtn.TabIndex = 2;
            this.prostokatBtn.Text = "Prostokat";
            this.prostokatBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prostokatBtn.UseVisualStyleBackColor = true;
            this.prostokatBtn.Click += new System.EventHandler(this.prostokatBtn_Click);
            // 
            // liniaBtn
            // 
            this.liniaBtn.Image = global::PaintDeluxe.Properties.Resources.linia;
            this.liniaBtn.Location = new System.Drawing.Point(3, 3);
            this.liniaBtn.Name = "liniaBtn";
            this.liniaBtn.Size = new System.Drawing.Size(74, 74);
            this.liniaBtn.TabIndex = 1;
            this.liniaBtn.Text = "Linia";
            this.liniaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.liniaBtn.UseVisualStyleBackColor = true;
            this.liniaBtn.Click += new System.EventHandler(this.liniaBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(890, 521);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button wczytajBtn;
        private Button zapiszBtn;
        private Button okragBtn;
        private Button prostokatBtn;
        private Button liniaBtn;
        private PictureBox pictureBox;
        private TextBox punkt1y;
        private TextBox punkt1x;
        private Label punkt1label;
        private Label punkt2label;
        private TextBox punkt2y;
        private TextBox punkt2x;
        private Button wyczyscBtn;
        private Button rysujBtn;
    }
}