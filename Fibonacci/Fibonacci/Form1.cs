using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public int degisken;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public int fibonacciHesapla(int x)
        {
            int a = 0;
            int b = 1;
            if (x == 0 || x == 1) {
                degisken = 1;
            }
            else { 
            for (int i = 1; i <= x; i++)
            {
              degisken = a + b;
                a = b;
                b = degisken;
            }
          }
            return degisken;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc;
            sonuc = fibonacciHesapla(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(sonuc.ToString());
        }
    }
}
