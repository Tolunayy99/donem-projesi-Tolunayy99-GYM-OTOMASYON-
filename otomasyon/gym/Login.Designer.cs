namespace gym
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            KullaniciTb = new TextBox();
            SifreTb = new TextBox();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(221, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(221, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // KullaniciTb
            // 
            KullaniciTb.Location = new Point(319, 157);
            KullaniciTb.Multiline = true;
            KullaniciTb.Name = "KullaniciTb";
            KullaniciTb.Size = new Size(181, 37);
            KullaniciTb.TabIndex = 19;
            // 
            // SifreTb
            // 
            SifreTb.Location = new Point(319, 238);
            SifreTb.Multiline = true;
            SifreTb.Name = "SifreTb";
            SifreTb.PasswordChar = '*';
            SifreTb.Size = new Size(181, 37);
            SifreTb.TabIndex = 19;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(319, 320);
            button2.Name = "button2";
            button2.Size = new Size(81, 48);
            button2.TabIndex = 20;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(418, 320);
            button1.Name = "button1";
            button1.Size = new Size(82, 48);
            button1.TabIndex = 20;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(SifreTb);
            Controls.Add(KullaniciTb);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox KullaniciTb;
        private TextBox SifreTb;
        private Button button2;
        private Button button1;
    }
}