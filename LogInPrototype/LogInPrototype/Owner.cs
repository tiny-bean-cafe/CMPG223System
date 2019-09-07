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

namespace LogInPrototype
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        SqlConnection connect;
       string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NkTheAstranout\Documents\(2019) Senior Year\Semester 2\CMPG223\CMPG223System\LogInPrototype\LogInPrototype\TinyBeanData.mdf;Integrated Security=True";

        public void loadDatabase()
        {
            LogIn obj = new LogIn();
            connect = new SqlConnection(connectionString);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sqlQuery = "SELECT * FROM Supplier";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            adapter.SelectCommand = command;
            adapter.Fill(dataSet, "supInfo");
            dataGridSupplier.DataSource = dataSet;
            dataGridSupplier.DataMember = "supInfo";
            connect.Close();

        }
        
        public void orderBy(string orderParameter)
        {
            LogIn obj = new LogIn();
            connect = new SqlConnection(connectionString);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sqlQuery = "SELECT * FROM Supplier ORDER BY '"+ orderParameter +"'";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            adapter.SelectCommand = command;
            adapter.Fill(dataSet, "supInfo");
            dataGridSupplier.DataSource = dataSet;
            dataGridSupplier.DataMember = "supInfo";
            connect.Close();
        }

        public void clearSupplierTextBoxes()
        {
            tbSupName.Clear();
            tbSupEmail.Clear();
            tbSupCell.Clear();
            tbbSupID.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridStock.Visible = true;
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
            loadDatabase();

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int supplierID;
            if(tbSupCell.TextLength == 0)
            {
                errorProvider.SetError(tbSupCell, "Please enter Cell ");
            }
            if(tbSupEmail.TextLength == 0)
            {
                errorProvider.SetError(tbSupEmail, "Please enter Email");
            }
            if(tbSupName.TextLength == 0)
            {
                errorProvider.SetError(tbSupName, "Please enter Name");
            }

            if(int.TryParse(tbbSupID.Text, out supplierID))
            {
                try
                {
                    string insertQuery = "INSERT INTO Supplier VALUES(@SupID,@SupName,@SupEmail,@SupCell)";
                    connect = new SqlConnection(connectionString);
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(insertQuery, connect);
                    cmd.Parameters.AddWithValue("@SupID", supplierID);
                    cmd.Parameters.AddWithValue("@SupName", tbSupName.Text);
                    cmd.Parameters.AddWithValue("@SupEmail" , tbSupEmail.Text);
                    cmd.Parameters.AddWithValue("@SupCell" , tbSupCell.Text);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    loadDatabase();
                    MessageBox.Show("Data has been successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearSupplierTextBoxes();
                    tbbSupID.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                errorProvider.SetError(tbbSupID, "Invalid ID");
                tbbSupID.Text = "";
                tbbSupID.Focus();  
            }
 
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            tbbSupID.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(rbID.Checked)
            {
                orderBy("Sup_ID");
            }
            if(rbName.Checked)
            {
                orderBy("Sup_Name");
            }
            if(rbCell.Checked)
            {
                orderBy("Sup_Cell");
            }
            if (rbEmail.Checked)
            {
                orderBy("Sup_Email");
            }
        }
    }
}
