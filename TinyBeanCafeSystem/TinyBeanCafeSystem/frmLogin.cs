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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vodacom-pc\Desktop\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
       // String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NkTheAstranout\Documents\(2019) Senior Year\Semester 2\CMPG223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        SqlConnection connect;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader dataReader;
        DataSet dataset;
        String username, password, userPos;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            String sql = @"SELECT * FROM Staff";
            command = new SqlCommand(sql,connect);
            dataReader = command.ExecuteReader();
            
            while (dataReader.Read())
            {
                username = dataReader.GetValue(1).ToString();
                password = dataReader.GetValue(2).ToString();
                userPos = dataReader.GetValue(3).ToString();
               
                if (username != tbUsername.Text)
                {
                    lblSearching.Text = "Searching...";

                }
                if (username == tbUsername.Text && password == tbPassword.Text)
                {
                    lblSearching.Text = "";
                    tbUsername.Text = "";
                    tbPassword.Text = "";

                    if (userPos == "O")
                    {
                        frmOwner owner = new frmOwner();
                        owner.ShowDialog();
                        //this.Close();
                    }
                    else
                    {
                        frmEmployee emp = new frmEmployee();
                        emp.ShowDialog();
                       // this.Close();
                    }
                }
                else
                {
                    if (username != tbUsername.Text)
                    {
                        tbUsername.SelectAll();
                        tbPassword.SelectAll();
                        lblSearching.Text = "The username or the password is incorrect";
                    }
                    else if (password != tbPassword.Text)
                    {
                        tbUsername.SelectAll();
                        tbPassword.SelectAll();
                        lblSearching.Text = "The username or the password is incorrect";
                    }
                }

            }
            connect.Close();

            

            
        }
    }
}
