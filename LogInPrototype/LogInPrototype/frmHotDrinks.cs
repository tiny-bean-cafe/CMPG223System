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
    public partial class frmHotDrinks : Form
    {
        public frmHotDrinks()
        {
            InitializeComponent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ShowDialog();
            this.Close();
        }
    }
}
