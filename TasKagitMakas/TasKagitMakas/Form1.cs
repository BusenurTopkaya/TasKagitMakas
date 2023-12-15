using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        int secim;
        int kulPuan = 0;
        int pcPuan = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblKullaniciPuan.Text = kulPuan.ToString();
            lblPcPuan.Text = pcPuan.ToString();
        }

        private void rdbKagit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKagit.Checked)
            {
                secim = 2;
            }
        }

        private void rdbTas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTas.Checked)
            {
                secim = 1;
            }
        }

        private void rdbMakas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMakas.Checked)
            {
                secim = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1- taş
            //2- kağıt
            //3- Makas


            Random rnd = new Random();
            int sayi = rnd.Next(1, 4);


            switch (sayi)
            {
                case 1:
                    MessageBox.Show("Bilgisayar Tahmini Taş");
                    break;
                case 2:
                    MessageBox.Show("Bilgisayar Tahmini Kağıt");
                    break;
                case 3:
                    MessageBox.Show("Bilgisayar Tahmini Makas");
                    break;
                default:
                    break;
            }

            if (sayi == 1 && secim == 2)
            {
                kulPuan += 10;
            }
            else if (sayi == 1 && secim == 3)
            {
                pcPuan += 10;
            }
            else if (sayi == 2 && secim == 1)
            {
                pcPuan += 10;
            }
            else if (sayi == 2 && secim == 3)
            {
                kulPuan += 10;
            }
            else if (sayi == 3 && secim == 1)
            {
                kulPuan += 10;
            }
            else if (sayi == 3 && secim == 2)
            {
                pcPuan += 10;
            }

            lblKullaniciPuan.Text = kulPuan.ToString();
            lblPcPuan.Text = pcPuan.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;

            if (kulPuan >= 40)
            {
                timer1.Stop();
                result = MessageBox.Show("Tebrikler Oyunu Kazandınız. Devam etmek istiyor musunuz?","Mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            }
            else if (pcPuan >= 40)
            {
                timer1.Stop();
                result = MessageBox.Show("Üzgünüz Oyunu Bilgisayar Kazandı. Devam Etmek istiyor musunuz?","Mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }


            if (result == DialogResult.Yes)
            {
                kulPuan = 0;
                pcPuan = 0;

                rdbKagit.Enabled = true;
                rdbMakas.Enabled = true;
                rdbTas.Enabled = true;
                button1.Enabled = true;

                lblKullaniciPuan.Text = kulPuan.ToString();
                lblPcPuan.Text = pcPuan.ToString();
                timer1.Start();
            }
            else if(result == DialogResult.No)
            {
                Close();
            }
        }
    }
}
