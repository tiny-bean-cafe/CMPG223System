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
using System.Threading;

namespace LogInPrototype
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
           /* Thread t = new Thread(new ThreadStart(showSplashScreen));
            t.Start();
            Thread.Sleep(5000);
           */
            InitializeComponent();
        }

        public void showSplashScreen()
        {
            Application.Run(new SplashScreen());
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NkTheAstranout\Documents\(2019) Senior Year\Semester 2\CMPG223\CMPG223System\LogInPrototype\LogInPrototype\TinyBeanData.mdf;Integrated Security=True";
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
            progressBarLogin.Visible = true;
            int progressBarValue = 0;
            progressBarLogin.Value = progressBarValue;
           
            while (dataReader.Read())
            {
                progressBarValue++;
                if (tbUse.Text == dataReader.GetValue(1).ToString() && tbPass.Text == dataReader.GetValue(2).ToString())
                {
                    //MessageBox.Show(dataReader.GetValue(1).ToString());
                    if (dataReader.GetValue(3).ToString() == 'E'.ToString())
                    {
                        progressBarLogin.Value = 100;
                        Employee emp = new Employee();
                        emp.ShowDialog();
                        this.Close();
                        
                    }
                    else
                    {
                        progressBarLogin.Value = 100;
                        Owner own = new Owner();
                        own.ShowDialog();
                        this.Close();
                        
                    }
                }
                else
                {
                    progressBarLogin.Value = 100;
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    tbUse.Text = "";
                    tbPass.Text = "";
                    tbUse.Focus();
                    progressBarLogin.Visible = false;
                    progressBarLogin.Value = 0;
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
