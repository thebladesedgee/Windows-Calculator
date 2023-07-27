using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        public void VeriyiKaydet()
        {
            Context context = new Context();
            HesaplamaGeçmişi hg = new HesaplamaGeçmişi();
            double geçmiş = double.Parse(txtSonuç.Text);
            hg.sonuç = geçmiş;
            context.geçmiş.Add(hg);
            context.SaveChanges();
        }

        double sayı1;
        double sayı2;
        char işlem;
        bool ekranı_temizle;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 379;
            txtSonuç.Width = 336;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayı1 = 0;
            sayı2 = 0;
            txtSonuç.Text = "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "3";
        }

        private void txtSonuç_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle= false;
            }



            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "2";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (ekranı_temizle)
            {
                txtSonuç.Text = "";

                ekranı_temizle = false;
            }
            if (txtSonuç.Text == "0")
            {
                txtSonuç.Text = "";
            }
            txtSonuç.Text += "0";
        }

        private void btnArtı_Click(object sender, EventArgs e)
        {
            işlem = '+';
            ekranı_temizle = true;
            sayı1 = double.Parse(txtSonuç.Text);
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            işlem = '-';
            ekranı_temizle = true;
            sayı1 = double.Parse(txtSonuç.Text);
        }

        private void btnBölü_Click(object sender, EventArgs e)
        {
            işlem = '/';
            ekranı_temizle = true;
            sayı1 = double.Parse(txtSonuç.Text);
        }

        private void btnÇarpı_Click(object sender, EventArgs e)
        {
            işlem = '*';
            ekranı_temizle = true;
            sayı1 = double.Parse(txtSonuç.Text);
        }

        private void btnEşit_Click(object sender, EventArgs e)
        {
            
            sayı2 = double.Parse(txtSonuç.Text);
            double sonuç = 0;
            
            switch (işlem)
            {
                case '+':
                    sonuç = sayı1 + sayı2;
                    break;
                case '-':
                    sonuç = sayı1 - sayı2;
                    break;
                case '*':
                    sonuç = sayı1 * sayı2;
                    break;
                case '/':
                    sonuç = sayı1 / sayı2;
                    break;
                case '%':
                    sonuç = sayı1 % sayı2;
                    break;
                  
            }

            txtSonuç.Text = sonuç.ToString();

            VeriyiKaydet();
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            double kare = double.Parse(txtSonuç.Text);
            txtSonuç.Text = (kare * kare).ToString();
            VeriyiKaydet();
        }

        private void btnKüp_Click(object sender, EventArgs e)
        {
            double küp = double.Parse(txtSonuç.Text);
            txtSonuç.Text = (küp * küp * küp).ToString();
            VeriyiKaydet();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            double E = Math.E;
            txtSonuç.Text = E.ToString();
            VeriyiKaydet();

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            txtSonuç.Text = pi.ToString();
            VeriyiKaydet();
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            double abs = double.Parse(txtSonuç.Text);
          
            txtSonuç.Text = Math.Abs(abs).ToString();
            VeriyiKaydet();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

            double sin = double.Parse(txtSonuç.Text);
            txtSonuç.Text = Math.Sin(sin).ToString();
            VeriyiKaydet();

        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            double sayı = double.Parse(txtSonuç.Text);
            double factoriyel = 1;
            for (double i = 1; i <= sayı; i++)
            {
                factoriyel *= i;
            }

            txtSonuç.Text = factoriyel.ToString();

            VeriyiKaydet();
        }

        private void btnKarekök_Click(object sender, EventArgs e)
        {
            double karekök = double.Parse(txtSonuç.Text);
            txtSonuç.Text = Math.Sqrt(karekök).ToString();
            VeriyiKaydet();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            // rad cinsinden değeri
            double cos = double.Parse(txtSonuç.Text);
            txtSonuç.Text = Math.Cos(cos).ToString();
            VeriyiKaydet();
        }

        private void btnAE_Click(object sender, EventArgs e)
        {
            double eksilisayı = double.Parse(txtSonuç.Text);
            txtSonuç.Text = (-1 * eksilisayı).ToString();
        }

        private void btnVirgül_Click(object sender, EventArgs e)
        {
            if (txtSonuç.Text.IndexOf(",")<1)
            {
                txtSonuç.Text += ",";
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (txtSonuç.Text.Length>1)
            {
                txtSonuç.Text = txtSonuç.Text.Substring(0, txtSonuç.Text.Length - 1);

            }
            else
            {
                txtSonuç.Text = "0";
            }
        }

        private void bilimselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 610;
            txtSonuç.Width = 566;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 379;
            txtSonuç.Width = 336;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult çıkmakistiyormusunuz;
            çıkmakistiyormusunuz = MessageBox.Show("uygulamadan çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (çıkmakistiyormusunuz == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("işleminize devam ediniz");
            }

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            işlem = '%';
            ekranı_temizle = true;
            sayı1 = double.Parse(txtSonuç.Text);
            VeriyiKaydet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yüzde = double.Parse(txtSonuç.Text);
            yüzde = yüzde / 100;
            txtSonuç.Text = yüzde.ToString();
            VeriyiKaydet();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = double.Parse(txtSonuç.Text);
            txtSonuç.Text = Math.Tan(tan).ToString();
            VeriyiKaydet();
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            double cot = double.Parse(txtSonuç.Text);
            txtSonuç.Text = Math.Tan(cot).ToString();
            VeriyiKaydet();
        }

        private void geçmişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Geçmiş geçmiş = new Geçmiş();
            geçmiş.Show();
        }
    }
}
