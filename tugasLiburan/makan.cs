using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasLiburan
{
    class makan
    {
        public double hargaNasi = 10000, hargaAyam = 20000, hargaSayur = 30000;
        public int jumlahNasi = 0, jumlahAyam = 0, jumlahSayur = 0;

        public void setMenu(string nasi = "", string ayam = "", string sayur = "")
        {
            if(nasi = "nasi")
            {
                this.jumlahNasi++;
            }else if(ayam != "ayam")
            {
                this.jumlahAyam++;
            }
            else if (sayur != "sayur")
            {
                this.jumlahSayur++;
            }
        }

        public void setTambahMenu(string menu, int jumlah)
        {
            if (menu == "nasi")
            {
                this.jumlahNasi+= jumlah;
            }
            else if (menu == "ayam")
            {
                this.jumlahAyam += jumlah;
            }
            else if (menu == "sayur")
            {
                this.jumlahSayur += jumlah;
            }else
            {
                MessageBox.Show("Menu yang akan ditambah tidak ada! Silakan cek lagi");
            }
        }

        public double bayar()
        {
            double bayar = (this.jumlahNasi * this.hargaNasi) + (this.jumlahAyam * this.hargaAyam) + (this.jumlahSayur * this.hargaSayur);
            return bayar;
        }
    }
}
