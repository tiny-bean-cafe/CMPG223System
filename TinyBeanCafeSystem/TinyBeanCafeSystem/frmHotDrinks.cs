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
    public partial class frmHotDrinks : Form
    {
        string items;
        frmEmployee emp = new frmEmployee();
        public frmHotDrinks()
        {
            InitializeComponent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            
            items = lstHotDrinks.Items.ToString();
            /*emp.lstOrderName.Items.Add(items);*/
            emp.ShowDialog();
            
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lstHotDrinks.Items.Add(cmdHotDrinks.SelectedItem.ToString());
            lstQty.Items.Add(txtQty.Text);
            emp.lstOrderName.Items.Add(cmdHotDrinks.SelectedItem.ToString());
            emp.lstOrderQty.Items.Add(txtQty.Text);
        }

        private void LstHotDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string item = lstHotDrinks.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Would you like to delete the item: " + item + "?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index = lstHotDrinks.SelectedIndex;
                lstHotDrinks.Items.RemoveAt(index);
            }*/
            
        }
    }
}
