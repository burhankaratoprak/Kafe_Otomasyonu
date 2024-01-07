using Kafesiniflari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Proje
{
    public partial class frmksecme : Form
    {


        public frmksecme()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnsistemgiris_Click(object sender, EventArgs e)
        {
            frmprsgiris form1 = new frmprsgiris();
            form1.Show();
            this.Hide();
        }
        private void btnpkaydet_Click(object sender, EventArgs e)
        {
            frmprskayt form3 = new frmprskayt();
            form3.Show();
            this.Hide();
        }

        private void ksecme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
