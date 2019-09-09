using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyBeanCafeSystem
{
    public partial class frmColdDrinks : Form
    {
        public frmColdDrinks()
        {
            InitializeComponent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.ShowDialog();
            this.Close();
        }

        private void LblQty_Click(object sender, EventArgs e)
        {

        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void CmdColdDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LstColdDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
