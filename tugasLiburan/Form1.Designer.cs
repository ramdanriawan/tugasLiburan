namespace tugasLiburan
{
    partial class formMakan
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
            this.chkNasi = new System.Windows.Forms.CheckBox();
            this.chkAyam = new System.Windows.Forms.CheckBox();
            this.chkSayur = new System.Windows.Forms.CheckBox();
            this.cmbTambahMenu = new System.Windows.Forms.ComboBox();
            this.txtJumlahTambahMenu = new System.Windows.Forms.TextBox();
            this.lblTambahMenu = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHargaNasi = new System.Windows.Forms.Label();
            this.lblHargaAyam = new System.Windows.Forms.Label();
            this.lblHargaSayur = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalHargaNasi = new System.Windows.Forms.Label();
            this.lblTotalHargaAyam = new System.Windows.Forms.Label();
            this.lblTotalHargaSayur = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblJumlahNasi = new System.Windows.Forms.Label();
            this.lblJumlahAyam = new System.Windows.Forms.Label();
            this.lblJumlahSayur = new System.Windows.Forms.Label();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.btnTambahMenu = new System.Windows.Forms.Button();
            this.btnKurangMenu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUangBayar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalKembalian = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkNasi
            // 
            this.chkNasi.AutoSize = true;
            this.chkNasi.Checked = true;
            this.chkNasi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNasi.Location = new System.Drawing.Point(15, 90);
            this.chkNasi.Name = "chkNasi";
            this.chkNasi.Size = new System.Drawing.Size(47, 17);
            this.chkNasi.TabIndex = 0;
            this.chkNasi.Text = "Nasi";
            this.chkNasi.UseVisualStyleBackColor = true;
            this.chkNasi.CheckedChanged += new System.EventHandler(this.chkNasi_CheckedChanged);
            // 
            // chkAyam
            // 
            this.chkAyam.AutoSize = true;
            this.chkAyam.Checked = true;
            this.chkAyam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAyam.Location = new System.Drawing.Point(103, 90);
            this.chkAyam.Name = "chkAyam";
            this.chkAyam.Size = new System.Drawing.Size(52, 17);
            this.chkAyam.TabIndex = 1;
            this.chkAyam.Text = "Ayam";
            this.chkAyam.UseVisualStyleBackColor = true;
            this.chkAyam.CheckedChanged += new System.EventHandler(this.chkAyam_CheckedChanged);
            // 
            // chkSayur
            // 
            this.chkSayur.AutoSize = true;
            this.chkSayur.Checked = true;
            this.chkSayur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSayur.Location = new System.Drawing.Point(189, 90);
            this.chkSayur.Name = "chkSayur";
            this.chkSayur.Size = new System.Drawing.Size(53, 17);
            this.chkSayur.TabIndex = 1;
            this.chkSayur.Text = "Sayur";
            this.chkSayur.UseVisualStyleBackColor = true;
            this.chkSayur.CheckedChanged += new System.EventHandler(this.chkSayur_CheckedChanged);
            // 
            // cmbTambahMenu
            // 
            this.cmbTambahMenu.FormattingEnabled = true;
            this.cmbTambahMenu.Items.AddRange(new object[] {
            "Nasi",
            "Ayam",
            "Sayur"});
            this.cmbTambahMenu.Location = new System.Drawing.Point(103, 141);
            this.cmbTambahMenu.Name = "cmbTambahMenu";
            this.cmbTambahMenu.Size = new System.Drawing.Size(85, 21);
            this.cmbTambahMenu.TabIndex = 2;
            this.cmbTambahMenu.SelectedIndexChanged += new System.EventHandler(this.cmbTambahMenu_SelectedIndexChanged);
            // 
            // txtJumlahTambahMenu
            // 
            this.txtJumlahTambahMenu.Location = new System.Drawing.Point(194, 142);
            this.txtJumlahTambahMenu.Name = "txtJumlahTambahMenu";
            this.txtJumlahTambahMenu.Size = new System.Drawing.Size(38, 20);
            this.txtJumlahTambahMenu.TabIndex = 3;
            this.txtJumlahTambahMenu.TextChanged += new System.EventHandler(this.txtJumlahTambahMenu_TextChanged);
            // 
            // lblTambahMenu
            // 
            this.lblTambahMenu.AutoSize = true;
            this.lblTambahMenu.Location = new System.Drawing.Point(15, 144);
            this.lblTambahMenu.Name = "lblTambahMenu";
            this.lblTambahMenu.Size = new System.Drawing.Size(79, 13);
            this.lblTambahMenu.TabIndex = 4;
            this.lblTambahMenu.Text = "Tambah Menu:";
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Location = new System.Drawing.Point(18, 386);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(108, 23);
            this.btnBayar.TabIndex = 5;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "List Pesanan";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(63, 178);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nasi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ayam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sayur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Bayar";
            // 
            // lblHargaNasi
            // 
            this.lblHargaNasi.AutoSize = true;
            this.lblHargaNasi.Location = new System.Drawing.Point(100, 203);
            this.lblHargaNasi.Name = "lblHargaNasi";
            this.lblHargaNasi.Size = new System.Drawing.Size(10, 13);
            this.lblHargaNasi.TabIndex = 7;
            this.lblHargaNasi.Text = "-";
            // 
            // lblHargaAyam
            // 
            this.lblHargaAyam.AutoSize = true;
            this.lblHargaAyam.Location = new System.Drawing.Point(100, 233);
            this.lblHargaAyam.Name = "lblHargaAyam";
            this.lblHargaAyam.Size = new System.Drawing.Size(10, 13);
            this.lblHargaAyam.TabIndex = 7;
            this.lblHargaAyam.Text = "-";
            // 
            // lblHargaSayur
            // 
            this.lblHargaSayur.AutoSize = true;
            this.lblHargaSayur.Location = new System.Drawing.Point(100, 267);
            this.lblHargaSayur.Name = "lblHargaSayur";
            this.lblHargaSayur.Size = new System.Drawing.Size(10, 13);
            this.lblHargaSayur.TabIndex = 7;
            this.lblHargaSayur.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "=";
            // 
            // lblTotalHargaNasi
            // 
            this.lblTotalHargaNasi.AutoSize = true;
            this.lblTotalHargaNasi.Location = new System.Drawing.Point(273, 203);
            this.lblTotalHargaNasi.Name = "lblTotalHargaNasi";
            this.lblTotalHargaNasi.Size = new System.Drawing.Size(10, 13);
            this.lblTotalHargaNasi.TabIndex = 7;
            this.lblTotalHargaNasi.Text = "-";
            // 
            // lblTotalHargaAyam
            // 
            this.lblTotalHargaAyam.AutoSize = true;
            this.lblTotalHargaAyam.Location = new System.Drawing.Point(273, 233);
            this.lblTotalHargaAyam.Name = "lblTotalHargaAyam";
            this.lblTotalHargaAyam.Size = new System.Drawing.Size(10, 13);
            this.lblTotalHargaAyam.TabIndex = 7;
            this.lblTotalHargaAyam.Text = "-";
            // 
            // lblTotalHargaSayur
            // 
            this.lblTotalHargaSayur.AutoSize = true;
            this.lblTotalHargaSayur.Location = new System.Drawing.Point(273, 267);
            this.lblTotalHargaSayur.Name = "lblTotalHargaSayur";
            this.lblTotalHargaSayur.Size = new System.Drawing.Size(10, 13);
            this.lblTotalHargaSayur.TabIndex = 7;
            this.lblTotalHargaSayur.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(153, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "x";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(153, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "x";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(153, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "x";
            // 
            // lblJumlahNasi
            // 
            this.lblJumlahNasi.AutoSize = true;
            this.lblJumlahNasi.Location = new System.Drawing.Point(186, 203);
            this.lblJumlahNasi.Name = "lblJumlahNasi";
            this.lblJumlahNasi.Size = new System.Drawing.Size(10, 13);
            this.lblJumlahNasi.TabIndex = 7;
            this.lblJumlahNasi.Text = "-";
            // 
            // lblJumlahAyam
            // 
            this.lblJumlahAyam.AutoSize = true;
            this.lblJumlahAyam.Location = new System.Drawing.Point(186, 233);
            this.lblJumlahAyam.Name = "lblJumlahAyam";
            this.lblJumlahAyam.Size = new System.Drawing.Size(10, 13);
            this.lblJumlahAyam.TabIndex = 7;
            this.lblJumlahAyam.Text = "-";
            // 
            // lblJumlahSayur
            // 
            this.lblJumlahSayur.AutoSize = true;
            this.lblJumlahSayur.Location = new System.Drawing.Point(186, 267);
            this.lblJumlahSayur.Name = "lblJumlahSayur";
            this.lblJumlahSayur.Size = new System.Drawing.Size(10, 13);
            this.lblJumlahSayur.TabIndex = 7;
            this.lblJumlahSayur.Text = "-";
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBayar.Location = new System.Drawing.Point(272, 299);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(17, 15);
            this.lblTotalBayar.TabIndex = 7;
            this.lblTotalBayar.Text = "-";
            // 
            // btnTambahMenu
            // 
            this.btnTambahMenu.Location = new System.Drawing.Point(238, 139);
            this.btnTambahMenu.Name = "btnTambahMenu";
            this.btnTambahMenu.Size = new System.Drawing.Size(22, 23);
            this.btnTambahMenu.TabIndex = 8;
            this.btnTambahMenu.Text = "+";
            this.btnTambahMenu.UseVisualStyleBackColor = true;
            this.btnTambahMenu.Click += new System.EventHandler(this.btnTambahMenu_Click);
            // 
            // btnKurangMenu
            // 
            this.btnKurangMenu.Location = new System.Drawing.Point(266, 139);
            this.btnKurangMenu.Name = "btnKurangMenu";
            this.btnKurangMenu.Size = new System.Drawing.Size(17, 23);
            this.btnKurangMenu.TabIndex = 8;
            this.btnKurangMenu.Text = "-";
            this.btnKurangMenu.UseVisualStyleBackColor = true;
            this.btnKurangMenu.Click += new System.EventHandler(this.btnKurangMenu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Uang Bayar";
            // 
            // txtUangBayar
            // 
            this.txtUangBayar.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUangBayar.Location = new System.Drawing.Point(275, 329);
            this.txtUangBayar.Name = "txtUangBayar";
            this.txtUangBayar.Size = new System.Drawing.Size(95, 20);
            this.txtUangBayar.TabIndex = 3;
            this.txtUangBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUangBayar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Kembalian";
            // 
            // lblTotalKembalian
            // 
            this.lblTotalKembalian.AutoSize = true;
            this.lblTotalKembalian.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKembalian.Location = new System.Drawing.Point(273, 359);
            this.lblTotalKembalian.Name = "lblTotalKembalian";
            this.lblTotalKembalian.Size = new System.Drawing.Size(17, 16);
            this.lblTotalKembalian.TabIndex = 7;
            this.lblTotalKembalian.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(175, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rumah Makan Suka Suka";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Makan Gratiss, Sudah Makan Baru Bayar!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(219, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "By: Ramdan Riawan";
            // 
            // formMakan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 461);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKurangMenu);
            this.Controls.Add(this.btnTambahMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalKembalian);
            this.Controls.Add(this.lblTotalBayar);
            this.Controls.Add(this.lblTotalHargaSayur);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblJumlahSayur);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblHargaSayur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalHargaAyam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblJumlahAyam);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblHargaAyam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalHargaNasi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblJumlahNasi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblHargaNasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.lblTambahMenu);
            this.Controls.Add(this.txtUangBayar);
            this.Controls.Add(this.txtJumlahTambahMenu);
            this.Controls.Add(this.cmbTambahMenu);
            this.Controls.Add(this.chkSayur);
            this.Controls.Add(this.chkAyam);
            this.Controls.Add(this.chkNasi);
            this.Name = "formMakan";
            this.Text = "Makan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNasi;
        private System.Windows.Forms.CheckBox chkAyam;
        private System.Windows.Forms.CheckBox chkSayur;
        private System.Windows.Forms.ComboBox cmbTambahMenu;
        private System.Windows.Forms.TextBox txtJumlahTambahMenu;
        private System.Windows.Forms.Label lblTambahMenu;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHargaNasi;
        private System.Windows.Forms.Label lblHargaAyam;
        private System.Windows.Forms.Label lblHargaSayur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalHargaNasi;
        private System.Windows.Forms.Label lblTotalHargaAyam;
        private System.Windows.Forms.Label lblTotalHargaSayur;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblJumlahNasi;
        private System.Windows.Forms.Label lblJumlahAyam;
        private System.Windows.Forms.Label lblJumlahSayur;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.Button btnTambahMenu;
        private System.Windows.Forms.Button btnKurangMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUangBayar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalKembalian;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

