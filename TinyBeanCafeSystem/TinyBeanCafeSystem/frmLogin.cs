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
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NOMFUNDO\Desktop\YEAR2\Semester 2\CMPG223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        // String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciddy\Downloads\year 2019\second semester\CMPG 223\TBeanProject\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.md;Integrated Security = True";
        // String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NkTheAstranout\Documents\(2019) Senior Year\Semester 2\CMPG223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader dataReader;
        String username, password, userPos;

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRetrivePass retrivePass = new frmRetrivePass();
            retrivePass.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            /* connect = new SqlConnection(connectionString);
             connect.Open();
             String sql = @"SELECT * FROM Staff";
             command = new SqlCommand(sql,connect);
             dataReader = command.ExecuteReader();

                }
                if (username == tbUsername.Text && password == tbPassword.Text)
                {
                    lblSearching.Text = "";
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    lblSearching.Text = "";

                    if (userPos == "O")
                    {
                        frmOwner owner = new frmOwner();
                        owner.ShowDialog();
                    }
                    else
                    {
                        frmEmployee emp = new frmEmployee();
                        emp.ShowDialog();
                    }
                }
                else
                {
                    if (tbUsername.Text == "" && tbPassword.Text == "")
                    {
                        lblSearching.Text = "Please enter username and password";
                    }
                    else if (tbUsername.Text == "")
                    {
                        lblSearching.Text = "Please enter username";
                    }
                    else if (tbPassword.Text == "")
                    {
                        lblSearching.Text = "Please enter password";
                    }
                    else if (username != tbUsername.Text)
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
             */
           // frmOwner ow = new frmOwner();
           // ow.ShowDialog();
               
            frmEmployee emp = new frmEmployee();
            emp.ShowDialog();
        }
    }
}
