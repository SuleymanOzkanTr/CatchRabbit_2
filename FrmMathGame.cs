using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;

namespace CatchRabbit_2
{
    public partial class FrmMathGame : Form
    {
        public AudioFileReader reader2;
        public WaveOutEvent waveOut2;
        private SoundPlayer sound = new SoundPlayer();
        public string yol = Application.StartupPath + "\\true.wav";
     //   public string yolb = Application.StartupPath + "\\wrong.wav";
       

        private int puanDogru, puanYanlis;
        private readonly Random rnd = new Random(); // serbest alana ekle
        private int sayi1, sayi2, cevapTrue, cevapFalse, islem, mix;
        public int seconds=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label3.Text = seconds.ToString();
        }

        public FrmMathGame()
        {
            InitializeComponent();
        }
        //int pDogru, pYanlis, //psonuc;
        public void FrmMathGame_Load(object sender, EventArgs e)
        {
            
            lblTopla.Text = "+";
            lblCikar.Text = "-";
            btnSonraki.Text = "Soru Getir";
            lblTopla.Visible = false;
            lblCikar.Visible = false;
            lblToplaOrCikar.Visible = true;
            waveOut2 = new WaveOutEvent();


        }

        public void btnSonraki_Click(object sender, EventArgs e)
        {
            timer3.Start();
            lblPuanDogru.Text = puanDogru.ToString();
            lblPuanYanlis.Text = puanYanlis.ToString();
            //CLİCK btnSonraki BASILINCA --->işlemleri getirme
            lblToplaOrCikar.Visible = false;
            btnSonraki.Enabled = false;
            btnSonraki.Text = "Sonraki Soru";
            btnCevapTrue.Enabled = true;
            btnCevapFalse.Enabled = true;
            btnCevapTrue.Visible = true;
            btnCevapFalse.Visible = true;


            // Yapılacak İşlem Toplamamı Çıkarma mı?
            islem = rnd.Next(0, 2);
            if (islem == 0)
            {
                lblTopla.Visible = true;
                lblCikar.Visible = false;
            }
            else
            {
                lblTopla.Visible = false;
                lblCikar.Visible = true;
            }
            //Hesaplama Şekline Göre İşlem Yapma

            //Sayi uretmek

            sayi1 = rnd.Next(0, 11);
            sayi2 = rnd.Next(0, 11);


            lblSayi1.Text = sayi1.ToString();
            lblSayi2.Text = sayi2.ToString();
            mix = rnd.Next(-2, 3);
            var mix2 = rnd.Next(-2, 3);

            if (lblTopla.Visible)
            {
                if (mix != 0)
                {
                    cevapTrue = sayi1 + sayi2;
                    cevapFalse = sayi1 + sayi2 + mix;
                }
                else if (mix2 != 0)
                {
                    cevapTrue = sayi1 + sayi2;
                    cevapFalse = sayi1 + sayi2 + mix2;
                }
                else
                {
                    cevapTrue = sayi1 + sayi2;
                    cevapFalse = sayi1 + sayi2 + 1;
                }
            }
            if (lblCikar.Visible)
            {
                if (sayi1 >= sayi2)
                {
                    cevapTrue = sayi1 - sayi2;
                    cevapFalse = sayi1 - sayi2 + 1;
                }

                if (sayi1 < sayi2)
                {
                    lblSayi1.Text = sayi2.ToString();
                    lblSayi2.Text = sayi1.ToString();
                    cevapTrue = sayi2 - sayi1;
                    cevapFalse = sayi2 - sayi1 + 1;
                }
            }


            // Dogru Yanlış Cevabın Yerini Belirleme
            // birinci konum için
            var cevapYer = rnd.Next(3, 5);

            if (sayi1 >= sayi2)
            {
                btnCevapTrue.Text = cevapFalse.ToString();
                btnCevapFalse.Text = cevapTrue.ToString();
            }
            if (sayi1 < sayi2)
            {
                btnCevapTrue.Text = cevapTrue.ToString();
                btnCevapFalse.Text = cevapFalse.ToString();
            }
        }
        
        private void btnCevapTrue_Click(object sender, EventArgs e)
        {
            // CLİCK btnCevapTrue BASILINCA--> Eğer Dogru Cevaba basılırsa gerçekleşecek olay
            
            
            if (btnCevapTrue.Text == cevapTrue.ToString())
            {
                sound.SoundLocation = yol;
                sound.Play();
                btnCevapFalse.Enabled = false;
                btnCevapTrue.Enabled = false;
                btnSonraki.Enabled = true;
                puanDogru++;
               
            }
            if (int.Parse(label3.Text) >= 120)
            {
                //psonuc += pDogru - pYanlis;
                puanYanlis = 0;
                puanDogru = 0;
                btnSonraki.Text = "Soru Getir";
                lblTopla.Visible = false;
                lblCikar.Visible = false;
                lblToplaOrCikar.Visible = true;
                lblMathPuan.Text = //psonuc.ToString();
                (seconds = 0).ToString();
                FrmRabbitGame frm2 = new FrmRabbitGame();
                //label4.Text = //psonuc.ToString();

                lblPuanYanlis.Text = 0.ToString();
                lblPuanDogru.Text = 0.ToString();

                this.Hide();
            }
            if (btnCevapTrue.Text == cevapFalse.ToString())

            {
                reader2 = new AudioFileReader("wrong.wav");
                waveOut2.Init(reader2);
                waveOut2.Play();
                btnSonraki.Enabled = true;
                puanYanlis++;
                

                if (puanYanlis >= 3|| seconds >= 120)
                {
                    //psonuc += pDogru - pYanlis;
                    puanYanlis = 0;
                    puanDogru = 0;
                    btnSonraki.Text = "Soru Getir";
                    lblTopla.Visible = false;
                    lblCikar.Visible = false;
                    lblToplaOrCikar.Visible = true;
                    lblMathPuan.Text = //psonuc.ToString();
                    //seconds = 0;
                    
                    lblPuanYanlis.Text = 0.ToString();
                    lblPuanDogru.Text = 0.ToString();
                    //label4.Text = //psonuc.ToString();

                    this.Hide();

                }
            }
        }

     
       private void btnCevapFalse_Click(object sender, EventArgs e)
        {
            //psonuc = pDogru - pYanlis;
            if (btnCevapFalse.Text == cevapTrue.ToString())
            {
                sound.SoundLocation = yol;
                sound.Play();
                btnCevapFalse.Enabled = false;
                btnCevapTrue.Enabled = false;
                btnSonraki.Enabled = true;
                puanDogru++;
                

            }

            if (int.Parse(label3.Text) >= 120)
            {
                //psonuc += pDogru - pYanlis;
                puanYanlis = 0;
                puanDogru = 0;
                btnSonraki.Text = "Soru Getir";
                lblTopla.Visible = false;
                lblCikar.Visible = false;
                lblToplaOrCikar.Visible = true;
               // lblMathPuan.Text = //psonuc.ToString();
                seconds = 0;
                FrmRabbitGame frm2 = new FrmRabbitGame();
                //label4.Text = //psonuc.ToString();


                lblPuanYanlis.Text = 0.ToString();
                lblPuanDogru.Text = 0.ToString();

                this.Hide();
            }
            if (btnCevapFalse.Text == cevapFalse.ToString())

            {
                reader2 = new AudioFileReader("wrong.wav");
                waveOut2.Init(reader2);
                waveOut2.Play();

                btnCevapFalse.Enabled = false;
                btnCevapTrue.Enabled = false;
                btnSonraki.Enabled = true;
                puanYanlis++;
                

                if (puanYanlis >= 3 ||  int.Parse(label3.Text)>=120)
                {
                    //psonuc += pDogru - pYanlis;
                    puanYanlis = 0;
                    puanDogru = 0;
                    btnSonraki.Text = "Soru Getir";
                    lblTopla.Visible = false;
                    lblCikar.Visible = false;
                    lblToplaOrCikar.Visible = true;
                    //label4.Text=//psonuc.ToString();
                    seconds = 0;
                    FrmRabbitGame frm2 = new FrmRabbitGame();
                    
                    
                    lblPuanYanlis.Text = 0.ToString();
                   lblPuanDogru.Text=0.ToString();
                   
                    this.Hide();
                    
                    

                }
            }
        }
    }
}