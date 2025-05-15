using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JURNALMODUL12_2311104061
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CariNilaiPangkat(int a, int b)
        {
            if (b == 0)
                return 1;
            if (b < 0)
                return -1;
            if (b > 10 || a > 100)
                return -2;

            try
            {
                checked
                {
                    int hasil = 1;
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                    return hasil;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b))
            {
                int hasil = CariNilaiPangkat(a, b);
                label1.Text = $"Hasil: {hasil}";
            }
            else
            {
                label1.Text = "Input tidak valid!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
