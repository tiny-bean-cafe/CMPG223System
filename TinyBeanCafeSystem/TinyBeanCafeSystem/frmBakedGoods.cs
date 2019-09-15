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
    public partial class frmBakedGoods : Form
    {
        public frmBakedGoods()
        {
            InitializeComponent();
        }
        frmEmployee emp = new frmEmployee();

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mellison\Documents\CMPG 223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";

        SqlConnection connect;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader dataReader;
        DataSet dataset;

        private void BtnDone_Click(object sender, EventArgs e)
        {
            
            emp.ShowDialog();
            this.Close();
        }

        private void FrmBakedGoods_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string sql = @"SELECT * FROM Product";
            command = new SqlCommand(sql, connect);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.GetValue(2).ToString() == "Baked Goods")
                {
                    cmdBakedGoods.Items.Add(dataReader.GetValue(1).ToString());
                }
            }
            connect.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lstBakedGoods.Items.Add(cmdBakedGoods.SelectedItem.ToString());
            emp.lstOrderName.Items.Add(cmdBakedGoods.SelectedItem.ToString());
            lstQty.Items.Add(txtQty.Text);
            emp.lstOrderQty.Items.Add(txtQty.Text);
        }
    }
}
