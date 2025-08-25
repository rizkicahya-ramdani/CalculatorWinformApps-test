using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double bil1 = Convert.ToDouble(inputBilPertama.Text);
                double bil2 = Convert.ToDouble(inputBilKedua.Text);
                string op = cmbOperator.SelectedItem.ToString();

                double hasil = 0;

                switch (op)
                {
                    case "+":
                        hasil = bil1 + bil2;
                        break;
                    case "-":
                        hasil = bil1 - bil2;
                        break;
                    case "*":
                        hasil = bil1 * bil2;
                        break;
                    case "/":
                        if (bil2 == 0)
                        {
                            MessageBox.Show("Pembagi tidak boleh nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        hasil = bil1 / bil2;
                        break;
                    default:
                        MessageBox.Show("Operator tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                panelHasil.Controls.Clear();

                Label labelHasil = new Label();
                labelHasil.Text = "Hasil: " + hasil.ToString();
                labelHasil.AutoSize = true;
                labelHasil.Font = new Font("Arial", 16, FontStyle.Bold);
                labelHasil.ForeColor = Color.DarkBlue;

                panelHasil.Controls.Add(labelHasil);
            }
            catch (FormatException)
            {
                MessageBox.Show("Inputan harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperator.Items.Add("+");
            cmbOperator.Items.Add("-");
            cmbOperator.Items.Add("*");
            cmbOperator.Items.Add("/");
            cmbOperator.SelectedIndex = 0;
        }
    }
}
