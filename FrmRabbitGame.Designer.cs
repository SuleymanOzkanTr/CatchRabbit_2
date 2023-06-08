namespace CatchRabbit_2
{
    partial class FrmRabbitGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRabbitGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbRabbit2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.LBLPUAN = new System.Windows.Forms.Label();
            this.txtHiz = new System.Windows.Forms.Label();
            this.lblSANIYE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbKalpSag = new System.Windows.Forms.PictureBox();
            this.pbKalpSol = new System.Windows.Forms.PictureBox();
            this.pbKalpSag2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPuan = new System.Windows.Forms.Label();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastPuan = new System.Windows.Forms.Label();
            this.lblLastPuanHeader = new System.Windows.Forms.Label();
            this.pbBronzeMedal = new System.Windows.Forms.PictureBox();
            this.pbSilverMedal = new System.Windows.Forms.PictureBox();
            this.pbGoldMedal = new System.Windows.Forms.PictureBox();
            this.lblBaslaYazi = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrta = new System.Windows.Forms.PictureBox();
            this.pictureBoxSon = new System.Windows.Forms.PictureBox();
            this.pictureBoxIlk = new System.Windows.Forms.PictureBox();
            this.pbStardust = new System.Windows.Forms.PictureBox();
            this.pbTreasureBox = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRabbit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKalpSag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKalpSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKalpSag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronzeMedal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilverMedal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoldMedal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIlk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStardust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTreasureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pbRabbit2
            // 
            this.pbRabbit2.BackColor = System.Drawing.Color.Transparent;
            this.pbRabbit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRabbit2.Image = ((System.Drawing.Image)(resources.GetObject("pbRabbit2.Image")));
            this.pbRabbit2.Location = new System.Drawing.Point(752, 576);
            this.pbRabbit2.Name = "pbRabbit2";
            this.pbRabbit2.Size = new System.Drawing.Size(115, 129);
            this.pbRabbit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRabbit2.TabIndex = 2;
            this.pbRabbit2.TabStop = false;
            this.pbRabbit2.Click += new System.EventHandler(this.pbRabbit2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(246, 960);
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1194, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Maroon;
            this.progressBar2.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar2.Location = new System.Drawing.Point(246, 907);
            this.progressBar2.Maximum = 650;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar2.RightToLeftLayout = true;
            this.progressBar2.Size = new System.Drawing.Size(1143, 23);
            this.progressBar2.TabIndex = 5;
            // 
            // LBLPUAN
            // 
            this.LBLPUAN.AutoSize = true;
            this.LBLPUAN.BackColor = System.Drawing.Color.Transparent;
            this.LBLPUAN.Font = new System.Drawing.Font("Jokerman", 32F);
            this.LBLPUAN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLPUAN.Location = new System.Drawing.Point(741, 20);
            this.LBLPUAN.Name = "LBLPUAN";
            this.LBLPUAN.Size = new System.Drawing.Size(161, 63);
            this.LBLPUAN.TabIndex = 13;
            this.LBLPUAN.Text = "PUAN";
            // 
            // txtHiz
            // 
            this.txtHiz.AutoSize = true;
            this.txtHiz.BackColor = System.Drawing.Color.Transparent;
            this.txtHiz.Font = new System.Drawing.Font("Jokerman", 32F);
            this.txtHiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHiz.Location = new System.Drawing.Point(1535, 960);
            this.txtHiz.Name = "txtHiz";
            this.txtHiz.Size = new System.Drawing.Size(100, 63);
            this.txtHiz.TabIndex = 14;
            this.txtHiz.Text = "HIZ";
            // 
            // lblSANIYE
            // 
            this.lblSANIYE.AutoSize = true;
            this.lblSANIYE.BackColor = System.Drawing.Color.Transparent;
            this.lblSANIYE.Font = new System.Drawing.Font("Jokerman", 32F);
            this.lblSANIYE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSANIYE.Location = new System.Drawing.Point(23, 960);
            this.lblSANIYE.Margin = new System.Windows.Forms.Padding(0);
            this.lblSANIYE.Name = "lblSANIYE";
            this.lblSANIYE.Size = new System.Drawing.Size(202, 63);
            this.lblSANIYE.TabIndex = 15;
            this.lblSANIYE.Text = "ZAMAN";
            this.lblSANIYE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1673, 901);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pbKalpSag
            // 
            this.pbKalpSag.BackColor = System.Drawing.Color.Transparent;
            this.pbKalpSag.Image = ((System.Drawing.Image)(resources.GetObject("pbKalpSag.Image")));
            this.pbKalpSag.Location = new System.Drawing.Point(724, 557);
            this.pbKalpSag.Name = "pbKalpSag";
            this.pbKalpSag.Size = new System.Drawing.Size(62, 63);
            this.pbKalpSag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKalpSag.TabIndex = 18;
            this.pbKalpSag.TabStop = false;
            // 
            // pbKalpSol
            // 
            this.pbKalpSol.BackColor = System.Drawing.Color.Transparent;
            this.pbKalpSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKalpSol.Image = ((System.Drawing.Image)(resources.GetObject("pbKalpSol.Image")));
            this.pbKalpSol.Location = new System.Drawing.Point(697, 588);
            this.pbKalpSol.Name = "pbKalpSol";
            this.pbKalpSol.Size = new System.Drawing.Size(58, 51);
            this.pbKalpSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKalpSol.TabIndex = 19;
            this.pbKalpSol.TabStop = false;
            // 
            // pbKalpSag2
            // 
            this.pbKalpSag2.BackColor = System.Drawing.Color.Transparent;
            this.pbKalpSag2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKalpSag2.Image = ((System.Drawing.Image)(resources.GetObject("pbKalpSag2.Image")));
            this.pbKalpSag2.Location = new System.Drawing.Point(842, 557);
            this.pbKalpSag2.Name = "pbKalpSag2";
            this.pbKalpSag2.Size = new System.Drawing.Size(58, 51);
            this.pbKalpSag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKalpSag2.TabIndex = 20;
            this.pbKalpSag2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(246, 875);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // txtPuan
            // 
            this.txtPuan.AutoSize = true;
            this.txtPuan.BackColor = System.Drawing.Color.Transparent;
            this.txtPuan.Font = new System.Drawing.Font("Jokerman", 52F);
            this.txtPuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPuan.Location = new System.Drawing.Point(782, 83);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(92, 102);
            this.txtPuan.TabIndex = 23;
            this.txtPuan.Text = "0";
            // 
            // pbGameOver
            // 
            this.pbGameOver.BackColor = System.Drawing.Color.Transparent;
            this.pbGameOver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGameOver.BackgroundImage")));
            this.pbGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGameOver.Location = new System.Drawing.Point(0, 0);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(1684, 1046);
            this.pbGameOver.TabIndex = 24;
            this.pbGameOver.TabStop = false;
            this.pbGameOver.DoubleClick += new System.EventHandler(this.pbGameOver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 1082);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // lblLastPuan
            // 
            this.lblLastPuan.AutoSize = true;
            this.lblLastPuan.BackColor = System.Drawing.Color.Black;
            this.lblLastPuan.Font = new System.Drawing.Font("Jokerman", 52F);
            this.lblLastPuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblLastPuan.Location = new System.Drawing.Point(782, 750);
            this.lblLastPuan.Name = "lblLastPuan";
            this.lblLastPuan.Size = new System.Drawing.Size(92, 102);
            this.lblLastPuan.TabIndex = 26;
            this.lblLastPuan.Text = "0";
            // 
            // lblLastPuanHeader
            // 
            this.lblLastPuanHeader.AutoSize = true;
            this.lblLastPuanHeader.BackColor = System.Drawing.Color.Black;
            this.lblLastPuanHeader.Font = new System.Drawing.Font("Jokerman", 42F);
            this.lblLastPuanHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastPuanHeader.Location = new System.Drawing.Point(725, 668);
            this.lblLastPuanHeader.Name = "lblLastPuanHeader";
            this.lblLastPuanHeader.Size = new System.Drawing.Size(209, 82);
            this.lblLastPuanHeader.TabIndex = 27;
            this.lblLastPuanHeader.Text = "PUAN";
            // 
            // pbBronzeMedal
            // 
            this.pbBronzeMedal.BackColor = System.Drawing.Color.Transparent;
            this.pbBronzeMedal.Image = ((System.Drawing.Image)(resources.GetObject("pbBronzeMedal.Image")));
            this.pbBronzeMedal.Location = new System.Drawing.Point(539, 947);
            this.pbBronzeMedal.Name = "pbBronzeMedal";
            this.pbBronzeMedal.Size = new System.Drawing.Size(50, 50);
            this.pbBronzeMedal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBronzeMedal.TabIndex = 28;
            this.pbBronzeMedal.TabStop = false;
            // 
            // pbSilverMedal
            // 
            this.pbSilverMedal.BackColor = System.Drawing.Color.Transparent;
            this.pbSilverMedal.Image = ((System.Drawing.Image)(resources.GetObject("pbSilverMedal.Image")));
            this.pbSilverMedal.Location = new System.Drawing.Point(954, 947);
            this.pbSilverMedal.Name = "pbSilverMedal";
            this.pbSilverMedal.Size = new System.Drawing.Size(50, 50);
            this.pbSilverMedal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSilverMedal.TabIndex = 29;
            this.pbSilverMedal.TabStop = false;
            // 
            // pbGoldMedal
            // 
            this.pbGoldMedal.BackColor = System.Drawing.Color.Transparent;
            this.pbGoldMedal.Image = ((System.Drawing.Image)(resources.GetObject("pbGoldMedal.Image")));
            this.pbGoldMedal.Location = new System.Drawing.Point(1390, 947);
            this.pbGoldMedal.Name = "pbGoldMedal";
            this.pbGoldMedal.Size = new System.Drawing.Size(50, 50);
            this.pbGoldMedal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGoldMedal.TabIndex = 30;
            this.pbGoldMedal.TabStop = false;
            // 
            // lblBaslaYazi
            // 
            this.lblBaslaYazi.AutoSize = true;
            this.lblBaslaYazi.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslaYazi.Font = new System.Drawing.Font("Jokerman", 26F);
            this.lblBaslaYazi.Location = new System.Drawing.Point(487, 708);
            this.lblBaslaYazi.Name = "lblBaslaYazi";
            this.lblBaslaYazi.Size = new System.Drawing.Size(644, 51);
            this.lblBaslaYazi.TabIndex = 12;
            this.lblBaslaYazi.Text = "Tavşana Tıkla ve Yakalamaya Başla!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(622, 851);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(0, 0);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxOrta
            // 
            this.pictureBoxOrta.BackColor = System.Drawing.Color.Black;
            this.pictureBoxOrta.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrta.Image")));
            this.pictureBoxOrta.Location = new System.Drawing.Point(792, 855);
            this.pictureBoxOrta.Name = "pictureBoxOrta";
            this.pictureBoxOrta.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxOrta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrta.TabIndex = 34;
            this.pictureBoxOrta.TabStop = false;
            // 
            // pictureBoxSon
            // 
            this.pictureBoxSon.BackColor = System.Drawing.Color.Black;
            this.pictureBoxSon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSon.Image")));
            this.pictureBoxSon.Location = new System.Drawing.Point(873, 855);
            this.pictureBoxSon.Name = "pictureBoxSon";
            this.pictureBoxSon.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxSon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSon.TabIndex = 35;
            this.pictureBoxSon.TabStop = false;
            // 
            // pictureBoxIlk
            // 
            this.pictureBoxIlk.BackColor = System.Drawing.Color.Black;
            this.pictureBoxIlk.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIlk.Image")));
            this.pictureBoxIlk.Location = new System.Drawing.Point(711, 855);
            this.pictureBoxIlk.Name = "pictureBoxIlk";
            this.pictureBoxIlk.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxIlk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIlk.TabIndex = 36;
            this.pictureBoxIlk.TabStop = false;
            // 
            // pbStardust
            // 
            this.pbStardust.BackColor = System.Drawing.Color.Transparent;
            this.pbStardust.Image = ((System.Drawing.Image)(resources.GetObject("pbStardust.Image")));
            this.pbStardust.Location = new System.Drawing.Point(0, 58);
            this.pbStardust.Name = "pbStardust";
            this.pbStardust.Size = new System.Drawing.Size(1673, 843);
            this.pbStardust.TabIndex = 37;
            this.pbStardust.TabStop = false;
            this.pbStardust.Click += new System.EventHandler(this.pbStardust_Click);
            // 
            // pbTreasureBox
            // 
            this.pbTreasureBox.BackColor = System.Drawing.Color.Transparent;
            this.pbTreasureBox.Image = ((System.Drawing.Image)(resources.GetObject("pbTreasureBox.Image")));
            this.pbTreasureBox.Location = new System.Drawing.Point(447, 516);
            this.pbTreasureBox.Name = "pbTreasureBox";
            this.pbTreasureBox.Size = new System.Drawing.Size(272, 210);
            this.pbTreasureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTreasureBox.TabIndex = 38;
            this.pbTreasureBox.TabStop = false;
            this.pbTreasureBox.Click += new System.EventHandler(this.pbTreasureBox_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmRabbitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 1049);
            this.Controls.Add(this.pbGameOver);
            this.Controls.Add(this.LBLPUAN);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.lblLastPuanHeader);
            this.Controls.Add(this.lblLastPuan);
            this.Controls.Add(this.pictureBoxSon);
            this.Controls.Add(this.pictureBoxOrta);
            this.Controls.Add(this.pictureBoxIlk);
            this.Controls.Add(this.pbTreasureBox);
            this.Controls.Add(this.pbStardust);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbRabbit2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSANIYE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbKalpSag2);
            this.Controls.Add(this.lblBaslaYazi);
            this.Controls.Add(this.pbKalpSol);
            this.Controls.Add(this.pbKalpSag);
            this.Controls.Add(this.txtHiz);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbSilverMedal);
            this.Controls.Add(this.pbBronzeMedal);
            this.Controls.Add(this.pbGoldMedal);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRabbitGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tavsanı Yakala";
            this.Load += new System.EventHandler(this.FsmGameArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRabbit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKalpSag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKalpSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKalpSag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronzeMedal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilverMedal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoldMedal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIlk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStardust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTreasureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbRabbit2;
        private System.Windows.Forms.Label LBLPUAN;
        private System.Windows.Forms.Label txtHiz;
        private System.Windows.Forms.Label lblSANIYE;
      //  private RabbitGameDataDataSet1 rabbitGameDataDataSet1;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbKalpSag;
        private System.Windows.Forms.PictureBox pbKalpSol;
        private System.Windows.Forms.PictureBox pbKalpSag2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label txtPuan;
        private System.Windows.Forms.PictureBox pbGameOver;
//private Siralama siralama;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastPuan;
        private System.Windows.Forms.Label lblLastPuanHeader;
        private System.Windows.Forms.PictureBox pbBronzeMedal;
        private System.Windows.Forms.PictureBox pbSilverMedal;
        private System.Windows.Forms.PictureBox pbGoldMedal;
        private System.Windows.Forms.Label lblBaslaYazi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxOrta;
        private System.Windows.Forms.PictureBox pictureBoxSon;
        private System.Windows.Forms.PictureBox pictureBoxIlk;
        private System.Windows.Forms.PictureBox pbStardust;
        private System.Windows.Forms.PictureBox pbTreasureBox;
        private System.Windows.Forms.Timer timer2;
    }
}

