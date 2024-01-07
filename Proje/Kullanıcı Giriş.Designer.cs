namespace Proje
{
    partial class frmkullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkullanici));
            txtkadi = new TextBox();
            txtparola = new TextBox();
            btngiris = new Button();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            btnkapat = new Button();
            ımageList1 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // txtkadi
            // 
            txtkadi.Location = new Point(32, 122);
            txtkadi.Multiline = true;
            txtkadi.Name = "txtkadi";
            txtkadi.PlaceholderText = "Kullanıcı Adı";
            txtkadi.Size = new Size(157, 23);
            txtkadi.TabIndex = 0;
            toolTip1.SetToolTip(txtkadi, "Admin");
            // 
            // txtparola
            // 
            txtparola.Location = new Point(32, 165);
            txtparola.Name = "txtparola";
            txtparola.PlaceholderText = "Parola";
            txtparola.Size = new Size(157, 23);
            txtparola.TabIndex = 1;
            toolTip1.SetToolTip(txtparola, "Admin");
            txtparola.UseSystemPasswordChar = true;
            // 
            // btngiris
            // 
            btngiris.BackColor = SystemColors.ActiveCaption;
            btngiris.FlatStyle = FlatStyle.Popup;
            btngiris.Location = new Point(42, 232);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(120, 45);
            btngiris.TabIndex = 2;
            btngiris.Text = "Giriş";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // timer
            // 
            timer.Interval = 25;
            timer.Tick += timer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 37);
            label1.TabIndex = 3;
            label1.Text = "HOŞ GELDİNİZ";
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.Transparent;
            btnkapat.FlatAppearance.BorderSize = 0;
            btnkapat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnkapat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnkapat.FlatStyle = FlatStyle.Flat;
            btnkapat.ImageKey = "close.png";
            btnkapat.ImageList = ımageList1;
            btnkapat.Location = new Point(519, -3);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(50, 45);
            btnkapat.TabIndex = 6;
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
            // toolTip1
            // 
            toolTip1.ShowAlways = true;
            // 
            // frmkullanici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.pngwing1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(564, 363);
            Controls.Add(btnkapat);
            Controls.Add(label1);
            Controls.Add(btngiris);
            Controls.Add(txtparola);
            Controls.Add(txtkadi);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmkullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş";
            FormClosing += frmkullanici_FormClosing;
            Load += frmkullanici_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtkadi;
        private TextBox txtparola;
        private Button btngiris;
        private System.Windows.Forms.Timer timer;
        private Label label1;
        private Button btnkapat;
        private ImageList ımageList1;
        private ToolTip toolTip1;
    }
}