using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMODUL12_2311104061
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mengambil input dari textBox1
            int input;
            // Mengecek apakah input bisa dikonversi menjadi integer
            if (int.TryParse(textBox1.Text, out input))
            {
                // Menampilkan hasil pengecekan di label1
                label1.Text = CariTandaBilangan(input);
            }
            else
            {
                // Menampilkan pesan jika input tidak valid
                label1.Text = "Input tidak valid";
            }

        }
 public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }
    }
}
    