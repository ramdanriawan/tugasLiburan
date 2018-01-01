using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasLiburan
{
    public partial class formMakan : Form
    {
        public formMakan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtJumlahTambahMenu.Text = "0";

            makan ramdan = new makan();
            lblHargaNasi.Text = ramdan.hargaNasi.ToString();
            lblHargaAyam.Text = ramdan.hargaAyam.ToString();
            lblHargaSayur.Text = ramdan.hargaSayur.ToString();
            lblJumlahNasi.Text = "1";
            lblJumlahAyam.Text = "1";
            lblJumlahSayur.Text = "1";
            lblTotalHargaNasi.Text = ramdan.hargaNasi.ToString();
            lblTotalHargaAyam.Text = ramdan.hargaAyam.ToString();
            lblTotalHargaSayur.Text = ramdan.hargaSayur.ToString();
            txtJumlahTambahMenu.Text = "1";
            cmbTambahMenu.SelectedIndex = 0;

            lblTotalBayar.Text = (Convert.ToDouble(lblTotalHargaNasi.Text) + Convert.ToDouble(lblTotalHargaAyam.Text) + Convert.ToDouble(lblTotalHargaSayur.Text)).ToString();

        }

        private void chkNasi_CheckedChanged(object sender, EventArgs e)
        {
            makan ramdan = new makan();

            if(chkNasi.Checked)
            {
                cmbTambahMenu.Items.Insert(0, "Nasi");
                cmbTambahMenu.SelectedIndex = 0;

                lblHargaNasi.Text = ramdan.hargaNasi.ToString();
                lblJumlahNasi.Text = "1";
                lblTotalHargaNasi.Text = ramdan.hargaNasi.ToString();

                //tambahin harga total bayar
                int totalBayar = Convert.ToInt32(lblTotalBayar.Text);
                int totalHargaNasi = Convert.ToInt32(lblTotalHargaNasi.Text);
                totalBayar = totalBayar + totalHargaNasi;
                lblTotalBayar.Text = totalBayar.ToString();

            }
            else if(!chkNasi.Checked)
            {
                cmbTambahMenu.Items.Remove("Nasi");


                //kurangin harga total bayar
                int totalBayar = Convert.ToInt32(lblTotalBayar.Text);
                int totalHargaNasi = Convert.ToInt32(lblTotalHargaNasi.Text);
                totalBayar = totalBayar - totalHargaNasi;

                //set ke 0
                lblHargaNasi.Text = "0";
                lblJumlahNasi.Text = "0";
                lblTotalHargaNasi.Text = "0";

                lblTotalBayar.Text = totalBayar.ToString();

                if((!chkAyam.Checked && chkSayur.Checked) || (chkAyam.Checked && !chkSayur.Checked) || (chkAyam.Checked && chkSayur.Checked))
                {
                    cmbTambahMenu.SelectedIndex = 0;
                }
                else if (!chkNasi.Checked && !chkAyam.Checked && !chkSayur.Checked)
                {
                    MessageBox.Show("Tidak ada menu yang dipilih");
                }
            }

        }

        private void chkAyam_CheckedChanged(object sender, EventArgs e)
        {
            makan ramdan = new makan();

            if(chkAyam.Checked)
            {
                lblHargaAyam.Text = ramdan.hargaAyam.ToString();
                lblJumlahAyam.Text = "1";
                lblTotalHargaAyam.Text = ramdan.hargaAyam.ToString();

                //tambahin harga total bayar
                int totalBayar = Convert.ToInt32(lblTotalBayar.Text);
                int totalHargaAyam = Convert.ToInt32(lblTotalHargaAyam.Text);
                totalBayar = totalBayar + totalHargaAyam;
                lblTotalBayar.Text = totalBayar.ToString();

                if (chkNasi.Checked)
                {
                    cmbTambahMenu.Items.Insert(1, "Ayam");
                }else if(!chkNasi.Checked)
                {
                    cmbTambahMenu.Items.Insert(0, "Ayam");
                }

                cmbTambahMenu.SelectedIndex = 0;
            }
            else if(!chkAyam.Checked)
            {
                //kurangin harga total bayar
                int totalBayar = Convert.ToInt32(lblTotalBayar.Text);
                int totalHargaAyam = Convert.ToInt32(lblTotalHargaAyam.Text);
                totalBayar = totalBayar - totalHargaAyam;
                lblTotalBayar.Text = totalBayar.ToString();

                lblHargaAyam.Text = "0";
                lblJumlahAyam.Text = "0";
                lblTotalHargaAyam.Text = "0";
                cmbTambahMenu.Items.Remove("Ayam");

                if((!chkNasi.Checked && chkSayur.Checked) || (chkNasi.Checked && !chkSayur.Checked))
                {
                    cmbTambahMenu.SelectedIndex = 0;
                }
                else if (!chkNasi.Checked && !chkAyam.Checked && !chkSayur.Checked)
                {
                    MessageBox.Show("Tidak ada menu yang dipilih");
                }

            }

        }

        private void chkSayur_CheckedChanged(object sender, EventArgs e)
        {
            makan ramdan = new makan();

            if(chkSayur.Checked)
            {
                lblHargaSayur.Text = ramdan.hargaSayur.ToString();
                lblJumlahSayur.Text = "1";
                lblTotalHargaSayur.Text = ramdan.hargaSayur.ToString();

                //tambahin harga total bayar
                int totalBayar = Convert.ToInt32(lblTotalBayar.Text);
                int totalHargaSayur = Convert.ToInt32(lblTotalHargaSayur.Text);
                totalBayar = totalBayar + totalHargaSayur;
                lblTotalBayar.Text = totalBayar.ToString();

                if ((chkNasi.Checked && !chkAyam.Checked) || (!chkNasi.Checked && chkAyam.Checked))
                {
                    cmbTambahMenu.Items.Insert(1, "Sayur");
                }else if(chkNasi.Checked && chkAyam.Checked)
                {
                    cmbTambahMenu.Items.Insert(2, "Sayur");
                }else if(!chkNasi.Checked && !chkAyam.Checked)
                {
                    cmbTambahMenu.Items.Insert(0, "Sayur");
                }

                cmbTambahMenu.SelectedIndex = 0;
            }else if(!chkSayur.Checked)
            {
                //kurangin harga total bayar
                int totalBayar = Convert.ToInt32(lblTotalBayar.Text);
                int totalHargaSayur = Convert.ToInt32(lblTotalHargaSayur.Text);
                totalBayar = totalBayar - totalHargaSayur;
                lblTotalBayar.Text = totalBayar.ToString();

                lblHargaSayur.Text ="0";
                lblJumlahSayur.Text = "0";
                lblTotalHargaSayur.Text = "0";

                cmbTambahMenu.Items.Remove("Sayur");

                if((chkNasi.Checked && !chkAyam.Checked) || (!chkNasi.Checked && chkAyam.Checked))
                {
                    cmbTambahMenu.SelectedIndex = 0;
                }else if(!chkNasi.Checked && !chkAyam.Checked && !chkSayur.Checked)
                {
                    MessageBox.Show("Tidak ada menu yang dipilih");
                }
            }


        }

        private void cmbTambahMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTambahMenu_Click(object sender, EventArgs e)
        {
            if(cmbTambahMenu.Text == "Nasi")
            {
                int jumlahNasi = Convert.ToInt16(lblJumlahNasi.Text);
                jumlahNasi += Convert.ToInt16(txtJumlahTambahMenu.Text);
                lblJumlahNasi.Text = jumlahNasi.ToString();

                double totalHargaNasi  = Convert.ToDouble(lblHargaNasi.Text) * jumlahNasi;
                lblTotalHargaNasi.Text = totalHargaNasi.ToString();
            }else if(cmbTambahMenu.Text == "Ayam")
            {
                int jumlahAyam = Convert.ToInt16(lblJumlahAyam.Text);
                jumlahAyam += Convert.ToInt16(txtJumlahTambahMenu.Text);
                lblJumlahAyam.Text = jumlahAyam.ToString();

                double totalHargaAyam = Convert.ToDouble(lblHargaAyam.Text) * jumlahAyam;
                lblTotalHargaAyam.Text = totalHargaAyam.ToString();
            }
            else if (cmbTambahMenu.Text == "Sayur")
            {
                int jumlahSayur         = Convert.ToInt16(lblJumlahSayur.Text);
                jumlahSayur             += Convert.ToInt16(txtJumlahTambahMenu.Text);
                lblJumlahSayur.Text     = jumlahSayur.ToString();

                double totalHargaSayur  = Convert.ToDouble(lblHargaSayur.Text) * jumlahSayur;
                lblTotalHargaSayur.Text = totalHargaSayur.ToString();
            }

            lblTotalBayar.Text = (Convert.ToDouble(lblTotalHargaNasi.Text) + Convert.ToDouble(lblTotalHargaAyam.Text) + Convert.ToDouble(lblTotalHargaSayur.Text)).ToString();

            //exception untuk enable tombol button bayar
            bool nilai = Convert.ToInt16(lblJumlahNasi.Text) >= 0 && Convert.ToInt16(lblJumlahAyam.Text) >= 0 && Convert.ToInt16(lblJumlahSayur.Text) >= 0;

            if (nilai)
            {
                btnBayar.Enabled = true;
            }
        }

        private void btnKurangMenu_Click(object sender, EventArgs e)
        {
            if (txtJumlahTambahMenu.Text == "")
            {
                MessageBox.Show("Harap input jumlah tambah menu!");
                txtJumlahTambahMenu.Text = "0";
            }

            if (cmbTambahMenu.Text == "Nasi")
            {
                int jumlahNasi = Convert.ToInt16(lblJumlahNasi.Text);
                jumlahNasi -= Convert.ToInt16(txtJumlahTambahMenu.Text);
                lblJumlahNasi.Text = jumlahNasi.ToString();

                double totalHargaNasi = Convert.ToDouble(lblHargaNasi.Text) * jumlahNasi;
                lblTotalHargaNasi.Text = totalHargaNasi.ToString();
            }
            else if (cmbTambahMenu.Text == "Ayam")
            {
                int jumlahAyam = Convert.ToInt16(lblJumlahAyam.Text);
                jumlahAyam -= Convert.ToInt16(txtJumlahTambahMenu.Text);
                lblJumlahAyam.Text = jumlahAyam.ToString();

                double totalHargaAyam = Convert.ToDouble(lblHargaAyam.Text) * jumlahAyam;
                lblTotalHargaAyam.Text = totalHargaAyam.ToString();
            }
            else if (cmbTambahMenu.Text == "Sayur")
            {
                int jumlahSayur = Convert.ToInt16(lblJumlahSayur.Text);
                jumlahSayur -= Convert.ToInt16(txtJumlahTambahMenu.Text);
                lblJumlahSayur.Text = jumlahSayur.ToString();

                double totalHargaSayur = Convert.ToDouble(lblHargaSayur.Text) * jumlahSayur;
                lblTotalHargaSayur.Text = totalHargaSayur.ToString();
            }

            lblTotalBayar.Text = (Convert.ToDouble(lblTotalHargaNasi.Text) + Convert.ToDouble(lblTotalHargaAyam.Text) + Convert.ToDouble(lblTotalHargaSayur.Text)).ToString();


            //exception jika ada harga yang mines yang mines
            bool nilai = Convert.ToInt16(lblJumlahNasi.Text) < 0 || Convert.ToInt16(lblJumlahAyam.Text) < 0 || Convert.ToInt16(lblJumlahSayur.Text) < 0;

            if(nilai)
            {
                MessageBox.Show("Tidak boleh ada data mines!");
                btnBayar.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUangBayar.Text != "")
            {
                if (!Int32.TryParse(txtUangBayar.Text, out Int32 data))
                {
                    MessageBox.Show("Harap input hanya angka saja!");
                    btnBayar.Enabled = false;
                }else
                {
                    btnBayar.Enabled = true;
                }
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if(txtUangBayar.Text == "")
            {
                MessageBox.Show("Harap Masukkan Uang Bayar!");
            }else
            {
                double totalBayar = Convert.ToDouble(lblTotalBayar.Text);
                double uangBayar = Convert.ToDouble(txtUangBayar.Text);

                lblTotalKembalian.Text = (uangBayar - totalBayar).ToString("N2");
            }
        }

        private void txtJumlahTambahMenu_TextChanged(object sender, EventArgs e)
        {
            if (txtJumlahTambahMenu.Text != "" )
            {

                if (!Int32.TryParse(txtJumlahTambahMenu.Text, out Int32 data))
                {

                    MessageBox.Show("Harap input hanya angka saja!");
                    btnTambahMenu.Enabled = false;
                    btnKurangMenu.Enabled = false;
                }
                else
                {
                    btnTambahMenu.Enabled = true;
                    btnKurangMenu.Enabled = true;
                }
            }
            else if(txtJumlahTambahMenu.Text == "")
            {
                btnTambahMenu.Enabled = false;
                btnKurangMenu.Enabled = false;
            }
            else if (Convert.ToDouble(txtJumlahTambahMenu.Text) < 0)
            {
                MessageBox.Show("Input tidak boleh lebih kecil dari 0!");
                btnTambahMenu.Enabled = false;
                btnKurangMenu.Enabled = false;
            }
            else
            {
                btnTambahMenu.Enabled = true;
                btnKurangMenu.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            makan ramdan = new makan();

            //reset textbox jumlah item tambah
            txtJumlahTambahMenu.Text = "1";

            //reset jumlah item, harga item, dan total harga item
            lblHargaNasi.Text = ramdan.hargaNasi.ToString();
            lblHargaAyam.Text = ramdan.hargaAyam.ToString();
            lblHargaSayur.Text = ramdan.hargaSayur.ToString();

            lblJumlahNasi.Text = "1";
            lblJumlahAyam.Text = "1";
            lblJumlahSayur.Text = "1";

            lblTotalHargaNasi.Text = ramdan.hargaNasi.ToString();
            lblTotalHargaAyam.Text = ramdan.hargaAyam.ToString();
            lblTotalHargaSayur.Text = ramdan.hargaSayur.ToString();

            //reset total bayar
            lblTotalBayar.Text = (Convert.ToDouble(lblHargaNasi.Text) + Convert.ToDouble(lblHargaAyam.Text) + Convert.ToDouble(lblHargaSayur.Text)).ToString();

            //reset uang bayar
            txtUangBayar.Text = "";

            //reset uang kembalian
            lblTotalKembalian.Text = "-";
        }
    }
}
