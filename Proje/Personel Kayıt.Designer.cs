namespace Proje
{
    partial class frmprskayt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprskayt));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cbxtecrube = new ComboBox();
            btngeri = new Button();
            ımageList1 = new ImageList(components);
            btnsil = new Button();
            ımageList2 = new ImageList(components);
            btnkaydet = new Button();
            pictureBox5 = new PictureBox();
            dtpisegiriş = new DateTimePicker();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            mskttel = new MaskedTextBox();
            mskid = new MaskedTextBox();
            txtadsoyad = new TextBox();
            ımageList3 = new ImageList(components);
            btnkapat = new Button();
            groupBox2 = new GroupBox();
            lstpersonel = new DataGridView();
            button4 = new Button();
            toolTip1 = new ToolTip(components);
            id = new DataGridViewTextBoxColumn();
            AdSoyad = new DataGridViewTextBoxColumn();
            Tecrube = new DataGridViewTextBoxColumn();
            tel = new DataGridViewTextBoxColumn();
            isgt = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstpersonel).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cbxtecrube);
            groupBox1.Controls.Add(btngeri);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(dtpisegiriş);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(mskttel);
            groupBox1.Controls.Add(mskid);
            groupBox1.Controls.Add(txtadsoyad);
            groupBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(21, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 382);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt";
            // 
            // cbxtecrube
            // 
            cbxtecrube.FormattingEnabled = true;
            cbxtecrube.Location = new Point(97, 158);
            cbxtecrube.Name = "cbxtecrube";
            cbxtecrube.Size = new Size(244, 45);
            cbxtecrube.TabIndex = 2;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.Transparent;
            btngeri.FlatAppearance.BorderSize = 0;
            btngeri.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btngeri.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.ImageKey = "arrow.png";
            btngeri.ImageList = ımageList1;
            btngeri.Location = new Point(11, 322);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(64, 45);
            btngeri.TabIndex = 5;
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "arrow.png");
            ımageList1.Images.SetKeyName(1, "add-user.png");
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Transparent;
            btnsil.FlatStyle = FlatStyle.Popup;
            btnsil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsil.ForeColor = Color.Black;
            btnsil.ImageAlign = ContentAlignment.BottomRight;
            btnsil.ImageKey = "007-delete.png";
            btnsil.ImageList = ımageList2;
            btnsil.Location = new Point(240, 322);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(114, 50);
            btnsil.TabIndex = 7;
            btnsil.Text = "SİL";
            btnsil.TextAlign = ContentAlignment.MiddleLeft;
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "001-save-instagram.png");
            ımageList2.Images.SetKeyName(1, "007-delete.png");
            ımageList2.Images.SetKeyName(2, "search.png");
            ımageList2.Images.SetKeyName(3, "add-user.png");
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.Transparent;
            btnkaydet.FlatStyle = FlatStyle.Popup;
            btnkaydet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnkaydet.ForeColor = Color.Black;
            btnkaydet.ImageAlign = ContentAlignment.BottomRight;
            btnkaydet.ImageKey = "001-save-instagram.png";
            btnkaydet.ImageList = ımageList2;
            btnkaydet.Location = new Point(95, 322);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(126, 50);
            btnkaydet.TabIndex = 6;
            btnkaydet.Text = "KAYDET";
            btnkaydet.TextAlign = ContentAlignment.MiddleLeft;
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._006_calendar1;
            pictureBox5.Location = new Point(31, 263);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // dtpisegiriş
            // 
            dtpisegiriş.CalendarMonthBackground = Color.AliceBlue;
            dtpisegiriş.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpisegiriş.Location = new Point(95, 263);
            dtpisegiriş.Name = "dtpisegiriş";
            dtpisegiriş.Size = new Size(246, 43);
            dtpisegiriş.TabIndex = 4;
            toolTip1.SetToolTip(dtpisegiriş, "İşe Giriş Tarihi");
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = Properties.Resources.WhatsApp_Görsel_2023_11_04_saat_23_16_49_0872caaa;
            pictureBox4.Location = new Point(31, 158);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngwing_com;
            pictureBox3.Location = new Point(31, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(31, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.phone_call;
            pictureBox1.Location = new Point(31, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // mskttel
            // 
            mskttel.BackColor = Color.AliceBlue;
            mskttel.BorderStyle = BorderStyle.FixedSingle;
            mskttel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskttel.Location = new Point(97, 214);
            mskttel.Mask = "(999) 000-0000";
            mskttel.Name = "mskttel";
            mskttel.Size = new Size(244, 43);
            mskttel.TabIndex = 3;
            toolTip1.SetToolTip(mskttel, "Telefon No Giriniz");
            // 
            // mskid
            // 
            mskid.BackColor = Color.AliceBlue;
            mskid.BorderStyle = BorderStyle.FixedSingle;
            mskid.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskid.Location = new Point(97, 38);
            mskid.Mask = "00";
            mskid.Name = "mskid";
            mskid.RightToLeft = RightToLeft.No;
            mskid.Size = new Size(244, 43);
            mskid.TabIndex = 0;
            toolTip1.SetToolTip(mskid, "Id'nizi Girin");
            mskid.ValidatingType = typeof(int);
            // 
            // txtadsoyad
            // 
            txtadsoyad.BackColor = Color.AliceBlue;
            txtadsoyad.BorderStyle = BorderStyle.FixedSingle;
            txtadsoyad.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtadsoyad.Location = new Point(95, 98);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.PlaceholderText = "Ad ve Soyad Girin";
            txtadsoyad.Size = new Size(246, 43);
            txtadsoyad.TabIndex = 1;
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "close.png");
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.Transparent;
            btnkapat.FlatAppearance.BorderSize = 0;
            btnkapat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnkapat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnkapat.FlatStyle = FlatStyle.Flat;
            btnkapat.ImageKey = "close.png";
            btnkapat.ImageList = ımageList3;
            btnkapat.Location = new Point(1020, -2);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(47, 43);
            btnkapat.TabIndex = 7;
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lstpersonel);
            groupBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(414, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(653, 382);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Listele";
            // 
            // lstpersonel
            // 
            lstpersonel.BackgroundColor = SystemColors.Control;
            lstpersonel.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            lstpersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            lstpersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstpersonel.Columns.AddRange(new DataGridViewColumn[] { id, AdSoyad, Tecrube, tel, isgt });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            lstpersonel.DefaultCellStyle = dataGridViewCellStyle3;
            lstpersonel.Location = new Point(20, 38);
            lstpersonel.Name = "lstpersonel";
            lstpersonel.RowTemplate.Height = 25;
            lstpersonel.Size = new Size(614, 325);
            lstpersonel.TabIndex = 10;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ImageKey = "add-user.png";
            button4.ImageList = ımageList2;
            button4.Location = new Point(0, -4);
            button4.Name = "button4";
            button4.Size = new Size(40, 47);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            toolTip1.ShowAlways = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            id.FillWeight = 17F;
            id.HeaderText = "id";
            id.Name = "id";
            id.Width = 53;
            // 
            // AdSoyad
            // 
            AdSoyad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            AdSoyad.FillWeight = 17F;
            AdSoyad.HeaderText = "Ad Soyad";
            AdSoyad.Name = "AdSoyad";
            AdSoyad.Width = 116;
            // 
            // Tecrube
            // 
            Tecrube.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Tecrube.FillWeight = 17F;
            Tecrube.HeaderText = "Tecrübe";
            Tecrube.Name = "Tecrube";
            Tecrube.Width = 103;
            // 
            // tel
            // 
            tel.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            tel.FillWeight = 17F;
            tel.HeaderText = "Telefon Numarası";
            tel.Name = "tel";
            tel.Width = 168;
            // 
            // isgt
            // 
            isgt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            isgt.DefaultCellStyle = dataGridViewCellStyle2;
            isgt.FillWeight = 17F;
            isgt.HeaderText = "İşe Giriş Tarihi";
            isgt.Name = "isgt";
            isgt.Width = 141;
            // 
            // frmprskayt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Resim31;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 436);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(btnkapat);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmprskayt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Kayıt";
            Load += frmprskayt_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lstpersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtadsoyad;
        private PictureBox pictureBox1;
        private MaskedTextBox mskttel;
        private MaskedTextBox mskid;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DateTimePicker dtpisegiriş;
        private Button btnkaydet;
        private Button btngeri;
        private ImageList ımageList1;
        private ImageList ımageList2;
        private ImageList ımageList3;
        private Button btnkapat;
        private GroupBox groupBox2;
        private Button button4;
        public DataGridView lstpersonel;
        private ToolTip toolTip1;
        public ComboBox cbxtecrube;
        public Button btnsil;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn AdSoyad;
        private DataGridViewTextBoxColumn Tecrube;
        private DataGridViewTextBoxColumn tel;
        private DataGridViewTextBoxColumn isgt;
    }
}