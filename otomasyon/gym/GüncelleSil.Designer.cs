namespace gym
{
    partial class GüncelleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GüncelleSil));
            CinsiyetCb = new ComboBox();
            OdemeTb = new TextBox();
            YasTb = new TextBox();
            TelefonTb = new TextBox();
            AdSoyadTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            button1 = new Button();
            UyeDGV = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)UyeDGV).BeginInit();
            SuspendLayout();
            // 
            // CinsiyetCb
            // 
            CinsiyetCb.FormattingEnabled = true;
            CinsiyetCb.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CinsiyetCb.Location = new Point(190, 417);
            CinsiyetCb.Name = "CinsiyetCb";
            CinsiyetCb.Size = new Size(121, 23);
            CinsiyetCb.TabIndex = 12;
            // 
            // OdemeTb
            // 
            OdemeTb.Location = new Point(190, 349);
            OdemeTb.Multiline = true;
            OdemeTb.Name = "OdemeTb";
            OdemeTb.Size = new Size(125, 39);
            OdemeTb.TabIndex = 8;
            // 
            // YasTb
            // 
            YasTb.Location = new Point(190, 281);
            YasTb.Multiline = true;
            YasTb.Name = "YasTb";
            YasTb.Size = new Size(125, 39);
            YasTb.TabIndex = 9;
            // 
            // TelefonTb
            // 
            TelefonTb.Location = new Point(190, 211);
            TelefonTb.Multiline = true;
            TelefonTb.Name = "TelefonTb";
            TelefonTb.Size = new Size(125, 41);
            TelefonTb.TabIndex = 10;
            // 
            // AdSoyadTb
            // 
            AdSoyadTb.Location = new Point(190, 143);
            AdSoyadTb.Multiline = true;
            AdSoyadTb.Name = "AdSoyadTb";
            AdSoyadTb.Size = new Size(125, 39);
            AdSoyadTb.TabIndex = 11;
            // 
            // label4
            // 
            label4.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(190, 323);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 3;
            label4.Text = "Aylık Tutar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(190, 255);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Yaş";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 185);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "Telefon no";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(190, 391);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 6;
            label5.Text = "Cinsiyet";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 117);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 7;
            label1.Text = "Ad Soyad";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(357, 366);
            button1.Name = "button1";
            button1.Size = new Size(96, 48);
            button1.TabIndex = 13;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UyeDGV
            // 
            UyeDGV.BackgroundColor = Color.White;
            UyeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UyeDGV.Location = new Point(357, 117);
            UyeDGV.Name = "UyeDGV";
            UyeDGV.RowTemplate.Height = 25;
            UyeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UyeDGV.Size = new Size(583, 229);
            UyeDGV.TabIndex = 14;
            UyeDGV.CellContentClick += UyeDGV_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(505, 366);
            button2.Name = "button2";
            button2.Size = new Size(96, 48);
            button2.TabIndex = 13;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(699, 365);
            button3.Name = "button3";
            button3.Size = new Size(99, 48);
            button3.TabIndex = 13;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(844, 365);
            button4.Name = "button4";
            button4.Size = new Size(96, 48);
            button4.TabIndex = 13;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Shrikhand", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(407, 9);
            label6.Name = "label6";
            label6.Size = new Size(297, 32);
            label6.TabIndex = 15;
            label6.Text = "Üye Güncelleme ve Silme";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GüncelleSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1105, 585);
            Controls.Add(label6);
            Controls.Add(UyeDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CinsiyetCb);
            Controls.Add(OdemeTb);
            Controls.Add(YasTb);
            Controls.Add(TelefonTb);
            Controls.Add(AdSoyadTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "GüncelleSil";
            Text = "GüncelleSil";
            Load += GüncelleSil_Load;
            ((System.ComponentModel.ISupportInitialize)UyeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CinsiyetCb;
        private TextBox OdemeTb;
        private TextBox YasTb;
        private TextBox TelefonTb;
        private TextBox AdSoyadTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label1;
        private Button button1;
        private DataGridView UyeDGV;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
    }
}