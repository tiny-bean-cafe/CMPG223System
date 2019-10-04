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
    public partial class frmRetrivePass : Form
    {
        public frmRetrivePass()
        {
            InitializeComponent();
        }
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NOMFUNDO\Desktop\YEAR2\Semester 2\CMPG223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        //String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciddy\Downloads\year 2019\second semester\CMPG 223\TBeanProject\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.md;Integrated Security = True";
        // String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NkTheAstranout\Documents\(2019) Senior Year\Semester 2\CMPG223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader dataReader;
        String username, password;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmRetrivePass_Load(object sender, EventArgs e)
        {

        }

        private void btnRetrive_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            String sql = @"SELECT * FROM Staff";
            command = new SqlCommand(sql, connect);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                username = dataReader.GetValue(1).ToString();
                if (tbxUsername.Text == username)
                {
                    password = dataReader.GetValue(2).ToString();
                    lblPassword.Text = password;
                    break;
                }
                else
                {
                    lblPassword.Text = "Invalid username";
                    
                }
            }
            connect.Close();
        }
    }
}
