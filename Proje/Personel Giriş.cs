using Kafesiniflari;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace Proje
{
    public partial class frmprsgiris : Form
    {
        public static List<int> idlist = new List<int>();
        public frmprsgiris()
        {
            InitializeComponent();

        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncgiris_Click(object sender, EventArgs e)
        {
            frmprskayt frmprskayt = new frmprskayt();

            int girilenNumara = Convert.ToInt32(txtid.Text);
            var personel = frmprskayt.list.FirstOrDefault(p => p.id == girilenNumara);
            if (personel != null)
            {
                frmmasa masa = new frmmasa();
                masa.Show();
                this.Hide();
                idlist.Add(int.Parse(txtid.Text));
            }
            else
            {
                MessageBox.Show("Personel bulunamadý. Tekrar deneyiniz.");
            }
        }

        #region"Buton Numaralarý"

        private void btn1_Click(object sender, EventArgs e)
        {
            txtid.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtid.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtid.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtid.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtid.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtid.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtid.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtid.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtid.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtid.Text += "0";
        }

        private void frmprsgiris_Load(object sender, EventArgs e)
        {
            idlist.Clear();
        }
    }
}
#endregion