namespace WartegBerkah
{
    partial class DaftarMenuPenjual
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(1891, 53);
            button6.Name = "button6";
            button6.Size = new Size(200, 75);
            button6.TabIndex = 29;
            button6.Text = "Keluar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1338, 53);
            button5.Name = "button5";
            button5.Size = new Size(298, 75);
            button5.TabIndex = 28;
            button5.Text = "Daftar Menu";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(919, 53);
            button4.Name = "button4";
            button4.Size = new Size(298, 75);
            button4.TabIndex = 27;
            button4.Text = "Dashboard";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1232, 588);
            button3.Name = "button3";
            button3.Size = new Size(270, 85);
            button3.TabIndex = 25;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(888, 588);
            button2.Name = "button2";
            button2.Size = new Size(270, 85);
            button2.TabIndex = 24;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(532, 588);
            button1.Name = "button1";
            button1.Size = new Size(270, 85);
            button1.TabIndex = 23;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(532, 407);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1275, 57);
            textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(532, 287);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1275, 57);
            textBox1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(197, 407);
            label2.Name = "label2";
            label2.Size = new Size(121, 50);
            label2.TabIndex = 20;
            label2.Text = "Harga";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 287);
            label1.Name = "label1";
            label1.Size = new Size(280, 50);
            label1.TabIndex = 19;
            label1.Text = "Nama Makanan";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(197, 788);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1703, 260);
            listBox1.TabIndex = 30;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // DaftarMenuPenjual
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2129, 1184);
            Controls.Add(listBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DaftarMenuPenjual";
            Text = "DaftarMenuPenjual";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
    }
}