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
    public partial class frmCustomerTab : Form
    {
        public frmCustomerTab()
        {
            InitializeComponent();
        }

        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NOMFUNDO\Desktop\YEAR2\Semester 2\CMPG223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";

        SqlConnection connect;
        SqlDataAdapter adapter;
        SqlCommand command;
        //SqlDataReader dataReader;
        DataSet dataset;
        string customerName, customerSName, customerCell, customerEmail;
        double balance, limit,empID,custID;


        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            /*frmAddCustomer addNewCustomer = new frmAddCustomer();
            addNewCustomer.ShowDialog();
            this.Close();
            btnCreateTab.Visible = true;*/
        }

        private void btnCreateTab_Click(object sender, EventArgs e)
        {
            /*frmCreateNewTab createNewTab = new frmCreateNewTab();
            createNewTab.ShowDialog();
            this.Close();*/
        }

        private void frmCustomerTab_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            lblLimit.Visible = false;
            lblBalance.Visible = false;
            lblEmpNo.Visible = false;
            lblCustId.Visible = false;
            lblFName.Visible = false;
            lblLName.Visible = false;
            btnShowTab.Visible = false;
            txtBalance.Visible = false;
            txtLimit.Visible = false;
            txtEmpID.Visible = false;
            txtCusID.Visible = false;
            btnCreate.Visible = false;
            listBox1.Visible = false;

        }

        private void btnExistingCustomer_Click(object sender, EventArgs e)
        {
           // btnAddNewCustomer.Visible = false;
            lblInsert.Visible = true;
            txtTabID.Visible = true;
            btnSearch.Visible = true;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            balance = double.Parse(txtBalance.Text);
            limit = double.Parse(txtLimit.Text);
            empID = double.Parse(txtEmpID.Text);
            custID = double.Parse(txtCusID.Text);

            try
            {
                string insertQuery = "INSERT INTO Tab VALUES('" + balance + "','" + limit + "','" + empID + "','" + custID + "' )";
                connect = new SqlConnection(connectionString);
                connect.Open();
                command = new SqlCommand(insertQuery, connect);

                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("New tab created successfully!!");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            double balanceDue = emp.getBalanceDue;
            double Bal;
            

            try
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
                string readQuery = @"SELECT * FROM Tab WHERE Cust_ID = '" + txtTabID.Text + "'";
                command = new SqlCommand(readQuery, connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Bal = double.Parse(reader.GetValue(1).ToString());
                    Bal += balanceDue;
                    listBox1.Items.Add("New Balance: " + Bal.ToString());
                }
                connect.Close();
               

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            emp.ShowDialog();
        }

        private void lblLimit_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTab_Click(object sender, EventArgs e)
        {
           // string sqlShow = "SELECT * FROM Tab";

            try
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
                string readQuery = @"SELECT * FROM Tab WHERE Cust_ID = '"+ txtTabID.Text +"'";
                command = new SqlCommand(readQuery, connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add("Balance: " + reader.GetValue(1).ToString());
                    listBox1.Items.Add("Limit: " + reader.GetValue(2).ToString());
                    //lblFName.Text = reader.GetValue(1).ToString();
                    //lblLName.Text = reader.GetValue(2).ToString();
                }
                connect.Close();

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            lblLName.Visible = true;
            lblFName.Visible = true;
            btnShowTab.Visible = true;
            listBox1.Visible = true;
            string search = txtTabID.Text;
            
            string sqlAll = "SELECT * FROM Customer WHERE Cust_ID LIKE '%" + search + "%'";

            try
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
                string readQuery = @"SELECT * FROM Customer WHERE Cust_ID ='"+txtTabID.Text +"'";
                command = new SqlCommand(readQuery, connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lblFName.Text = reader.GetValue(1).ToString();
                    lblLName.Text = reader.GetValue(2).ToString();
                }
                connect.Close();

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customerName = txtName.Text;
            customerSName = txtSurname.Text;
            customerCell = txtCell.Text;
            customerEmail = txtEmail.Text;

            try
            {
                string insertQuery = "INSERT INTO Customer VALUES('" + customerName + "','" + customerSName + "','" + customerCell + "','" + customerEmail + "')";
                connect = new SqlConnection(connectionString);
                connect.Open();
                command = new SqlCommand(insertQuery, connect);

                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            MessageBox.Show("Data saved!!");
            txtBalance.Visible = true;
            txtLimit.Visible = true;
            btnCreate.Visible = true;
            lblBalance.Visible = true;
            lblLimit.Visible = true;
            lblCustId.Visible = true;
            lblEmpNo.Visible = true;
            txtCusID.Visible = true;
            txtEmpID.Visible = true;
        }
    }
}
