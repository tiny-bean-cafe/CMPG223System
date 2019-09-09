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
    public partial class frmBakedGoods : Form
    {
        public frmBakedGoods()
        {
            InitializeComponent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.ShowDialog();
            this.Close();
        }
    }
}
