using Kafesiniflari;
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


namespace Proje
{
    public partial class frmmasa : Form
    {


        public frmmasa()
        {
            InitializeComponent();
        }
       
        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            frmprsgiris frmprsgiris = new frmprsgiris();
            frmprsgiris.Show();
            this.Hide();
        }

        private void Masa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region"Masalar"
        private void btn1_Click(object sender, EventArgs e)
        {

            frmsiparis frmsiparis = new frmsiparis();
            frmsiparis.SetCurrentMasa(1);
            frmsiparis.label2.Text = "1";
            frmsiparis.Show();
            this.Hide();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            frmsiparis frmsiparis = new frmsiparis();
            frmsiparis.SetCurrentMasa(2);
            frmsiparis.label2.Text = "2";
            frmsiparis.Show();
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            frmsiparis frmsiparis = new frmsiparis();
            frmsiparis.SetCurrentMasa(3);
            frmsiparis.label2.Text = "3";
            frmsiparis.Show();
            this.Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            frmsiparis frmsiparis = new frmsiparis();
            frmsiparis.SetCurrentMasa(4);
            frmsiparis.label2.Text = "4";
            frmsiparis.Show();
            this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            frmsiparis frmsiparis = new frmsiparis();
            frmsiparis.SetCurrentMasa(5);
            frmsiparis.label2.Text = "5";
            frmsiparis.Show();
            this.Hide();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            frmsiparis frmsiparis = new frmsiparis();
            frmsiparis.SetCurrentMasa(6);
            frmsiparis.label2.Text = "6";
            frmsiparis.Show();
            this.Hide();
        }
      

    }
}
  #endregion