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

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mellison\Documents\CMPG 223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";

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
            this.Close();
        }

        private void BtnBakedGoods_Click(object sender, EventArgs e)
        {
            frmBakedGoods bakedGoods = new frmBakedGoods();
            bakedGoods.ShowDialog();
            this.Close();
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
                int length = int.Parse(lstOrderName.Items.Count.ToString()) - 1;
                int count = 0;
                double subTotal = 0;
                double total = 0;
                for (int j = 0; j <= length; j++)
                {
                    connect = new SqlConnection(connectionString);
                    connect.Open();
                    string sql = @"SELECT * FROM Product";
                    command = new SqlCommand(sql, connect);
                    dataReader = command.ExecuteReader();
                    string item = lstOrderName.Items[count].ToString();
                    while (dataReader.Read())
                    {

                        if (item == dataReader.GetValue(1).ToString())
                        {
                            lstOrderEach.Items.Add(dataReader.GetValue(3).ToString());
                            total = double.Parse(lstOrderEach.Items[count].ToString()) * double.Parse(lstOrderQty.Items[count].ToString());
                            lstOrderTotal.Items.Add(Math.Round(total, 2).ToString());
                            subTotal += total;
                            count++;
                        }

                    }
                    connect.Close();
                    
                }

                //Determining Prices
                double tax = 0;
                double discount = 0;
                double balDue = 0;
                tax = subTotal * 0.15;
                total = subTotal + tax;
                balDue = total - discount;
                lblTax.Text = tax.ToString("c");
                lblTotal.Text = total.ToString("c");
                lblSubTotal.Text = subTotal.ToString("c");
                //lblDiscount = discount.ToString("c");
                lblBalDue.Text = balDue.ToString("c");
            }
        }
    
    }
        /*private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
    
}
