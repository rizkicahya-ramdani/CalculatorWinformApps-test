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

                double hasil = bil1 + bil2;

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
    }
}
