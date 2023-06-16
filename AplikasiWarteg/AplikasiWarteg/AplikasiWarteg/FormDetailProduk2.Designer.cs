namespace AplikasiWarteg
{
    partial class FormDetailProduk2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailProduk2));
            lblDeskripsi = new Label();
            panel1 = new Panel();
            btnKembali = new Button();
            lblHarga = new Label();
            lblProduk = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.Location = new Point(419, 175);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(290, 152);
            lblDeskripsi.TabIndex = 3;
            lblDeskripsi.Text = "nasi putih anget dan kualitas terbaik membuat anda kenyang dan tentunya sehat ";
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
            panel1.TabIndex = 1;
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
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHarga.Location = new Point(419, 126);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(84, 22);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Rp4.500";
            // 
            // lblProduk
            // 
            lblProduk.AutoSize = true;
            lblProduk.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduk.Location = new Point(418, 89);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(111, 25);
            lblProduk.TabIndex = 1;
            lblProduk.Text = "Nasi Putih";
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
            // FormDetailProduk2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormDetailProduk2";
            Text = "FormDetailProduk2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDeskripsi;
        private Panel panel1;
        private Button btnKembali;
        private Label lblHarga;
        private Label lblProduk;
        private PictureBox pictureBox1;
    }
}