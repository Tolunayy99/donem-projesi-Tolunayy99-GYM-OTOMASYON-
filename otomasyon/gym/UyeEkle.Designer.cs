namespace gym
{
    partial class UyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            label1 = new Label();
            AdSoyadTB = new TextBox();
            label2 = new Label();
            TelefonTB = new TextBox();
            label3 = new Label();
            YasTB = new TextBox();
            label4 = new Label();
            OdemeTB = new TextBox();
            label5 = new Label();
            CinsiyetCB = new ComboBox();
            btn = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 126);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdSoyadTB
            // 
            AdSoyadTB.Location = new Point(134, 152);
            AdSoyadTB.Name = "AdSoyadTB";
            AdSoyadTB.Size = new Size(125, 23);
            AdSoyadTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 194);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Text = "Telefon no";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelefonTB
            // 
            TelefonTB.Location = new Point(134, 220);
            TelefonTB.Name = "TelefonTB";
            TelefonTB.Size = new Size(125, 23);
            TelefonTB.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(134, 264);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Yaş";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YasTB
            // 
            YasTB.Location = new Point(134, 290);
            YasTB.Name = "YasTB";
            YasTB.Size = new Size(125, 23);
            YasTB.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(134, 332);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 0;
            label4.Text = "Aylık Tutar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OdemeTB
            // 
            OdemeTB.Location = new Point(134, 358);
            OdemeTB.Name = "OdemeTB";
            OdemeTB.Size = new Size(125, 23);
            OdemeTB.TabIndex = 1;
            // 
            // label5
            // 
            label5.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(134, 400);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            label5.Text = "Cinsiyet";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CinsiyetCB
            // 
            CinsiyetCB.FormattingEnabled = true;
            CinsiyetCB.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CinsiyetCB.Location = new Point(134, 426);
            CinsiyetCB.Name = "CinsiyetCB";
            CinsiyetCB.Size = new Size(121, 23);
            CinsiyetCB.TabIndex = 2;
            // 
            // btn
            // 
            btn.BackColor = Color.DarkOrange;
            btn.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn.Location = new Point(331, 220);
            btn.Name = "btn";
            btn.Size = new Size(160, 48);
            btn.TabIndex = 3;
            btn.Text = "Ekle";
            btn.UseVisualStyleBackColor = false;
            btn.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(510, 220);
            button2.Name = "button2";
            button2.Size = new Size(160, 48);
            button2.TabIndex = 3;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(424, 307);
            button3.Name = "button3";
            button3.Size = new Size(160, 48);
            button3.TabIndex = 3;
            button3.Text = "Geri";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(726, 570);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn);
            Controls.Add(CinsiyetCB);
            Controls.Add(OdemeTB);
            Controls.Add(YasTB);
            Controls.Add(TelefonTB);
            Controls.Add(AdSoyadTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "UyeEkle";
            Text = "UyeEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AdSoyadTB;
        private Label label2;
        private TextBox TelefonTB;
        private Label label3;
        private TextBox YasTB;
        private Label label4;
        private TextBox OdemeTB;
        private Label label5;
        private ComboBox CinsiyetCB;
        private Button btn;
        private Button button2;
        private Button button3;
    }
}