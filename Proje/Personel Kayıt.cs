using Kafesiniflari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class frmprskayt : Form
    {
        public static List<Ipersonelkayit> list = new List<Ipersonelkayit>();
        public static Personelkayit personelkayit = new Personelkayit();
        public Kafesiniflari.Ipersonelkayit interf = (Kafesiniflari.Ipersonelkayit)personelkayit;
        private DataTable dataTable;
        public frmprskayt()
        {
            InitializeComponent();
            cbxtecrube.Items.Add(interf.sef());
            cbxtecrube.Items.Add(interf.garson());
            lstpersonel.DataSource = dataTable;

        }
        private void btngeri_Click(object sender, EventArgs e)
        {

            frmksecme frmksecme = new frmksecme();
            frmksecme.Show();
            this.Hide();
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            // Personelkayit.id_listesi.Add(int.Parse(mskid.Text));
            // Yeni bir veri oluşturup BindingSource'a ekle
            list.Add(new Personelkayit
            {
                id = int.Parse(mskid.Text),
                telno = mskttel.Text,
                adsoyad = txtadsoyad.Text,
                tecrube = cbxtecrube.SelectedItem.ToString(),
                isegiris = dtpisegiriş.Value
            });
            // BindingSource'ı güncelle
            bindingSource.ResetBindings(false);

        }
        private BindingSource bindingSource;
        private void frmprskayt_Load(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            lstpersonel.DataSource = bindingSource;

            // lstpersonel sütunlarını elle ekleyin ya da tasarım zamanında ekleyin
            lstpersonel.Columns.Clear();

            // Uygulama başladığında verileri BindingSource'a ve DataGridView'a ekle
            bindingSource.DataSource = list;
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (lstpersonel.SelectedRows.Count > 0)
            {
                lstpersonel.Rows.RemoveAt(lstpersonel.SelectedRows[0].Index);

            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }
    }

}

