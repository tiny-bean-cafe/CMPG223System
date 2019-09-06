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
            LogIn obj = new LogIn();
            string connectionString;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NkTheAstranout\Documents\(2019) Senior Year\Semester 2\CMPG223\CMPG223System\LogInPrototype\LogInPrototype\TinyBeanData.mdf;Integrated Security=True";
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
