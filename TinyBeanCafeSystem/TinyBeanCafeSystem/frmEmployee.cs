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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mellison\Documents\CMPG 223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vodacom-pc\Desktop\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        SqlConnection connect;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader dataReader;
        DataSet dataset;

        private void BtnHotDrinks_Click(object sender, EventArgs e)
        {
            frmHotDrinks hotDrinks = new frmHotDrinks();
            hotDrinks.ShowDialog();
            this.Close();
        }

        private void BtnColdDrinks_Click(object sender, EventArgs e)
        {
            frmColdDrinks coldDrinks = new frmColdDrinks();
            coldDrinks.ShowDialog();
        }

        private void BtnBakedGoods_Click(object sender, EventArgs e)
        {
            frmBakedGoods bakedGoods = new frmBakedGoods();
            bakedGoods.ShowDialog();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            if (lstOrderName.Items.Count > 0)
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
                string sql = @"SELECT * FROM Product";
                command = new SqlCommand(sql, connect);
                dataReader = command.ExecuteReader();
                int count = 0;
                int length = lstOrderName.Items.Count;
                while (dataReader.Read())
                {
                    for (int j = 0; j <= length; j++)
                    {
                        string item = lstOrderName.Items[0].ToString();
                        if (item == dataReader.GetValue(1).ToString())
                        {
                            lstOrderEach.Items.Add(dataReader.GetValue(3).ToString());
                            count++;
                        }
                    }
                }
                connect.Close();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
