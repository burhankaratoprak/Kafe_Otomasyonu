using Kafesiniflari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Proje
{
    public partial class frmsiparis : Form
    {
        public frmsiparis()
        {
            InitializeComponent();

        }
        public static Dictionary<int, List<menukalitim>> masalar = new Dictionary<int, List<menukalitim>>();
        private int currentMasa;
        public static Personelkayit personelkayit = new Personelkayit();
        public Kafesiniflari.Ipersonelkayit interf = (Kafesiniflari.Ipersonelkayit)personelkayit;
        public static List<menukalitim> list = new List<menukalitim>();
        #region"Menü Kısmı"
        private void btnicecek_Click(object sender, EventArgs e)
        {
            tbcicecek.Visible = true;
            tbcyemek.Visible = false;
            tbctatli.Visible = false;
            tbcdondurma.Visible = false;
            tbcpasta.Visible = false;
            tbccorba.Visible = false;
            btnicecek.BackColor = Color.Gray;
            btnyemek.BackColor = SystemColors.ActiveCaption;
            btncorba.BackColor = SystemColors.ActiveCaption;
            btndondurma.BackColor = SystemColors.ActiveCaption;
            btnpasta.BackColor = SystemColors.ActiveCaption;
            btntatli.BackColor = SystemColors.ActiveCaption;
            panel2.Visible = false;
        }

        private void btnyemek_Click(object sender, EventArgs e)
        {
            tbcicecek.Visible = false;
            tbcyemek.Visible = true;
            tbctatli.Visible = false;
            tbcdondurma.Visible = false;
            tbcpasta.Visible = false;
            tbccorba.Visible = false;
            btnicecek.BackColor = SystemColors.ActiveCaption;
            btnyemek.BackColor = Color.Gray;
            btncorba.BackColor = SystemColors.ActiveCaption;
            btndondurma.BackColor = SystemColors.ActiveCaption;
            btnpasta.BackColor = SystemColors.ActiveCaption;
            btntatli.BackColor = SystemColors.ActiveCaption;
            panel2.Visible = false;

        }



        private void btncorba_Click(object sender, EventArgs e)
        {
            tbcicecek.Visible = false;
            tbcyemek.Visible = false;
            tbctatli.Visible = false;
            tbcdondurma.Visible = false;
            tbcpasta.Visible = false;
            tbccorba.Visible = true;
            btnicecek.BackColor = SystemColors.ActiveCaption;
            btnyemek.BackColor = SystemColors.ActiveCaption;
            btncorba.BackColor = Color.Gray;
            btndondurma.BackColor = SystemColors.ActiveCaption;
            btnpasta.BackColor = SystemColors.ActiveCaption;
            btntatli.BackColor = SystemColors.ActiveCaption;
            panel2.Visible = false;
        }

        private void btntatli_Click(object sender, EventArgs e)
        {
            tbcicecek.Visible = false;
            tbcyemek.Visible = false;
            tbctatli.Visible = true;
            tbcdondurma.Visible = false;
            tbcpasta.Visible = false;
            tbccorba.Visible = false;
            btnicecek.BackColor = SystemColors.ActiveCaption;
            btnyemek.BackColor = SystemColors.ActiveCaption;
            btncorba.BackColor = SystemColors.ActiveCaption;
            btndondurma.BackColor = SystemColors.ActiveCaption;
            btnpasta.BackColor = SystemColors.ActiveCaption;
            btntatli.BackColor = Color.Gray;
            panel2.Visible = false;
        }

        private void btnpasta_Click(object sender, EventArgs e)
        {
            tbcicecek.Visible = false;
            tbcyemek.Visible = false;
            tbctatli.Visible = false;
            tbcdondurma.Visible = false;
            tbcpasta.Visible = true;
            tbccorba.Visible = false;
            btnicecek.BackColor = SystemColors.ActiveCaption;
            btnyemek.BackColor = SystemColors.ActiveCaption;
            btncorba.BackColor = SystemColors.ActiveCaption;
            btndondurma.BackColor = SystemColors.ActiveCaption;
            btnpasta.BackColor = Color.Gray;
            btntatli.BackColor = SystemColors.ActiveCaption;
            panel2.Visible = false;
        }

        private void btndondurma_Click(object sender, EventArgs e)
        {
            tbcicecek.Visible = false;
            tbcyemek.Visible = false;
            tbctatli.Visible = false;
            tbcdondurma.Visible = true;
            tbcpasta.Visible = false;
            tbccorba.Visible = false;
            btnicecek.BackColor = SystemColors.ActiveCaption;
            btnyemek.BackColor = SystemColors.ActiveCaption;
            btncorba.BackColor = SystemColors.ActiveCaption;
            btndondurma.BackColor = Color.Gray;
            btnpasta.BackColor = SystemColors.ActiveCaption;
            btntatli.BackColor = SystemColors.ActiveCaption;
            panel2.Visible = false;
        }
        #endregion
        #region"Form Olayları"
        private void frmsiparis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void frmsiparis_Load(object sender, EventArgs e)
        {
            frmprskayt frmprskayt = new frmprskayt();
            frmprsgiris frmprsgiris = new frmprsgiris();
            int deger = frmprsgiris.idlist[0];
            if (deger >= 20)
            {
                btnsiparisiptal.Visible = false;
            }
            else if (deger < 20)
            {
                btnsiparisiptal.Visible = true;
            }
        }
        #endregion
        #region "Sıcak İçecekler"
        private void btncay_Click(object sender, EventArgs e)
        {

            icecek icecek = new icecek();
            sicak sck = new sicak();
            sck.adet = int.Parse(txtAdet.Text);
            sck.cay();
            sck.indirim();
            sck.toplamfiyat = (sck.adet * sck.fiyat) - sck.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sck);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnlatte_Click(object sender, EventArgs e)
        {
            icecek icecek = new icecek();
            sicak sck = new sicak();
            sck.adet = int.Parse(txtAdet.Text);
            sck.latte();
            sck.indirim();
            sck.toplamfiyat = (sck.adet * sck.fiyat) - sck.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sck);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnturkk_Click(object sender, EventArgs e)
        {
            icecek icecek = new icecek();
            sicak sck = new sicak();
            sck.adet = int.Parse(txtAdet.Text);
            sck.türkkahvesi();
            sck.indirim();
            sck.toplamfiyat = (sck.adet * sck.fiyat) - sck.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sck);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnamericano_Click(object sender, EventArgs e)
        {
            icecek icecek = new icecek();
            sicak sck = new sicak();
            sck.adet = int.Parse(txtAdet.Text);
            sck.americano();
            sck.indirim();
            sck.toplamfiyat = (sck.adet * sck.fiyat) - sck.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sck);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btncap_Click(object sender, EventArgs e)
        {
            icecek icecek = new icecek();
            sicak sck = new sicak();
            sck.adet = int.Parse(txtAdet.Text);
            sck.cappucino();
            sck.indirim();
            sck.toplamfiyat = (sck.adet * sck.fiyat) - sck.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sck);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnespresso_Click(object sender, EventArgs e)
        {
            icecek icecek = new icecek();
            sicak sck = new sicak();
            sck.adet = int.Parse(txtAdet.Text);
            sck.esppresso();
            sck.indirim();
            sck.toplamfiyat = (sck.adet * sck.fiyat) - sck.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sck);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
        #region "Soğuk İçecekler"
        private void btnlimonata_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.limonata();
            sgk.indirim();

            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }



        private void btnvmilkshake_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.vanilmilk();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btncmilkshake_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.ckmilk();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnilatte_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.icelatte();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void bntcilekmilkshake_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.clkmilk();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btniamericano_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.iceamericano();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnicap_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.icecapp();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnayran_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.ayran();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnsu_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.su();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnsprite_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.sprite();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnfanta_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.fanta();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnkola_Click(object sender, EventArgs e)
        {
            soguk sgk = new soguk();
            sgk.adet = int.Parse(txtAdet.Text);
            sgk.kola();
            sgk.toplamfiyat = (sgk.adet * sgk.fiyat) - sgk.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(sgk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
        #region"Dondurma"
        private void btnvanilyadond_Click(object sender, EventArgs e)
        {
            donabstrack dabs = new donabstrack();
            dondurma dondurma = new donabstrack();
            dondurma.adet = int.Parse(txtAdet.Text);
            dondurma.dkiloo();
            dondurma.vanilyadond();
            dondurma.toplamfiyat = (dondurma.adet * dondurma.fiyat) - dondurma.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(dondurma);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnmuzludond_Click(object sender, EventArgs e)
        {
            donabstrack dabs = new donabstrack();
            dondurma dondurma = new donabstrack();
            dondurma.adet = int.Parse(txtAdet.Text);
            dondurma.dkiloo();
            dondurma.muzdond();
            dondurma.toplamfiyat = (dondurma.adet * dondurma.fiyat) - dondurma.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(dondurma);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btncikodond_Click(object sender, EventArgs e)
        {
            donabstrack dabs = new donabstrack();
            dondurma dondurma = new donabstrack();
            dondurma.adet = int.Parse(txtAdet.Text);
            dondurma.dkiloo();
            dondurma.cikodond();
            dondurma.toplamfiyat = (dondurma.adet * dondurma.fiyat) - dondurma.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(dondurma);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();

        }

        private void btncilekdond_Click(object sender, EventArgs e)
        {
            donabstrack dabs = new donabstrack();
            dondurma dondurma = new donabstrack();
            dondurma.adet = int.Parse(txtAdet.Text);
            dondurma.dkiloo();
            dondurma.cilekdond();
            dondurma.toplamfiyat = (dondurma.adet * dondurma.fiyat) - dondurma.tindirim;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(dondurma);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
        #region"Fonksiyonlar"
        private decimal ToplamSutun()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    decimal hucreDegeri;
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out hucreDegeri))
                    {
                        toplam += hucreDegeri;
                    }
                }
            }

            return toplam;
        }
        private void Aktar()
        {
            // Tüm DataGridView verilerini Label'a aktar
            dataGridView2.Text = "Veriler:\n";

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    label1.Text += $"Ürün Adı: {row.Cells[0].Value}, Adet: {row.Cells[1].Value}, Tutar: {row.Cells[2].Value},İndirim: {row.Cells[3].Value}\n";
                }
            }
        }
        #endregion
        #region"Adet Kısmı"
        public int sayi;
        private void btn1_Click(object sender, EventArgs e)
        {
            sayi = 1;
            txtAdet.Text += sayi.ToString();


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            sayi = 2;
            txtAdet.Text += sayi.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            sayi = 3;
            txtAdet.Text += sayi.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            sayi = 4;
            txtAdet.Text += sayi.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            sayi = 5;
            txtAdet.Text += sayi.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            sayi = 6;
            txtAdet.Text += sayi.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sayi = 7;
            txtAdet.Text += sayi.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            sayi = 8;
            txtAdet.Text += sayi.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            sayi = 9;
            txtAdet.Text += sayi.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            sayi = 0;
            txtAdet.Text += sayi.ToString();
        }
        #endregion
        #region"Sipariş buton olayları"
        private void btnsiparisiptal_Click(object sender, EventArgs e)
        {
            frmprsgiris frmprsgiris = new frmprsgiris();
            MessageBox.Show("Sipariş İptal Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            masalar[currentMasa].Clear();

            // Refresh the DataGridView
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            frmprsgiris.Show();
            this.Hide();
        }
        private void btnhesap_Click(object sender, EventArgs e)
        {
            Aktar();
            label3.Text = $"Toplam Tutar: {ToplamSutun()}";
            panel2.Visible = true;
            timer.Tick += new EventHandler(timer_Tick);

            // Geri sayımı başlat
            timer.Start();
            masalar[currentMasa].Clear();

            // Refresh the DataGridView
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text.Length > 0)
            {
                // Son karakteri sil
                txtAdet.Text = txtAdet.Text.Substring(0, txtAdet.Text.Length - 1);
            }
            else
            {
                // TextBox boşsa bir uyarı mesajı göster
                MessageBox.Show("TextBox zaten boş.");
            }
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {

            frmmasa masa = new frmmasa();
            masalar[currentMasa].Clear();

            // Refresh the DataGridView
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            masa.Show();
            this.Hide();


        }

        private void btnsiparisv_Click(object sender, EventArgs e)
        {
            frmmasa frmmasa = new frmmasa();
            MessageBox.Show("Sipariş Verildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmmasa.Show();
            this.Hide();
        }
        #endregion
        #region"Zamanlayıcı"
        public void SetCurrentMasa(int masaNo)
        {
            currentMasa = masaNo;
            if (!masalar.ContainsKey(masaNo))
            {
                masalar[masaNo] = new List<menukalitim>();
            }
            else
            {
                var siparisListesi = masalar[currentMasa];
                dataGridView2.DataSource = siparisListesi;
                dataGridView2.Refresh();
            }
        }
        private int sure = 5;

        private void timer_Tick(object sender, EventArgs e)
        {
            label4.Text = "Kalan Süre : " + sure.ToString();

            if (sure > 0)
            {
                sure--;
            }
            else
            {
                timer.Stop();
                frmprsgiris frmprsgiris = new frmprsgiris();
                frmprsgiris.Show();
                this.Hide();
            }
        }
        #endregion
        #region "Pasta"

        private void btncikopas_Click(object sender, EventArgs e)
        {
            pasta pasta = new pasta();
            pasta.adet = int.Parse(txtAdet.Text);
            pasta.cikopasta();
            pasta.toplamfiyat = pasta.adet * pasta.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(pasta);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnmzulupas_Click(object sender, EventArgs e)
        {
            pasta pasta = new pasta();
            pasta.adet = int.Parse(txtAdet.Text);
            pasta.muzpasta();
            pasta.toplamfiyat = pasta.adet * pasta.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(pasta);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btncilekpas_Click(object sender, EventArgs e)
        {
            pasta pasta = new pasta();
            pasta.adet = int.Parse(txtAdet.Text);
            pasta.cilekpasta();
            pasta.toplamfiyat = pasta.adet * pasta.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(pasta);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnkrokpas_Click(object sender, EventArgs e)
        {
            pasta pasta = new pasta();
            pasta.adet = int.Parse(txtAdet.Text);
            pasta.Krokanlıpasta();
            pasta.toplamfiyat = pasta.adet * pasta.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(pasta);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
        #region "Sütlü Tatlılar"
        private void btnsufle_Click(object sender, EventArgs e)
        {
            tatli tatli = new tatli();
            tatli.adet = int.Parse(txtAdet.Text);
            tatli.sufle();
            tatli.toplamfiyat = tatli.adet * tatli.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(tatli);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnprofiterol_Click(object sender, EventArgs e)
        {
            tatli tatli = new tatli();
            tatli.adet = int.Parse(txtAdet.Text);
            tatli.Profiterol();
            tatli.toplamfiyat = tatli.adet * tatli.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(tatli);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnsutlac_Click(object sender, EventArgs e)
        {
            tatli tatli = new tatli();
            tatli.adet = int.Parse(txtAdet.Text);
            tatli.Sutlac();
            tatli.toplamfiyat = tatli.adet * tatli.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(tatli);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnkazandibi_Click(object sender, EventArgs e)
        {
            tatli tatli = new tatli();
            tatli.adet = int.Parse(txtAdet.Text);
            tatli.kazandibi();
            tatli.toplamfiyat = tatli.adet * tatli.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(tatli);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
        #region "Şerbetli Tatlılar"
        private void btnkunefe_Click(object sender, EventArgs e)
        {
            tatli tatli = new tatli();
            tatli.adet = int.Parse(txtAdet.Text);
            tatli.kunefe();
            tatli.toplamfiyat = tatli.adet * tatli.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(tatli);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnbaklava_Click(object sender, EventArgs e)
        {
            tatli tatli = new tatli();
            tatli.adet = int.Parse(txtAdet.Text);
            tatli.baklava();
            tatli.toplamfiyat = tatli.adet * tatli.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(tatli);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnsgkbaklava_Click(object sender, EventArgs e)
        {
            tatli tatli = new tatli();
            tatli.adet = int.Parse(txtAdet.Text);
            tatli.sogukbaklava();
            tatli.toplamfiyat = tatli.adet * tatli.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(tatli);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnkadayif_Click(object sender, EventArgs e)
        {
            tatli tatli = new tatli();
            tatli.adet = int.Parse(txtAdet.Text);
            tatli.burma();
            tatli.toplamfiyat = tatli.adet * tatli.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(tatli);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
        #region "Dürüm"
        private void btntavuk_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.Tavukdurum();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnet_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.Etdurum();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnsis_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.tavuksis();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnkebap_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.kebapdurum();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();

        }
        #endregion
        #region "Ana Yemekler"
        private void btnburger_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.hamburger();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnkofte_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.köfte();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.pizza();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnızgarat_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.tavuk();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnpilav_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.pilav();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnmakarna_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.makarna();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
        #region "Salatalar"
        private void btncsalata_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.cobansalata();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btntsalata_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.tavuksalata();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btntonbsalata_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.tonsalata();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btndiyetsalata_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.diyetsalata();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
        #region "Kahvaltılar"
        private void btnserpme_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.serpme();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnpkizartma_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.Patateskizartma();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnpeyinr_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.peynir();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnyogurt_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.Yogurt();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnzeytin_Click(object sender, EventArgs e)
        {
            yemekler yemekler = new yemekler();
            yemekler.adet = int.Parse(txtAdet.Text);
            yemekler.Zeytin();
            yemekler.toplamfiyat = yemekler.adet * yemekler.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(yemekler);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        #endregion
        #region "Çorbalar"
        private void btnmercimek_Click(object sender, EventArgs e)
        {
            corba corba = new corba();
            corba.adet = int.Parse(txtAdet.Text);
            corba.mercimek();
            corba.toplamfiyat = corba.adet * corba.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(corba);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btndomat_Click(object sender, EventArgs e)
        {
            corba corba = new corba();
            corba.adet = int.Parse(txtAdet.Text);
            corba.domates();
            corba.toplamfiyat = corba.adet * corba.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(corba);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btnezog_Click(object sender, EventArgs e)
        {
            corba corba = new corba();
            corba.adet = int.Parse(txtAdet.Text);
            corba.ezogelin();
            corba.toplamfiyat = corba.adet * corba.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(corba);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }

        private void btndugun_Click(object sender, EventArgs e)
        {
            corba corba = new corba();
            corba.adet = int.Parse(txtAdet.Text);
            corba.dugun();
            corba.toplamfiyat = corba.adet * corba.fiyat;
            txtAdet.Clear();
            var siparisListesi = masalar[currentMasa];
            siparisListesi.Add(corba);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = siparisListesi;
            dataGridView2.Refresh();
        }
        #endregion
    }
}
