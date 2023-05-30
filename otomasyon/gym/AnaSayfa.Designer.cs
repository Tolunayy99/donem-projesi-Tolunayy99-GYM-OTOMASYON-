namespace gym
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            button1 = new Button();
            button3 = new Button();
            btn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(293, 204);
            button1.Name = "button1";
            button1.Size = new Size(165, 49);
            button1.TabIndex = 20;
            button1.Text = "Güncelle/Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(293, 126);
            button3.Name = "button3";
            button3.Size = new Size(165, 49);
            button3.TabIndex = 20;
            button3.Text = "Üye Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.DarkOrange;
            btn.Font = new Font("Shrikhand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn.Location = new Point(293, 280);
            btn.Name = "btn";
            btn.Size = new Size(165, 49);
            btn.TabIndex = 21;
            btn.Text = "Üye Listesi";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(774, 450);
            Controls.Add(btn);
            Controls.Add(button3);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "AnaSayfa";
            Text = "Form1";
            Load += AnaSayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button btn;
    }
}