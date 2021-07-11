using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EditDoneOperationsForm : Form
    {
        public EditDoneOperationsForm(string paidID, string docID, string oldname, string oldquont, string oldPrice, DateTime oldDate, string oldDateNow)
        {
            InitializeComponent();
            productComboBox.Text = oldname;
            quantityTextBox.Text = oldquont;
            priceTextBox.Text = oldPrice;
            dateTimePicker.Value = oldDate;
            timeNowLabel.Text = oldDateNow;
            nonVisiblepaidIDLabel.Text = paidID;
            nonVisibledocIDLabel.Text = docID;
            nonVisibledocIDLabel.Visible = false;
            nonVisiblepaidIDLabel.Visible = false;

            LoadData();
        }

        public void LoadData()
        {
            this.productComboBox.Items.Clear();
            DB db = new DB();
            try
            {
                db.openConnection();
                SqlCommand sqlCommand = new SqlCommand("SELECT ProducNames FROM [Names]", db.GetConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.productComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.productComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                foreach (DataRow dr in dataTable.Rows)
                {
                    this.productComboBox.Items.Add(dr["ProducNames"].ToString());
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


        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(productComboBox.Text))
            {
                if (!String.IsNullOrWhiteSpace(quantityTextBox.Text))
                {
                    if (!String.IsNullOrWhiteSpace(priceTextBox.Text))
                    {
                        string newname = productComboBox.Text;
                        string newquont = quantityTextBox.Text;
                        string newPrice = priceTextBox.Text;
                        string paidiD = nonVisiblepaidIDLabel.Text;
                        string dociD = nonVisibledocIDLabel.Text;

                        DateTime newDate = Convert.ToDateTime(dateTimePicker.Value.ToString("yyyy-MM-dd HH : mm"));
                        DateTime newDateNow = Convert.ToDateTime(DateTime.Now.ToString("yyyy dd MMMM dddd, HH:mm"));

                        DB db = new DB();
                        try
                        {
                            db.openConnection();
                            SqlCommand sqlCommand = new SqlCommand("UPDATE DocExp SET Amsativ = '" + newDate + "', AmsativNow ='" + newDateNow + "' WHERE DocExpID = '" + dociD + "'", db.GetConnection());
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            SqlCommand sqlCommand1 = new SqlCommand("UPDATE Paid SET NamesID = (SELECT Names.NamesID FROM Names WHERE Names.ProducNames = '" + newname + "'), Quantity ='" + newquont + "', Price = '" + newPrice + "' WHERE PaidID = '" + paidiD + "'", db.GetConnection());
                            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
                            DataTable dataTable1 = new DataTable();
                            sqlDataAdapter1.Fill(dataTable1);

                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                        finally
                        {
                            db.closedConnection();
                            this.Close();
                        }
                    }
                    else
                    {
                        if (editComboBoxExpLabel.Visible == true)
                        {
                            editComboBoxExpLabel.Visible = false;
                        }
                        if (editQuantityExpLabel.Visible == true)
                        {
                            editQuantityExpLabel.Visible = false;
                        }
                        editPriceExpLabel.Visible = true;
                    }
                }
                else
                {
                    if (editPriceExpLabel.Visible == true)
                    {
                        editPriceExpLabel.Visible = false;
                    }
                    if (editQuantityExpLabel.Visible == true)
                    {
                        editQuantityExpLabel.Visible = false;
                    }
                    editQuantityExpLabel.Visible = true;
                }

            }
            else
            {
                if (editPriceExpLabel.Visible == true)
                {
                    editPriceExpLabel.Visible = false;
                }
                if (editQuantityExpLabel.Visible == true)
                {
                    editQuantityExpLabel.Visible = false;
                }
                editComboBoxExpLabel.Visible = true;
            }

        }

        private void productComboBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
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
