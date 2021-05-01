using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a00 = Convert.ToDouble(tb00.Text);
                double a01 = Convert.ToDouble(tb01.Text);
                double a02 = Convert.ToDouble(tb02.Text);
                double a10 = Convert.ToDouble(tb10.Text);
                double a11 = Convert.ToDouble(tb11.Text);
                double a12 = Convert.ToDouble(tb12.Text);
                double a20 = Convert.ToDouble(tb20.Text);
                double a21 = Convert.ToDouble(tb21.Text);
                double a22 = Convert.ToDouble(tb22.Text);
                double b0 = Convert.ToDouble(tbb0.Text);
                double b1 = Convert.ToDouble(tbb1.Text);
                double b2 = Convert.ToDouble(tbb2.Text);

                MatrixManager mm = new MatrixManager(new Matrix(a00, a01, a02, a10, a11, a12, a20,
                    a21, a22, b0, b1, b2));

                List<double> sonuc = mm.GaussCalculator();
                l0.Text = sonuc[0].ToString();
                l1.Text = sonuc[1].ToString();
                l2.Text = sonuc[2].ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("hatalı veri girdin yiğido");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb00.Clear(); tb01.Clear(); tb02.Clear();
            tb10.Clear(); tb11.Clear(); tb12.Clear();
            tb20.Clear(); tb21.Clear(); tb22.Clear();
            tbb0.Clear(); tbb1.Clear(); tbb2.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
