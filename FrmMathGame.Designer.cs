namespace CatchRabbit_2
{
    partial class FrmMathGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMathGame));
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblToplaOrCikar = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblEsittir = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblMathPuan = new System.Windows.Forms.Label();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnCevapTrue = new System.Windows.Forms.Button();
            this.btnCevapFalse = new System.Windows.Forms.Button();
            this.lblTopla = new System.Windows.Forms.Label();
            this.lblCikar = new System.Windows.Forms.Label();
            this.lblPuanYanlis = new System.Windows.Forms.Label();
            this.lblPuanDogru = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.BackColor = System.Drawing.Color.Transparent;
            this.lblSayi1.Font = new System.Drawing.Font("Arial Narrow", 58.25F, System.Drawing.FontStyle.Bold);
            this.lblSayi1.Location = new System.Drawing.Point(469, 542);
            this.lblSayi1.Margin = new System.Windows.Forms.Padding(0);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSayi1.Size = new System.Drawing.Size(117, 91);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "??";
            this.lblSayi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplaOrCikar
            // 
            this.lblToplaOrCikar.AutoSize = true;
            this.lblToplaOrCikar.BackColor = System.Drawing.Color.Transparent;
            this.lblToplaOrCikar.Font = new System.Drawing.Font("Arial Narrow", 58.25F, System.Drawing.FontStyle.Bold);
            this.lblToplaOrCikar.Location = new System.Drawing.Point(577, 539);
            this.lblToplaOrCikar.Name = "lblToplaOrCikar";
            this.lblToplaOrCikar.Size = new System.Drawing.Size(115, 91);
            this.lblToplaOrCikar.TabIndex = 1;
            this.lblToplaOrCikar.Text = "+/-";
            this.lblToplaOrCikar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.BackColor = System.Drawing.Color.Transparent;
            this.lblSayi2.Font = new System.Drawing.Font("Arial Narrow", 58.25F, System.Drawing.FontStyle.Bold);
            this.lblSayi2.Location = new System.Drawing.Point(686, 542);
            this.lblSayi2.Margin = new System.Windows.Forms.Padding(0);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(117, 91);
            this.lblSayi2.TabIndex = 2;
            this.lblSayi2.Text = "??";
            this.lblSayi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEsittir
            // 
            this.lblEsittir.AutoSize = true;
            this.lblEsittir.BackColor = System.Drawing.Color.Transparent;
            this.lblEsittir.Font = new System.Drawing.Font("Arial Narrow", 58.25F, System.Drawing.FontStyle.Bold);
            this.lblEsittir.Location = new System.Drawing.Point(786, 548);
            this.lblEsittir.Name = "lblEsittir";
            this.lblEsittir.Size = new System.Drawing.Size(76, 91);
            this.lblEsittir.TabIndex = 3;
            this.lblEsittir.Text = "=";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblPuan.Font = new System.Drawing.Font("Jokerman", 38F);
            this.lblPuan.Location = new System.Drawing.Point(474, 301);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(191, 75);
            this.lblPuan.TabIndex = 4;
            this.lblPuan.Text = "PUAN";
            // 
            // lblMathPuan
            // 
            this.lblMathPuan.AutoSize = true;
            this.lblMathPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblMathPuan.Font = new System.Drawing.Font("Jokerman", 38F);
            this.lblMathPuan.Location = new System.Drawing.Point(685, 301);
            this.lblMathPuan.Name = "lblMathPuan";
            this.lblMathPuan.Size = new System.Drawing.Size(67, 75);
            this.lblMathPuan.TabIndex = 5;
            this.lblMathPuan.Text = "0";
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.LightGreen;
            this.btnSonraki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSonraki.BackgroundImage")));
            this.btnSonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSonraki.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSonraki.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSonraki.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSonraki.Font = new System.Drawing.Font("Jokerman", 38F);
            this.btnSonraki.Location = new System.Drawing.Point(408, 703);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(774, 89);
            this.btnSonraki.TabIndex = 6;
            this.btnSonraki.Text = "> SONRAKI <";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnCevapTrue
            // 
            this.btnCevapTrue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCevapTrue.BackgroundImage")));
            this.btnCevapTrue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCevapTrue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCevapTrue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCevapTrue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCevapTrue.Font = new System.Drawing.Font("Arial Narrow", 58.25F, System.Drawing.FontStyle.Bold);
            this.btnCevapTrue.Location = new System.Drawing.Point(868, 520);
            this.btnCevapTrue.Name = "btnCevapTrue";
            this.btnCevapTrue.Size = new System.Drawing.Size(140, 129);
            this.btnCevapTrue.TabIndex = 7;
            this.btnCevapTrue.UseVisualStyleBackColor = true;
            this.btnCevapTrue.Click += new System.EventHandler(this.btnCevapTrue_Click);
            // 
            // btnCevapFalse
            // 
            this.btnCevapFalse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCevapFalse.BackgroundImage")));
            this.btnCevapFalse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCevapFalse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCevapFalse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCevapFalse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCevapFalse.Font = new System.Drawing.Font("Arial Narrow", 58.25F, System.Drawing.FontStyle.Bold);
            this.btnCevapFalse.Location = new System.Drawing.Point(1039, 520);
            this.btnCevapFalse.Name = "btnCevapFalse";
            this.btnCevapFalse.Size = new System.Drawing.Size(140, 129);
            this.btnCevapFalse.TabIndex = 8;
            this.btnCevapFalse.Tag = "";
            this.btnCevapFalse.UseVisualStyleBackColor = true;
            this.btnCevapFalse.Click += new System.EventHandler(this.btnCevapFalse_Click);
            // 
            // lblTopla
            // 
            this.lblTopla.AutoSize = true;
            this.lblTopla.BackColor = System.Drawing.Color.Transparent;
            this.lblTopla.Font = new System.Drawing.Font("Arial Narrow", 58.25F, System.Drawing.FontStyle.Bold);
            this.lblTopla.Location = new System.Drawing.Point(589, 539);
            this.lblTopla.Name = "lblTopla";
            this.lblTopla.Size = new System.Drawing.Size(76, 91);
            this.lblTopla.TabIndex = 11;
            this.lblTopla.Text = "+";
            this.lblTopla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCikar
            // 
            this.lblCikar.AutoSize = true;
            this.lblCikar.BackColor = System.Drawing.Color.Transparent;
            this.lblCikar.Font = new System.Drawing.Font("Bahnschrift Condensed", 78.75F, System.Drawing.FontStyle.Bold);
            this.lblCikar.Location = new System.Drawing.Point(589, 512);
            this.lblCikar.Name = "lblCikar";
            this.lblCikar.Size = new System.Drawing.Size(91, 126);
            this.lblCikar.TabIndex = 12;
            this.lblCikar.Text = "-";
            this.lblCikar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuanYanlis
            // 
            this.lblPuanYanlis.AutoSize = true;
            this.lblPuanYanlis.BackColor = System.Drawing.Color.Transparent;
            this.lblPuanYanlis.Font = new System.Drawing.Font("Jokerman", 38F);
            this.lblPuanYanlis.ForeColor = System.Drawing.Color.Red;
            this.lblPuanYanlis.Location = new System.Drawing.Point(897, 370);
            this.lblPuanYanlis.Name = "lblPuanYanlis";
            this.lblPuanYanlis.Size = new System.Drawing.Size(67, 75);
            this.lblPuanYanlis.TabIndex = 15;
            this.lblPuanYanlis.Text = "0";
            // 
            // lblPuanDogru
            // 
            this.lblPuanDogru.AutoSize = true;
            this.lblPuanDogru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPuanDogru.Font = new System.Drawing.Font("Jokerman", 38F);
            this.lblPuanDogru.Location = new System.Drawing.Point(1081, 370);
            this.lblPuanDogru.Name = "lblPuanDogru";
            this.lblPuanDogru.Size = new System.Drawing.Size(67, 75);
            this.lblPuanDogru.TabIndex = 16;
            this.lblPuanDogru.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 28F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(858, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "Yanlıs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Jokerman", 28F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(1037, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 55);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dogru";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 1004);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "Saniye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 959);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sonuc";
            // 
            // FrmMathGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1684, 1048);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplaOrCikar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuanDogru);
            this.Controls.Add(this.lblPuanYanlis);
            this.Controls.Add(this.lblTopla);
            this.Controls.Add(this.btnCevapFalse);
            this.Controls.Add(this.btnCevapTrue);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.lblMathPuan);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblEsittir);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.lblCikar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FrmMathGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMathGame";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmMathGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblToplaOrCikar;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblEsittir;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Button btnCevapTrue;
        private System.Windows.Forms.Label lblTopla;
        private System.Windows.Forms.Label lblCikar;
        private System.Windows.Forms.Label lblPuanYanlis;
        private System.Windows.Forms.Label lblPuanDogru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblMathPuan;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnCevapFalse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}