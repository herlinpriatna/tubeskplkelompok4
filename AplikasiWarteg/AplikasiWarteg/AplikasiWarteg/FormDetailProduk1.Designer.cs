namespace AplikasiWarteg
{
    partial class FormDetailProduk1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailProduk1));
            panel1 = new Panel();
            btnKembali = new Button();
            lblDeskripsi = new Label();
            lblHarga = new Label();
            lblProduk = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKembali);
            panel1.Controls.Add(lblDeskripsi);
            panel1.Controls.Add(lblHarga);
            panel1.Controls.Add(lblProduk);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(36, 33);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 23);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "<Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.Location = new Point(419, 175);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(290, 152);
            lblDeskripsi.TabIndex = 3;
            lblDeskripsi.Text = "Nasi Rames Ayam yang terdiri dari ayam dan berbagai lauk yang bisa dipadupadankan sesuai keinginan dan selera";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHarga.Location = new Point(419, 126);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(95, 22);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Rp18.000";
            // 
            // lblProduk
            // 
            lblProduk.AutoSize = true;
            lblProduk.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduk.Location = new Point(418, 89);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(198, 25);
            lblProduk.TabIndex = 1;
            lblProduk.Text = "Nasi Rames Ayam";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormDetailProduk1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormDetailProduk1";
            Text = "FormDetailProduk1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKembali;
        private Label lblDeskripsi;
        private Label lblHarga;
        private Label lblProduk;
        private PictureBox pictureBox1;
    }
}