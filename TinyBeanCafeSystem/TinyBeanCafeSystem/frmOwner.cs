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
    public partial class frmOwner : Form
    {
        public frmOwner()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection connect;
        // public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NkTheAstranout\Documents\(2019) Senior Year\Semester 2\CMPG223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vodacom-pc\Desktop\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";

        SqlDataAdapter adapt; 
        DataSet dataSet; 
        SqlCommand cmd;


        public void loadData(string tableName)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            adapt = new SqlDataAdapter();
            dataSet = new DataSet();
            string sqlQuery = @"SELECT * FROM " + tableName;
            cmd = new SqlCommand(sqlQuery, connect);
            adapt.SelectCommand = cmd;
            adapt.Fill(dataSet, tableName + "Info");
            dataGridViewStock.DataSource = dataSet;
            dataGridViewStock.DataMember = tableName + "Info";
            connect.Close();
        }

        /*
         * I turned the reading of the ID's into a function since it is going to be done
         * more than once 
         * I only checked if the first combo box did not have the new ID's and added ID's
         * to both the combo boxes
         */
        public void readIDIntoComboBoxes()
        {
            connect.Open();
            string readQuery = @"SELECT * FROM Stock";
            cmd = new SqlCommand(readQuery, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!comboBoxStockID.Items.Contains(reader.GetValue(0)) || !comboBoxDeleteStockID.Items.Contains(reader.GetValue(0)))
                {
                    comboBoxStockID.Items.Add(reader.GetValue(0));
                    comboBoxDeleteStockID.Items.Add(reader.GetValue(0));
                }

            }
            connect.Close();
        }


        private void FrmOwner_Load(object sender, EventArgs e)
        {
            // Very neat :)
            loadData("Stock");
            readIDIntoComboBoxes();

        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            int quantity;
            try
            {
                string insertQuery = "INSERT INTO Stock VALUES(@desc, @quantity)";
                connect = new SqlConnection(connectionString);
                connect.Open();
                cmd = new SqlCommand(insertQuery, connect);
                if(!(tbStockDescription.TextLength == 0))
                {
                    errorProvider.Clear();
                    if(int.TryParse(tbStockQuantity.Text , out quantity))
                    {
                        errorProvider.Clear();
                        cmd.Parameters.AddWithValue("@desc", tbStockDescription.Text);
                        cmd.Parameters.AddWithValue("@quantity", tbStockQuantity.Text);
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        loadData("Stock");
                        MessageBox.Show("Data successfully added !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        readIDIntoComboBoxes();
                        tbStockDescription.Clear();
                        tbStockQuantity.Clear();
                        tbStockDescription.Focus();
                    }
                    else
                    {
                        errorProvider.SetError(tbStockQuantity, "Invalid Quantity");
                    }
                }
                else
                {
                    errorProvider.SetError(tbStockDescription, "Please Enter description");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdateStock_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string updateField = comboBoxStockUpdate.Text;
            string updateQuery;
            int quantity; 
            if(!(comboBoxStockID.SelectedIndex == 0 || comboBoxStockID.SelectedIndex > 0))
            {
                errorProvider.SetError(comboBoxStockID, "Invalid ID");
                comboBoxStockID.Text = "";
            }
            else
            {
                errorProvider.SetError(comboBoxStockID, "");
                if(!(comboBoxStockUpdate.SelectedIndex == 0 || comboBoxStockUpdate.SelectedIndex > 0))
                {
                    errorProvider.SetError(comboBoxStockUpdate, "Please choose a field to update");
                }
                else if (comboBoxStockUpdate.SelectedItem.ToString() == "Quantity")
                {
                    if (int.TryParse(tbUpdateStock.Text, out quantity))
                    {
                        updateQuery = @"UPDATE Stock SET Quantity = '" + quantity + "' WHERE Stock_ID = '" + comboBoxStockID.SelectedItem.ToString() + "'";
                        cmd = new SqlCommand(updateQuery, connect);
                        cmd.ExecuteNonQuery();
                        errorProvider.Clear();
                        loadData("Stock");
                        MessageBox.Show("Update Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider.SetError(tbUpdateStock, "");
                        comboBoxStockID.Text = "";
                        comboBoxStockID.Focus();
                        tbUpdateStock.Clear();
                        comboBoxStockUpdate.Text = "";
                    }
                    else
                    {
                        errorProvider.SetError(tbUpdateStock, "Invalid quantity");
                        tbUpdateStock.Clear();
                    }
                }
                else
                {
                    if (!(tbUpdateStock.TextLength == 0))
                    {
                        errorProvider.Clear();
                        updateQuery = @"UPDATE Stock SET Stock_Desc = '" + tbUpdateStock.Text + "' WHERE Stock_ID = '" + comboBoxStockID.SelectedItem.ToString() + "'";
                        cmd = new SqlCommand(updateQuery, connect);
                        cmd.ExecuteNonQuery();
                        loadData("Stock");
                        MessageBox.Show("Update Successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBoxStockID.Text = "";
                        comboBoxStockID.Focus();
                        tbUpdateStock.Clear();
                        comboBoxStockUpdate.Text = "";
                        
                    }
                    else
                    {
                        errorProvider.SetError(tbUpdateStock, "Invalid Update");
                        tbUpdateStock.Clear();
                    }
                }
            }
            connect.Close();
            
        }

        public void deleteRow(string table , int ID)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string sqlDeleteQuery = "DELETE FROM " + table +  " WHERE Stock_ID = '" + ID + "'";
            cmd = new SqlCommand(sqlDeleteQuery, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            loadData("Stock");
        }

        private void BtnDeleteStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(comboBoxDeleteStockID.SelectedIndex == 0 || comboBoxDeleteStockID.SelectedIndex > 0))
                {
                    errorProvider.SetError(comboBoxDeleteStockID, "Invalid ID");
                    comboBoxDeleteStockID.SelectAll();
                }
                else
                {
                    errorProvider.SetError(comboBoxDeleteStockID, "");
                    deleteRow("Stock", int.Parse(comboBoxDeleteStockID.Text));
                    comboBoxDeleteStockID.Items.Clear();
                    comboBoxStockID.Items.Clear();
                    readIDIntoComboBoxes();
                    MessageBox.Show("Deletion Successful !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxDeleteStockID.Text = "";
                    comboBoxDeleteStockID.Focus();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        public void orderStockBy(string orderConstraint)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string sqlOrder = @"SELECT * FROM Stock ORDER BY " + orderConstraint;
            cmd = new SqlCommand(sqlOrder, connect);
            dataSet = new DataSet();
            adapt.SelectCommand = cmd;
            adapt.Fill(dataSet ,"data");
            dataGridViewStock.DataSource = dataSet;
            dataGridViewStock.DataMember = "data";
            connect.Close();
        }


        private void BtnSortStock_Click(object sender, EventArgs e)
        {
            if (rbStockID.Checked)
                orderStockBy("Stock_ID");
            if (rbStockQuantity.Checked)
                orderStockBy("Quantity");
            if (rbStockDesc.Checked)
                orderStockBy("Stock_Desc");
            else
                orderStockBy("Stock_ID");
        }
    }
}
