using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;

namespace CatchRabbit_2
{
    public partial class FrmRabbitGame : Form
    {
        private Sqlbaglantisi bgl = new Sqlbaglantisi();
        private readonly int clikTotal = 3;

        private readonly int falseClick = 1;
        // private AudioFileReader reader2;
        private AudioFileReader reader;
        private WaveOutEvent waveOut;

        public string path = Application.StartupPath + "\\true.wav";
        public string path2 = Application.StartupPath + "\\false.wav";
        public string path3 = Application.StartupPath + "\\kids.wav";
        public string pathBronzeWin = Application.StartupPath + "\\bronzewin.wav";
        public string pathGoldWin = Application.StartupPath + "\\goldwin.wav";
        public string pathSilverWin = Application.StartupPath + "\\silverwin.wav";
        private readonly SoundPlayer player = new SoundPlayer();

        private Point pnt;

        
        private readonly Random rnd = new Random();

        private readonly Random rnd2 = new Random();

        private int saniye;

        public int trueClick;

        

        public FrmRabbitGame()
        {

            InitializeComponent();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            saniye++;
            
            txtPuan.Text = trueClick.ToString();

            //ilk trueClicklamada baslamak icin trueClickla yazisini silme
            lblBaslaYazi.Hide();
            pbKalpSag.Hide();
            pbKalpSol.Hide();
            pbKalpSag2.Hide();


            // bar buyume ve sesler

            if (progressBar1.Value >= 33)
            {
                pbBronzeMedal.Height = 75;
                pbBronzeMedal.Width = 75;
                player.SoundLocation = pathBronzeWin;
            }

            if (progressBar1.Value >= 66)
            {
                pbSilverMedal.Height = 75;
                pbSilverMedal.Width = 75;
                player.SoundLocation = pathSilverWin;
            }

            if (progressBar1.Value >= 100)
            {
                pbGoldMedal.Height = 75;
                pbGoldMedal.Width = 75;
                player.SoundLocation = pathGoldWin;
            }


            //bar 1 rengi

            if (progressBar1.Value < 33)
            {
                progressBar1.ForeColor = Color.Orange;
            }
            else if (progressBar1.Value > 33 && progressBar1.Value <= 66)
            {
                progressBar1.ForeColor = Color.DeepSkyBlue;
            }
            else if (progressBar1.Value > 66 && progressBar1.Value <= 100)
            {
                progressBar1.ForeColor = Color.GreenYellow;
            }

            //bar 2 dolum rengi
            if (progressBar2.Value <= 200)
                progressBar2.ForeColor = Color.LightYellow;
            else if (progressBar2.Value > 200 && progressBar2.Value <= 400)
                progressBar2.ForeColor = Color.DarkOrange;
            else if (progressBar2.Value > 400 && progressBar2.Value <= 600) progressBar2.ForeColor = Color.Red;


            txtHiz.Text = timer1.Interval.ToString();
            lblSANIYE.Text = saniye.ToString();

            //game hızlandırma
            if (timer1.Interval >= 450) timer1.Interval -= trueClick / falseClick;

            if (progressBar2.Value <= 600)
            {
                progressBar2.Value += clikTotal / ((trueClick + 1) / falseClick);
                progressBar2.Value += timer1.Interval / 100;
            }
            else
            {
                progressBar2.Value += 1;
            }


            /*deney
            if (progressBar1.Value<=120)
            {
                progressBar1.Value += 10;
            }
            else
            {
                progressBar1.Value += 1;
            }*
            //deney 2
            if (progressBar2.Value <= 622)
            {
                progressBar2.Value += 10;
            }
            else
            {
                progressBar2.Value += 1;
            }*/


            var hizsaniye = int.Parse(lblSANIYE.Text);
            if (hizsaniye % 5 == 0)
            {
                var a = rnd2.Next(0, 1558);
                var b = rnd2.Next(165, 770);

                pnt.X = rnd.Next(a);
                pnt.Y = rnd.Next(b);
                pbRabbit2.Location = pnt;
            }

            //game over saffasi
            if (progressBar2.Value >= 600 || progressBar1.Value >= 100)
            {
                timer1.Stop();
                pbGameOver.Show();
                if (pbBronzeMedal.Width == 75 && pbSilverMedal.Width == 75 && pbGoldMedal.Width == 75)
                {
                    pictureBoxIlk.Show();
                    pictureBoxOrta.Show();
                    pictureBoxSon.Show();
                }

                if (pbBronzeMedal.Width == 75 && pbSilverMedal.Width == 75)
                {
                    pictureBoxIlk.Show();
                    pictureBoxSon.Show();
                }

                if (pbBronzeMedal.Width == 75) pictureBoxOrta.Show();

                lblLastPuan.Text = txtPuan.Text;
                lblLastPuanHeader.Text = LBLPUAN.Text;
                lblLastPuanHeader.Show();
                lblLastPuan.Show();
                /* SqlCommand komut2 = new SqlCommand("Select Ad from TblSiralama where Ad=@p1",
                      bgl.baglanti());
                  komut2.Parameters.AddWithValue("@p1", label1.Text);
                  SqlDataReader dr = komut2.ExecuteReader();

                  bgl.baglanti().Close()*/
                /*  SqlCommand komut = new SqlCommand("Update TblSiralama set Puan=@p1 where Ad=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPuan.Text);
                komut.Parameters.AddWithValue("@p2", label1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                pbGameOver.Show();*/
            }

            //cursor yukleme
            var bm = new Bitmap(new Bitmap(Application.StartupPath + "\\iconC.png"), 64, 64);
            Cursor = new Cursor(bm.GetHicon());
            if (progressBar2.Value >= 170 && progressBar2.Value <= 220) timer2.Start();
            if (progressBar2.Value >= 221 && progressBar2.Value <= 399)
            {
                timer2.Stop();
                pbStardust.Hide();
                pbTreasureBox.Hide();
            }

            if (progressBar2.Value >= 400 && progressBar2.Value <= 450) timer2.Start();
            if (progressBar2.Value >= 451 && progressBar2.Value <= 550)
            {
                timer2.Stop();
                pbStardust.Hide();
                pbTreasureBox.Hide();
            }

            if (progressBar2.Value >= 551 && progressBar2.Value < 600) timer2.Start();
            if (progressBar2.Value >= 601)
            {
                timer2.Stop();
                pbStardust.Hide();
                pbTreasureBox.Hide();
            }
        }

        public void FsmGameArea_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rabbitGameDataDataSet1.TblSiralama2' table. You can move, or remove it, as needed.
            // this.tblSiralamaTableAdapter.Fill(this.rabbitGameDataDataSet.TblSiralama);


            pictureBox3.Hide();
            pictureBoxIlk.Hide();
            pictureBoxOrta.Hide();
            pictureBoxSon.Hide();

            //MATEMATIK BOLUMU HAZINE KUTUSU KONUMU
            var x = rnd.Next(0, 600);
            var y = rnd.Next(0, 600);
            pbTreasureBox.Hide();
            pbStardust.Hide();
            pbTreasureBox.Location = new Point(x, y);


            //Giris giris = new Giris();
            //giris.lblGirisAd.Text = label1.Text;
            lblLastPuanHeader.Hide();
            lblLastPuan.Hide();
            pbGameOver.Hide();
            progressBar2.Maximum = 650;
            progressBar2.Value = 1;

            /*sildigim tablonun kodlari
           DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblSiralama", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();*/

            waveOut = new WaveOutEvent();

            //NAduio ile calma
            reader = new AudioFileReader("kids.wav");
            waveOut.Init(reader);
            waveOut.Play();
            /*  SoundPlayer player2 = new SoundPlayer(); sound player tek seferde 2 ses dosyasi oynatamiyor
             System.Threading.Thread.Sleep(2000);
             SoundPlayer player2 = new SoundPlayer(path3);
             player2.Load();
             player2.Play();
             player2.PlayLooping();*/

            //cursor yukleme
            var bm = new Bitmap(new Bitmap(Application.StartupPath + "\\iconC.png"), 64, 64);
            Cursor = new Cursor(bm.GetHicon());
        }

        private void pbRabbit2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Cursor = Cursors.Hand;


            player.SoundLocation = path;
            player.Play();

            var a = rnd2.Next(0, 1558);
            var b = rnd2.Next(165, 770);

            pnt.X = rnd.Next(a);
            pnt.Y = rnd.Next(b);
            pbRabbit2.Location = pnt;
            trueClick++;
            if (progressBar1.Value < 100) progressBar1.Value += 1;

            if (progressBar2.Value >= 1) progressBar2.Value -= 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            trueClick--;
            // bakilacak progressBar1.Value -= 1;
            player.SoundLocation = path2;
            player.Play();
        }

        private void pbGameOver_Click(object sender, EventArgs e)
        {
            // Giris grs = new Giris();
            //grs.Show();

            Application.Restart();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //cursor yukleme
            var bm = new Bitmap(new Bitmap(Application.StartupPath + "\\iconC.png"), 64, 64);
            Cursor = new Cursor(bm.GetHicon());
        }

      private void timer2_Tick(object sender, EventArgs e)
        {
            // MATEMATIK BOLUMUNE GECIS
            if (progressBar2.Value >= 170 && progressBar2.Value <= 220)
            {
                //timer2.Start();
                pbStardust.Show();
                pbTreasureBox.Enabled = true;
                pbTreasureBox.Show();

                var a = 1;
                pbTreasureBox.Left += rnd.Next(0, 10);
                pbTreasureBox.Width -= a;
                pbTreasureBox.Height -= a;
                ;
            }

            if (progressBar2.Value >= 221 && progressBar2.Value <= 399)
            {
                timer2.Stop();
                pbStardust.Hide();
                pbTreasureBox.Enabled = false;
                pbTreasureBox.Hide();
            }

            if (progressBar2.Value >= 400 && progressBar2.Value <= 450)
            {
                //timer2.Start();
                pbTreasureBox.Enabled = true;
                pbStardust.Show();
                pbTreasureBox.Show();

                var a = 1;
                pbTreasureBox.Left -= rnd.Next(0, 11);
                pbTreasureBox.Width += a;
                pbTreasureBox.Height += a;
                ;
            }

            if (progressBar2.Value >= 451 && progressBar2.Value <= 550)
            {
                timer2.Stop();
                pbStardust.Hide();
                pbTreasureBox.Enabled = false;
                pbTreasureBox.Hide();
            }

            if (progressBar2.Value >= 551 && progressBar2.Value < 600)
            {
                //timer2.Start();
                pbStardust.Show();
                pbTreasureBox.Enabled = true;
                pbTreasureBox.Show();

                var a = 1;
                pbTreasureBox.Left += rnd.Next(0, 10);
                pbTreasureBox.Width -= a;
                pbTreasureBox.Height -= a;
                
            }

            if (progressBar2.Value >= 601)
            {
                timer2.Stop();
                pbStardust.Hide();
                pbTreasureBox.Enabled = false;
                pbTreasureBox.Hide();
            }
        }
       FrmMathGame frmMath2 = new FrmMathGame();
        public void pbTreasureBox_Click(object sender, EventArgs e)
        {
                 pbTreasureBox.Enabled=false;
                 
                timer1.Stop();
                timer2.Stop();
                progressBar2.Value += 30;
                waveOut.Stop();
                frmMath2.Show();
                frmMath2.lblMathPuan.Text = txtPuan.Text;

          

        }

        private void pbStardust_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            
            waveOut.Play();
            txtPuan.Text=frmMath2.lblMathPuan.Text;
            pbStardust.Visible = false;
            pbTreasureBox.Visible = false;
        }
    }
}