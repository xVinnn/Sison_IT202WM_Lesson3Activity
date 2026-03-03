using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sison_IT202WM_Lesson3Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double grandTotalUnits = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double.TryParse(row.Cells["LecUnits"].Value?.ToString(), out double lec);
                double.TryParse(row.Cells["LabUnits"].Value?.ToString(), out double lab);

                double rowTotal = lec + lab;
                row.Cells["CredUnits"].Value = rowTotal;

                grandTotalUnits += rowTotal;
            }

            txtTotalUnits.Text = grandTotalUnits.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double lecRate = 1500.00;
            const double labRate = 2500.00;
            const double ciscoFee = 4500.00;
            const double bookletFee = 450.00;
            const double sapFee = 2000.00;
            const double downpayment = 8000.00;

            double totalLecUnits = 0;
            double totalLabUnits = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double.TryParse(row.Cells["LecUnits"].Value?.ToString(), out double lec);
                double.TryParse(row.Cells["LabUnits"].Value?.ToString(), out double lab);

                totalLecUnits += lec;
                totalLabUnits += lab;
            }
            double tuition = totalLecUnits * lecRate;
            double compLabFee = totalLabUnits * labRate;

            double totalMisc = compLabFee + ciscoFee + sapFee + bookletFee;
            double grandTotal = tuition + totalMisc;

            double remainingBalance = grandTotal - downpayment;
            double installmentAmount = remainingBalance / 3;

            txtTotalTuitionFee.Text = tuition.ToString("N2");
            txtCompLabFee.Text = compLabFee.ToString("N2");
            txtCiscoFee.Text = ciscoFee.ToString("N2");
            txtSapFee.Text = sapFee.ToString("N2");
            txtBookletFee.Text = bookletFee.ToString("N2");

            txtGrandTotal.Text = grandTotal.ToString("N2");
            txtDownpayment.Text = downpayment.ToString("N2");

            txt1stInstallment.Text = installmentAmount.ToString("N2");
            txt2ndInstallment.Text = installmentAmount.ToString("N2");
            txt2ndInstallment.Text = installmentAmount.ToString("N2");
        }


        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            txtTotalUnits.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
