using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int fibonacciHesapla(int x)
        {
            if (x == 1 || x == 0)
            {
                return 1;
            }

            return fibonacciHesapla(x - 1) + fibonacciHesapla(x - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Int32.Parse(textBox1.Text);
                int sonuc = fibonacciHesapla(sayi);
                MessageBox.Show(sonuc.ToString());
            }
            catch
            {
                MessageBox.Show("Lütfen int değer giriniz");
            }
        }
    }
}
