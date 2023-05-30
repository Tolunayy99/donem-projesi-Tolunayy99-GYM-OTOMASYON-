namespace gym
{
    partial class UyeleriGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeleriGoruntule));
            label6 = new Label();
            UyelerDGV = new DataGridView();
            AraUyeTb = new TextBox();
            UyeAra = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)UyelerDGV).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Font = new Font("Shrikhand", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(399, 9);
            label6.Name = "label6";
            label6.Size = new Size(297, 32);
            label6.TabIndex = 16;
            label6.Text = "Üyeleri Listele";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UyelerDGV
            // 
            UyelerDGV.BackgroundColor = Color.White;
            UyelerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UyelerDGV.Location = new Point(202, 169);
            UyelerDGV.Name = "UyelerDGV";
            UyelerDGV.RowTemplate.Height = 25;
            UyelerDGV.Size = new Size(719, 229);
            UyelerDGV.TabIndex = 17;
            UyelerDGV.CellContentClick += UyeDGV_CellContentClick;
            // 
            // AraUyeTb
            // 
            AraUyeTb.Location = new Point(202, 126);
            AraUyeTb.Multiline = true;
            AraUyeTb.Name = "AraUyeTb";
            AraUyeTb.Size = new Size(159, 37);
            AraUyeTb.TabIndex = 18;
            // 
            // UyeAra
            // 
            UyeAra.BackColor = Color.DarkOrange;
            UyeAra.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UyeAra.Location = new Point(367, 127);
            UyeAra.Name = "UyeAra";
            UyeAra.Size = new Size(96, 38);
            UyeAra.TabIndex = 19;
            UyeAra.Text = "Ara";
            UyeAra.UseVisualStyleBackColor = false;
            UyeAra.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(202, 404);
            button2.Name = "button2";
            button2.Size = new Size(96, 48);
            button2.TabIndex = 19;
            button2.Text = "Yenile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(321, 404);
            button3.Name = "button3";
            button3.Size = new Size(96, 48);
            button3.TabIndex = 19;
            button3.Text = "Geri";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UyeleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1105, 585);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(UyeAra);
            Controls.Add(AraUyeTb);
            Controls.Add(UyelerDGV);
            Controls.Add(label6);
            Name = "UyeleriGoruntule";
            Text = "UyeleriGoruntule";
            Load += UyeleriGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)UyelerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView UyelerDGV;
        private TextBox AraUyeTb;
        private Button UyeAra;
        private Button button2;
        private Button button3;
    }
}