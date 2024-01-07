namespace Proje
{
    partial class frmksecme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmksecme));
            btnkapat = new Button();
            ımageList1 = new ImageList(components);
            btnpkaydet = new Button();
            ımageList2 = new ImageList(components);
            btnsistemgiris = new Button();
            SuspendLayout();
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.Transparent;
            btnkapat.FlatAppearance.BorderSize = 0;
            btnkapat.FlatStyle = FlatStyle.Popup;
            btnkapat.ImageAlign = ContentAlignment.MiddleLeft;
            btnkapat.ImageKey = "close.png";
            btnkapat.ImageList = ımageList1;
            btnkapat.Location = new Point(578, 12);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(42, 42);
            btnkapat.TabIndex = 0;
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "close.png");
            // 
            // btnpkaydet
            // 
            btnpkaydet.BackColor = SystemColors.ActiveCaption;
            btnpkaydet.FlatStyle = FlatStyle.Popup;
            btnpkaydet.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnpkaydet.ForeColor = SystemColors.ButtonHighlight;
            btnpkaydet.ImageKey = "user.png";
            btnpkaydet.ImageList = ımageList2;
            btnpkaydet.Location = new Point(95, 109);
            btnpkaydet.Name = "btnpkaydet";
            btnpkaydet.Size = new Size(178, 211);
            btnpkaydet.TabIndex = 1;
            btnpkaydet.Text = "Personel Kaydet";
            btnpkaydet.TextAlign = ContentAlignment.BottomCenter;
            btnpkaydet.UseVisualStyleBackColor = false;
            btnpkaydet.Click += btnpkaydet_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "user.png");
            ımageList2.Images.SetKeyName(1, "cafe.png");
            // 
            // btnsistemgiris
            // 
            btnsistemgiris.BackColor = SystemColors.ActiveCaption;
            btnsistemgiris.FlatStyle = FlatStyle.Popup;
            btnsistemgiris.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnsistemgiris.ForeColor = SystemColors.ButtonHighlight;
            btnsistemgiris.ImageKey = "cafe.png";
            btnsistemgiris.ImageList = ımageList2;
            btnsistemgiris.Location = new Point(352, 110);
            btnsistemgiris.Name = "btnsistemgiris";
            btnsistemgiris.Size = new Size(191, 213);
            btnsistemgiris.TabIndex = 1;
            btnsistemgiris.Text = "Kafe Sistemine Giriş";
            btnsistemgiris.TextAlign = ContentAlignment.BottomCenter;
            btnsistemgiris.UseVisualStyleBackColor = false;
            btnsistemgiris.Click += btnsistemgiris_Click;
            // 
            // frmksecme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.Resim32;
            ClientSize = new Size(654, 405);
            Controls.Add(btnsistemgiris);
            Controls.Add(btnpkaydet);
            Controls.Add(btnkapat);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmksecme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem Seçme";
            FormClosing += ksecme_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnkapat;
        private ImageList ımageList1;
        private Button btnpkaydet;
        private Button btnsistemgiris;
        private ImageList ımageList2;
    }
}