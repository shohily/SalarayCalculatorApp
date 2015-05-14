using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarayCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Salary aSalary=new Salary();
        private void button1_Click(object sender, EventArgs e)
        {
            aSalary.employeeName = employeeNameTextBox.Text;
            aSalary.basicamount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.rent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medical = Convert.ToDouble(medicalTextBox.Text);

            MessageBox.Show(aSalary.employeeName + " " + "your salary is: " + aSalary.GetSalary());
            employeeNameTextBox.Text = "";
            basicAmountTextBox.Text = "";
            houseRentTextBox.Text = "";
            medicalTextBox.Text = "";

        }
    }
}
