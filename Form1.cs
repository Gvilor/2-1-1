using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtn1.Text = Properties.Settings.Default.n1.ToString();
            txtn2.Text = Properties.Settings.Default.n2.ToString();
            txtn3.Text = Properties.Settings.Default.n3.ToString();
        }
       
        private void txtx_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;

            try
            {
                n1 = int.Parse(this.txtn1.Text);
                txtn1.BackColor = Color.White;
            }
            catch
            {
                txtn1.BackColor = Color.Red;
                MessageBox.Show("Введено некоректное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                n2 = int.Parse(this.txtn2.Text);
                txtn2.BackColor = Color.White;
            }
            catch
            {
                txtn2.BackColor = Color.Red;
                MessageBox.Show("Введено некоректное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                n3 = int.Parse(this.txtn3.Text);
                txtn3.BackColor = Color.White;
            }
            catch
            {
                txtn3.BackColor = Color.Red;
                MessageBox.Show("Введено некоректное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             

            Properties.Settings.Default.n1 = n1;
            Properties.Settings.Default.n2 = n2;
            Properties.Settings.Default.n3 = n3;
            Properties.Settings.Default.Save();

            MessageBox.Show($"Ответ: {Logic.Multiplication(n1, n2, n3)}");
        }

    }
    public class Logic
    {

        public static int Multiplication(int n1, int n2, int n3)
        {


            int otvet = 0;

            if (n1 >= n2 & n1 >= n3)
            {
                otvet = n2 * n3;
            }
            else if (n2 >= n1 & n2 >= n3)
            {
                otvet = n1 * n3;
            }
            else
            {
                otvet = n2 * n1;
            }

            return otvet;
        }

    }
}
