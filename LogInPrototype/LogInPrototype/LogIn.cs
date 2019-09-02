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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vodacom-pc\Desktop\CMPG223System\LogInPrototype\LogInPrototype\TinyBeanData.mdf;Integrated Security=True";
        SqlConnection connect;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader dataReader;
        DataSet dataset;

        private void button1_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string sql = @"SELECT * FROM Staff";
            command = new SqlCommand(sql, connect);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (tbUse.Text == dataReader.GetValue(1).ToString() && tbPass.Text == dataReader.GetValue(2).ToString())
                {
                    if (dataReader.GetValue(3).ToString() == 'E'.ToString())
                    {
                        Employee emp = new Employee();
                        emp.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Owner own = new Owner();
                        own.ShowDialog();
                        this.Close(); 
                    }
                }
                else
                {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    tbUse.Text = "";
                    tbPass.Text = "";
                    break;
                }
            }
            connect.Close();           
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
    }
}
