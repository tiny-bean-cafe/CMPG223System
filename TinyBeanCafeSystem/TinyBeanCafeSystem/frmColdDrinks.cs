using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TinyBeanCafeSystem
{
    public partial class frmColdDrinks : Form
    {
        public frmColdDrinks()
        {
            InitializeComponent();
        }
        frmEmployee emp = new frmEmployee();

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mellison\Documents\CMPG 223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";

        SqlConnection connect;
        SqlCommand command;
        SqlDataReader dataReader;

        private void BtnDone_Click(object sender, EventArgs e)
        {

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
            lstColdDrinks.Items.Add(cmdColdDrinks.SelectedItem.ToString());
            emp.lstOrderName.Items.Add(cmdColdDrinks.SelectedItem.ToString());
            lstQty.Items.Add(txtQty.Text);
            emp.lstOrderQty.Items.Add(txtQty.Text);
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

        private void FrmColdDrinks_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string sql = @"SELECT * FROM Product";
            command = new SqlCommand(sql, connect);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.GetValue(2).ToString() == "Cold Drink")
                {
                    cmdColdDrinks.Items.Add(dataReader.GetValue(1).ToString());
                }
            }
            connect.Close();
        }
    }
}
