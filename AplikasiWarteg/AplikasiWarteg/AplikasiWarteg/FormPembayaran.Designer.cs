namespace AplikasiWarteg
{
    partial class FormPembayaran
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
            panel1 = new Panel();
            cmbPengiriman = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            cmbPayment = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbPengiriman);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(cmbPayment);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // cmbPengiriman
            // 
            cmbPengiriman.FormattingEnabled = true;
            cmbPengiriman.Items.AddRange(new object[] { "BANK MANDIRI", "GOPAY", "SHOPEEPAY", "LINK AJA", "BANK BNI", "DANA", "OVO" });
            cmbPengiriman.Location = new Point(289, 206);
            cmbPengiriman.Name = "cmbPengiriman";
            cmbPengiriman.Size = new Size(207, 23);
            cmbPengiriman.TabIndex = 9;
            cmbPengiriman.SelectedIndexChanged += cmbPengiriman_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(248, 151);
            label2.Name = "label2";
            label2.Size = new Size(286, 25);
            label2.TabIndex = 8;
            label2.Text = "PILIH METODE PENGIRIMAN";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(361, 263);
            button2.Name = "button2";
            button2.Size = new Size(74, 23);
            button2.TabIndex = 7;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Items.AddRange(new object[] { "BANK MANDIRI", "GOPAY", "SHOPEEPAY", "LINK AJA", "BANK BNI", "DANA", "OVO" });
            cmbPayment.Location = new Point(289, 103);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(207, 23);
            cmbPayment.TabIndex = 6;
            cmbPayment.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(78, 51);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 5;
            button1.Text = "<Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(248, 51);
            label1.Name = "label1";
            label1.Size = new Size(297, 25);
            label1.TabIndex = 4;
            label1.Text = "PILIH METODE PEMBAYARAN";
            // 
            // FormPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormPembayaran";
            Text = "FormPembayaran";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private ComboBox cmbPayment;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox cmbPengiriman;
    }
}