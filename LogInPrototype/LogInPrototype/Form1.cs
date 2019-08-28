using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUse.Text == "Owner" || tbUse.Text == "owner")
            {
                Owner ow = new Owner();
                ow.ShowDialog();
                this.Close();

            }
            else if (tbUse.Text ==  "Employee" || tbUse.Text == "employee")
            {
                Employee emp = new Employee();
                emp.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("This user does not exist" , "Error" , MessageBoxButtons.RetryCancel , MessageBoxIcon.Error);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
    }
}
