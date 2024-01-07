using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class frmkullanici : Form
    {
        public frmkullanici()
        {
            InitializeComponent();
        }
        private int indeks;


        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtkadi.Text == "Admin" && txtparola.Text == "Admin")
            {
                frmksecme ksecme = new frmksecme();
                ksecme.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı yada şifre hatalı.Tekrar deneyiniz");
            }
        }

        private void frmkullanici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmkullanici_Load(object sender, EventArgs e)
        {


            // Timer'ı başlat
            timer.Start();
            label1.Location = new System.Drawing.Point(Width, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            label1.Left -= 5; // 5 piksel sola kaydır

            // Eğer label formun dışına çıkarsa başa al
            if (label1.Right < 0)
            {
                label1.Left = Width;
            }
        }
        private string GetKayanMetin(string metin, int indeks)
        {
            // Metni kaydırarak döndür
            return metin.Substring(indeks) + metin.Substring(0, indeks);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
