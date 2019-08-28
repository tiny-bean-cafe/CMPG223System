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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Owner_Load(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
           
        }
    }
}
