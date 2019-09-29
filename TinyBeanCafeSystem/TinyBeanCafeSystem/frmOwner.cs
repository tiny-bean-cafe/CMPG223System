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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciddy\Downloads\year 2019\second semester\CMPG 223\TBeanProject\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security = True";
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mellison\Documents\CMPG 223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        // public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NkTheAstranout\Documents\(2019) Senior Year\Semester 2\CMPG223\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";
        // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vodacom-pc\Desktop\CMPG223System\TinyBeanCafeSystem\TinyBeanCafeSystem\TinyBeanData.mdf;Integrated Security=True";

        SqlDataAdapter adapt; 
        DataSet dataSet; 
        SqlCommand cmd;
        public void delete(string table, string idField, int ID)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string sqlDeleteQuery = "DELETE FROM " + table + " WHERE " + idField + " = '" + ID + "'";
            cmd = new SqlCommand(sqlDeleteQuery, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void update(string table , string field , string update , string tableIdName , int ID)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string updateQuery = @"UPDATE Supplier SET " + field + " = '" + update + "' WHERE " + tableIdName +  " = '" + ID + "'";
            cmd = new SqlCommand(updateQuery, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

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

        public void loadEmployeeTable()
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            adapt = new SqlDataAdapter();
            dataSet = new DataSet();
            string sqlQuery = @"SELECT * FROM Employee" ;
            cmd = new SqlCommand(sqlQuery, connect);
            adapt.SelectCommand = cmd;
            adapt.Fill(dataSet, "employeeInfo");
            dataGridViewEmployee.DataSource = dataSet;
            dataGridViewEmployee.DataMember = "employeeInfo";
            connect.Close();
        }

        public void loadSupplierTable()
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            adapt = new SqlDataAdapter();
            dataSet = new DataSet();
            string sqlQuery = @"SELECT * FROM Supplier";
            cmd = new SqlCommand(sqlQuery, connect);
            adapt.SelectCommand = cmd;
            adapt.Fill(dataSet, "supInfo");
            dataGridViewSupplier.DataSource = dataSet;
            dataGridViewSupplier.DataMember = "supInfo";
            connect.Close();
        }
        public void loadCustomerTable()
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            adapt = new SqlDataAdapter();
            dataSet = new DataSet();
            string sqlQuery = @"SELECT * FROM Customer";
            cmd = new SqlCommand(sqlQuery, connect);
            adapt.SelectCommand = cmd;
            adapt.Fill(dataSet, "cus");
            dataGridViewCustomer.DataSource = dataSet;
            dataGridViewCustomer.DataMember = "cus";
            connect.Close();
        }

         public void readIDIntoEmployeeComboBoxes()
        {
            connect.Open();
            string readQuery = @"SELECT * FROM Employee";
            cmd = new SqlCommand(readQuery, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!comboBoxEmployeeID.Items.Contains(reader.GetValue(0)) || !comboBoxDeletEmployeeID.Items.Contains(reader.GetValue(0)))
                {
                    comboBoxEmployeeID.Items.Add(reader.GetValue(0));
                    comboBoxDeletEmployeeID.Items.Add(reader.GetValue(0));
                }
            }
            connect.Close();
        }
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

        public void readSupplerIDIntoComboBoxes()
        {
            connect.Open();
            string readQuery = @"SELECT * FROM Supplier";
            cmd = new SqlCommand(readQuery, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!comboBoxSupplierID.Items.Contains(reader.GetValue(0)) || !comboBoxDeleteSupplierID.Items.Contains(reader.GetValue(0)))
                {
                    comboBoxSupplierID.Items.Add(reader.GetValue(0));
                    comboBoxDeleteSupplierID.Items.Add(reader.GetValue(0));
                }
            }
            connect.Close();
        }
        public void readCustomerIdIntoComboboxes()
        {
            connect.Open();
            string readQuery = @"SELECT * FROM Customer";
            cmd = new SqlCommand(readQuery, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if(!comboBoxCustomerID.Items.Contains(reader.GetValue(0)) || !comboBoxDeleteCustomerID.Items.Contains(reader.GetValue(0)))
                {
                    comboBoxCustomerID.Items.Add(reader.GetValue(0));
                    comboBoxDeleteCustomerID.Items.Add(reader.GetValue(0));
                }
            }
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
                    DialogResult delResult = MessageBox.Show("Are you sure  you want to delete row with ID " + comboBoxDeleteStockID.SelectedItem + " ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(delResult == DialogResult.Yes)
                    {
                        delete("Stock", "Stock_ID", int.Parse(comboBoxDeleteStockID.SelectedItem.ToString()));
                        loadData("Stock");
                        comboBoxDeleteStockID.Items.Clear();
                        comboBoxStockID.Items.Clear();
                        readIDIntoComboBoxes();
                        MessageBox.Show("Deletion Successful !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBoxDeleteStockID.Text = "";
                        comboBoxDeleteStockID.Focus();
                    }
                    errorProvider.SetError(comboBoxDeleteStockID, "");
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

        public void orderEmployeeBy(string orderBy)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string sqlOrder = "SELECT * FROM Employee ORDER BY " + orderBy;
            cmd = new SqlCommand(sqlOrder, connect);
            dataSet = new DataSet();
            adapt.SelectCommand = cmd;
            adapt.Fill(dataSet, "data");
            dataGridViewEmployee.DataSource = dataSet;
            dataGridViewEmployee.DataMember = "data" ;
            connect.Close();
        }

       public void orderSupplierBy(string orderBy)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string sqlOrder = "SELECT * FROM Supplier ORDER BY " + orderBy;
            cmd = new SqlCommand(sqlOrder, connect);
            dataSet = new DataSet();
            adapt.SelectCommand = cmd;
            adapt.Fill(dataSet, "data");
            dataGridViewSupplier.DataSource = dataSet;
            dataGridViewSupplier.DataMember = "data";
            connect.Close();
        }
        public void orderCustomerBy(string orderBy)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
            string slqOrder = "SELECT * FROM Customer ORDER BY " + orderBy;
            cmd = new SqlCommand(slqOrder, connect);
            dataSet = new DataSet();
            adapt.Fill(dataSet, "data");
            dataGridViewCustomer.DataSource = dataSet;
            dataGridViewCustomer.DataMember = "data";
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

        private void TabEmployee_Enter(object sender, EventArgs e)
        {
            loadEmployeeTable();
            readIDIntoEmployeeComboBoxes();
           // MessageBox.Show("henlo world");
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            if(tbEmployeeName.TextLength == 0)
            {
                errorProvider.SetError(tbEmployeeName, "Please enter name");
            }
            else if(tbEmployeeSurname.TextLength == 0)
            {
                errorProvider.SetError(tbEmployeeName, "");
                errorProvider.SetError(tbEmployeeSurname, "Please enter surname");
            }
            else if(tbEmployeeEmail.TextLength == 0)
            {
                errorProvider.SetError(tbEmployeeName, "");
                errorProvider.SetError(tbEmployeeSurname, "");
                errorProvider.SetError(tbEmployeeEmail, "Please enter email");
            }
            else if(tbEmployeeCell.TextLength == 0)
            {
                errorProvider.SetError(tbEmployeeName, "");
                errorProvider.SetError(tbEmployeeSurname, "");
                errorProvider.SetError(tbEmployeeEmail, "");
                errorProvider.SetError(tbEmployeeCell, "Please enter cell");
            }
            else
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
                string insertEmployee = @"INSERT INTO Employee VALUES(@name, @surname,@cell,@email)";
                cmd = new SqlCommand(insertEmployee, connect);
                cmd.Parameters.AddWithValue("@name", tbEmployeeName.Text);
                cmd.Parameters.AddWithValue("@surname", tbEmployeeSurname.Text);
                cmd.Parameters.AddWithValue("@cell", tbEmployeeCell.Text);
                cmd.Parameters.AddWithValue("@email", tbEmployeeEmail.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    loadEmployeeTable();
                    MessageBox.Show("Data successfully added !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbEmployeeName.Clear();
                    tbEmployeeSurname.Clear();
                    tbEmployeeEmail.Clear();
                    tbEmployeeCell.Clear();
                    tbEmployeeName.Focus();
                    readIDIntoEmployeeComboBoxes();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void TabSupplier_Enter(object sender, EventArgs e)
        {
            loadSupplierTable();
            readSupplerIDIntoComboBoxes();
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            if(tbSupplierName.TextLength == 0)
            {
                errorProvider.SetError(tbSupplierName, "Please enter Name");
            }
            else if(tbSupplierEmail.TextLength == 0)
            {
                errorProvider.SetError(tbSupplierName, "");
                errorProvider.SetError(tbSupplierEmail, "Please enter Email");
            }
            else if(tbSupplierCell.TextLength == 0)
            {
                errorProvider.SetError(tbSupplierName, "");
                errorProvider.SetError(tbSupplierEmail, "");
                errorProvider.SetError(tbSupplierCell, "Please Enter Cell");
            }
            else
            {
                try
                {
                    errorProvider.Clear();
                    connect = new SqlConnection(connectionString);
                    connect.Open();
                    string insertSupplier = @"INSERT INTO Supplier VALUES(@name, @cell, @email)";
                    cmd = new SqlCommand(insertSupplier, connect);
                    cmd.Parameters.AddWithValue("@name", tbSupplierName.Text);
                    cmd.Parameters.AddWithValue("@cell", tbSupplierCell.Text);
                    cmd.Parameters.AddWithValue("@email", tbSupplierEmail.Text);
                    
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    loadSupplierTable();
                    MessageBox.Show("Data added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSupplierName.Clear();
                    tbSupplierEmail.Clear();
                    tbSupplierCell.Clear();
                    tbSupplierName.Focus();
                    readSupplerIDIntoComboBoxes();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }

        }
        private void BtnUpdateSupplier_Click(object sender, EventArgs e)
        {
            int supplierUpdateID;
            if(comboBoxSupplierID.SelectedIndex >= 0)
            {
                errorProvider.SetError(comboBoxSupplierID, "");
                if (int.TryParse(comboBoxSupplierID.SelectedItem.ToString(), out supplierUpdateID))
                {
                    errorProvider.SetError(comboBoxSupplierID, "");
                    if (comboBoxSupplierUpdate.SelectedIndex >= 0)
                    {
                        errorProvider.SetError(comboBoxSupplierUpdate, "");
                        if (tbUpdateSupplier.TextLength != 0)
                        {
                            errorProvider.SetError(tbUpdateSupplier, "");
                            try
                            {
                                connect = new SqlConnection(connectionString);
                                connect.Open();
                                string field = comboBoxSupplierUpdate.SelectedItem.ToString();
                                string updateQuery = @"UPDATE Supplier SET " + field + " = '" +  tbUpdateSupplier.Text +"' WHERE Sup_ID =  '" + supplierUpdateID +"'";
                                 cmd = new SqlCommand(updateQuery, connect);
                                 cmd.ExecuteNonQuery();
                                 connect.Close();    
                                //update("Supplier", comboBoxSupplierUpdate.SelectedItem.ToString(), tbUpdateSupplier.ToString(),comboBoxSupplierUpdate.SelectedItem.ToString() , int.Parse(comboBoxSupplierID.SelectedItem.ToString()));
                                loadSupplierTable();
                                MessageBox.Show("Update Successful !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                comboBoxSupplierID.Text = "";
                                comboBoxSupplierID.Focus();
                                comboBoxSupplierUpdate.Text = "";
                                tbUpdateSupplier.Clear();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            errorProvider.SetError(tbUpdateSupplier, "Invalid Update");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(comboBoxSupplierUpdate, "Invalid ID");
                    }
                }
                else
                {
                    errorProvider.SetError(comboBoxSupplierID, "Invalid ID");
                }
            }
            else
            {
                errorProvider.SetError(comboBoxSupplierID, "Invalid ID");
            }
        }

        private void BtnDeleteSupplier_Click(object sender, EventArgs e)
        {
            int deleteID;
            if(comboBoxDeleteSupplierID.SelectedIndex >= 0)
            {
                if (int.TryParse(comboBoxDeleteSupplierID.Text , out deleteID))
                {
                    try
                    {
                        DialogResult delResult = MessageBox.Show("Are you sure you want to delete row with ID " + comboBoxDeleteSupplierID.SelectedItem.ToString() + " ?" , "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(delResult == DialogResult.Yes)
                        {
                            delete("Supplier", "Sup_ID", deleteID);
                            loadSupplierTable();
                            readSupplerIDIntoComboBoxes();
                            MessageBox.Show("Deletion Successful !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProvider.SetError(comboBoxDeleteSupplierID, "");
                            comboBoxDeleteSupplierID.Text = "";
                            comboBoxDeleteSupplierID.Focus();
                        }
                        errorProvider.SetError(comboBoxDeleteSupplierID, "");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider.SetError( comboBoxDeleteSupplierID,"Invalid ID");
                }
            }
            else
            {
                errorProvider.SetError(comboBoxDeleteSupplierID, "Invalid ID");
            }
        }

        private void BtnSortSupplier_Click(object sender, EventArgs e)
        {
            if (rbSupplierName.Checked)
                orderSupplierBy("Sup_Name");
            if (rbSupplierEmail.Checked)
                orderSupplierBy("Sup_Email");
            if (rbSupplierCell.Checked)
                orderSupplierBy("Sup_Cell");
            if (rbSupplierID.Checked)
                orderSupplierBy("Sup_ID");
        }

        private void BtnUpdateEmployee_Click(object sender, EventArgs e)
        {
            int updateID;
            
            if(comboBoxEmployeeID.SelectedIndex >= 0)
            {
                errorProvider.SetError(comboBoxEmployeeID, "");
                if(int.TryParse(comboBoxEmployeeID.SelectedItem.ToString() , out updateID))
                {
                    errorProvider.SetError(comboBoxEmployeeID, "");
                    if(comboBoxEmployeeUpdate.SelectedIndex >= 0)
                    {
                        errorProvider.SetError(comboBoxEmployeeUpdate, "");
                        if(tbUpdateEmployee.TextLength != 0)
                        {
                            try
                            {
                                errorProvider.Clear();
                                string updateFiled = comboBoxEmployeeUpdate.SelectedItem.ToString();
                                connect = new SqlConnection(connectionString);
                                connect.Open();
                                string field = comboBoxEmployeeUpdate.SelectedItem.ToString();
                                string updateQuery = @"UPDATE Employee SET " + updateFiled + " = '" + tbUpdateEmployee.Text + "' WHERE Emp_No =  '" + updateID + "'";
                                cmd = new SqlCommand(updateQuery, connect);
                                cmd.ExecuteNonQuery();
                                connect.Close();
                                loadEmployeeTable();
                                MessageBox.Show("Update successful !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbUpdateEmployee.Clear();
                                comboBoxEmployeeID.Focus();
                                comboBoxEmployeeUpdate.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            errorProvider.SetError(tbUpdateEmployee, "Please enter update");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(comboBoxEmployeeUpdate, "Please select field");
                    }
                }
                else
                {
                    errorProvider.SetError(comboBoxEmployeeID, "Invalid ID");
                }
            }
            else
            {
                errorProvider.SetError(comboBoxEmployeeID, "Please select an ID");
            }
        }
        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int deleteID;
            if (comboBoxDeletEmployeeID.SelectedIndex >= 0)
            {
                if (int.TryParse(comboBoxDeletEmployeeID.Text, out deleteID))
                {
                    try
                    {
                        DialogResult delResult = MessageBox.Show("Are you sure you want to delete row with ID " + comboBoxDeletEmployeeID.SelectedItem.ToString() + " ?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (delResult == DialogResult.Yes)
                        {
                            delete("Employee", "Emp_No", deleteID);
                            loadEmployeeTable();
                            readIDIntoEmployeeComboBoxes();
                            MessageBox.Show("Deletion Successful !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProvider.SetError(comboBoxDeletEmployeeID, "");
                            comboBoxDeletEmployeeID.Text = "";
                            comboBoxDeletEmployeeID.Focus();
                        }
                        errorProvider.SetError(comboBoxDeletEmployeeID, "");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider.SetError(comboBoxDeletEmployeeID, "Invalid ID");
                }
            }
            else
            {
                errorProvider.SetError(comboBoxDeletEmployeeID, "Invalid ID");
            }
        }
        private void BtnSortEmployee_Click(object sender, EventArgs e)
        {
            if(rbEmployeeName.Checked)
                 orderEmployeeBy("Emp_Name");
            if (rbEmployeeSurname.Checked)
                orderEmployeeBy("Emp_SName");
            if (rbEmployeeEmail.Checked)
                orderEmployeeBy("Emp_Email");
            if(rbEmployeeID.Checked)
                orderEmployeeBy("Emp_No");
        }

        private void TabCustomer_Enter(object sender, EventArgs e)
        {
            loadCustomerTable();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (tbCustomerName.TextLength == 0)
            {
                errorProvider.SetError(tbCustomerName, "Please enter name");
            }
            else if (tbCustomerSurname.TextLength == 0)
            {
                errorProvider.SetError(tbCustomerName, "");
                errorProvider.SetError(tbCustomerSurname, "Please enter surname");
            }
            else if (tbCustomerEmail.TextLength == 0)
            {
                errorProvider.SetError(tbCustomerName, "");
                errorProvider.SetError(tbCustomerSurname, "");
                errorProvider.SetError(tbCustomerEmail, "Please enter email");
            }
            else if (tbCustomerCell.TextLength == 0)
            {
                errorProvider.SetError(tbCustomerName, "");
                errorProvider.SetError(tbCustomerSurname, "");
                errorProvider.SetError(tbEmployeeEmail, "");
                errorProvider.SetError(tbEmployeeCell, "Please enetr cell number");
            }
            else
            {
                connect = new SqlConnection(connectionString);
                connect.Open();
                string insertCustomer = @"INSERT INTO Customer VALUES(@name,@surname,@email,@cell)";
                cmd = new SqlCommand(insertCustomer, connect);
                cmd.Parameters.AddWithValue("@name", tbCustomerName.Text);
                cmd.Parameters.AddWithValue("@surname", tbCustomerSurname.Text);
                cmd.Parameters.AddWithValue("@email", tbCustomerEmail.Text);
                cmd.Parameters.AddWithValue("@cell", tbCustomerCell.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    loadCustomerTable();
                    MessageBox.Show("Data successfully added !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCustomerName.Clear();
                    tbCustomerSurname.Clear();
                    tbCustomerEmail.Clear();
                    tbCustomerCell.Clear();
                    tbCustomerName.Focus();
                    readCustomerIdIntoComboboxes();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                                     
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            int CustomerUpdateID;
            if(comboBoxCustomerID.SelectedIndex >=0)
            {
                errorProvider.SetError(comboBoxCustomerID, "");
                if(int.TryParse(comboBoxCustomerID.SelectedItem.ToString(), out CustomerUpdateID))
                {
                    errorProvider.SetError(comboBoxCustomerID, "");
                    if(comboBoxCustomerUpdate.SelectedIndex >=0)
                    {
                        errorProvider.SetError(comboBoxCustomerUpdate, "");
                        if(tbUpdateCustomer.TextLength !=0)
                        {
                            try
                            {
                                errorProvider.Clear();
                                string updateField = comboBoxCustomerUpdate.SelectedItem.ToString();
                                connect = new SqlConnection(connectionString);
                                connect.Open();
                                string field = comboBoxCustomerUpdate.SelectedItem.ToString();
                                string updateQuery = @"UPDATE Customer SET " + updateField + " = '" + tbUpdateCustomer.Text + "' WHERE Cust_ID =   '" + updateField + "'";
                                cmd = new SqlCommand(updateQuery, connect);
                                cmd.ExecuteNonQuery();
                                connect.Close();
                                loadCustomerTable();
                                MessageBox.Show("Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbUpdateCustomer.Clear();
                                comboBoxCustomerID.Focus();
                                comboBoxCustomerUpdate.Text = "";

                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            errorProvider.SetError(tbUpdateCustomer, "Please enter update");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(comboBoxCustomerUpdate, "P;ease select field");                       
                    }
                }
                else
                {
                    errorProvider.SetError(comboBoxCustomerID, "Invalid ID");
                }
            }
            else
            {
                errorProvider.SetError(comboBoxCustomerID, "Please select an ID");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int deleteId;
            if(comboBoxDeleteCustomerID.SelectedIndex >= 0)
            {
                if(int.TryParse(comboBoxDeleteCustomerID.Text, out deleteId))
                {
                    try
                    {
                        DialogResult delResult = MessageBox.Show("Are you sure you want to delete row with ID" + comboBoxDeleteCustomerID.SelectedItem.ToString() + "?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(delResult==DialogResult.Yes)
                        {
                            delete("Customer", "Cust_ID", deleteId);
                            loadCustomerTable();
                            readCustomerIdIntoComboboxes();
                            MessageBox.Show("Deletion Successful !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProvider.SetError(comboBoxDeleteCustomerID, "");
                            comboBoxDeleteCustomerID.Text = "";
                            comboBoxDeleteCustomerID.Focus();

                        }
                        errorProvider.SetError(comboBoxDeleteCustomerID, "");

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    errorProvider.SetError(comboBoxDeleteCustomerID, "Invalid ID");
                }
            }
            else
            {
                errorProvider.SetError(comboBoxDeleteCustomerID, "Invalid ID");
            }
        }

        private void btnSortCustomer_Click(object sender, EventArgs e)
        {
            if(rbCustomerID.Checked)
            {
                orderCustomerBy("Cust_ID");
            }
            if(rbCustomerName.Checked)
            {
                orderCustomerBy("Cust_Name");
            }
            if(rbCustomerEmail.Checked)
            {
                orderCustomerBy("Cust_Email");
            }
            if(rbCustomerCell.Checked)
            {
                orderCustomerBy("Cust_Cell");
            }
        }
    }
}
