using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Expences : Form
    {
        public Expences()
        {
            InitializeComponent();
            naxnakanPaidDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.timeNowLabel.Text = DateTime.Now.ToString("yyyy dd MMMM dddd, HH:mm");

        }
        public void LoadData()
        {
            this.buyerNameComboBox.Items.Clear();
            DB db = new DB();
            try
            {
                db.openConnection();
                SqlCommand sqlCommand = new SqlCommand("SELECT BuyerName FROM [Buyer]", db.GetConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.buyerNameComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.buyerNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                foreach (DataRow dr in dataTable.Rows)
                {
                    this.buyerNameComboBox.Items.Add(dr["BuyerName"].ToString());
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                db.closedConnection();
            }
        }
        public void LoadData1()
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                SqlCommand sqlCommand = new SqlCommand("SELECT NaxnakanPaidID , Quantity, Price,  (Quantity*Price) AS Cost , ProductName FROM [NaxnakanPaid]", db.GetConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.naxnakanPaidDataGridView.DataSource = dataTable;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                db.closedConnection();
            }
        }

        private void Expences_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            SelectAndAddItemForm selectAndAddItemForm = new SelectAndAddItemForm();
            selectAndAddItemForm.ShowDialog();
            LoadData1();
            naxnakanPaidDataGridView.Columns[0].Visible = false;
            naxnakanPaidDataGridView.Columns[4].HeaderText = "Product Name";
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            if (naxnakanPaidDataGridView.CurrentCell != null)
            {
                int rowIndex = naxnakanPaidDataGridView.CurrentCell.RowIndex;
                string index = naxnakanPaidDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                string productname = naxnakanPaidDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
                string quontity = naxnakanPaidDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                string price = naxnakanPaidDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                SelectAndAddItemForm selectAndAddItemForm = new SelectAndAddItemForm(productname, quontity, price, index);
                selectAndAddItemForm.ShowDialog();
                LoadData1();
                naxnakanPaidDataGridView.Columns[0].Visible = false;
                naxnakanPaidDataGridView.Columns[4].HeaderText = "Product Name";
            }
            else
            {
                MessageBox.Show("Please Select wath you want edit");
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (naxnakanPaidDataGridView.CurrentCell != null)
            {
                int rowIndex = naxnakanPaidDataGridView.CurrentCell.RowIndex;
                string value = naxnakanPaidDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

                DB db = new DB();

                try
                {
                    db.openConnection();
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand("DELETE  NaxnakanPaid WHERE  NaxnakanPaidID = '" + value + "' ", db.GetConnection());
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                finally
                {
                    db.closedConnection();
                    LoadData1();
                }
            }
            else
            {
                MessageBox.Show("Please Select wath you want delete");
            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            try
            {
                db.openConnection();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("DELETE  FROM [NaxnakanPaid]  ; DBCC CHECKIDENT('NaxnakanPaid', RESEED, 0)", db.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
            finally
            {
                db.closedConnection();
                this.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(buyerNameComboBox.Text))
            {
                if (checkBoxExaptionLable.Visible == true)
                {
                    checkBoxExaptionLable.Visible = false;
                }
                if (naxnakanPaidDataGridView.Rows != null && naxnakanPaidDataGridView.Rows.Count != 0)
                {
                    string buyername = buyerNameComboBox.SelectedItem.ToString();
                    DateTime date = Convert.ToDateTime(dateTimePicker.Value.ToString("yyyy-MM-dd HH : mm"));
                    DateTime datenow = Convert.ToDateTime(timeNowLabel.Text);

                    DB db = new DB();
                    try
                    {
                        db.openConnection();
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand("INSERT INTO DocExp VALUES ('" + date + "','" + datenow + "',(SELECT BuyerID FROM Buyer WHERE BuyerName = '" + buyername + "')) ", db.GetConnection());
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                    }
                    catch (Exception exp)
                    {

                        MessageBox.Show(exp.Message);
                    }
                    finally
                    {
                        db.closedConnection();
                        this.Close();
                    }



                    SqlCommand sqlCommand1 = new SqlCommand("SELECT NaxnakanPaidID , Quantity, Price,  (Quantity*Price) AS Cost , ProductName FROM [NaxnakanPaid]", db.GetConnection());
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapter1.Fill(dataTable1);

                    foreach (DataRow dr in dataTable1.Rows)
                    {
                        string prodnames = dr[4].ToString();
                        string quantity = dr[1].ToString();
                        string price = dr[2].ToString();
                        try
                        {
                            db.openConnection();
                            DataTable table = new DataTable();
                            SqlCommand command = new SqlCommand("INSERT INTO Paid VALUES ((SELECT DocExpID FROM DocExp WHERE AmsativNow =  '" + datenow + "'),(SELECT NamesID FROM Names WHERE ProducNames = '" + prodnames + "'), '" + quantity + "','" + price + "' )", db.GetConnection());
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(table);
                        }
                        catch (Exception exp)
                        {

                            MessageBox.Show(exp.Message);
                        }
                        finally
                        {
                            db.closedConnection();
                            this.Close();
                        }
                    }

                    try
                    {
                        db.openConnection();
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand("DELETE  FROM [NaxnakanPaid]  ; DBCC CHECKIDENT('NaxnakanPaid', RESEED, 0)", db.GetConnection());
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                    }
                    catch (Exception exp)
                    {

                        MessageBox.Show(exp.Message);
                    }
                    finally
                    {
                        db.closedConnection();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You must select item/items for buy");
                }
            }
            else
            {
                checkBoxExaptionLable.Visible = true;
            }
        }

        private void buyerNameComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
