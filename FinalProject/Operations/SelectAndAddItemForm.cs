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
    public partial class SelectAndAddItemForm : Form
    {
        public SelectAndAddItemForm()
        {
            InitializeComponent();
        }
        public SelectAndAddItemForm(string prodName, string qount, string pric, string id)
        {
            InitializeComponent();
            productComboBox.Text = prodName;
            quantityTextBox.Text = qount;
            priceTextBox.Text = pric;
            nonVisibleIdLabel.Text = id;
            nonVisibleIdLabel.Visible = false;
            addButton.Text = "Update";
        }

        private void SelectAndAddItemForm_Load(object sender, EventArgs e)
        {
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addButton.Text == "Add")
            {
                if (!String.IsNullOrWhiteSpace(productComboBox.Text))
                {
                    if (!String.IsNullOrWhiteSpace(quantityTextBox.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(priceTextBox.Text))
                        {
                            string prodcombobox = productComboBox.Text;
                            string quantity = quantityTextBox.Text;
                            string price = priceTextBox.Text;
                            DB db = new DB();
                            SqlCommand command = new SqlCommand("SELECT NaxnakanPaid.NaxnakanPaidID FROM NaxnakanPaid  WHERE  NaxnakanPaid.ProductName = '" + prodcombobox + "' AND NaxnakanPaid.Price = '" + price + "' ", db.GetConnection());
                            db.openConnection();
                            SqlDataReader reader = command.ExecuteReader();

                            if (!reader.Read())
                            {
                                db.closedConnection();
                                db.openConnection();
                                SqlCommand sqlCommand = new SqlCommand("INSERT INTO NaxnakanPaid VALUES('" + quantity + "','" + price + "','" + prodcombobox + "')  ", db.GetConnection());
                                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                                DataTable dataTable = new DataTable();
                                sqlDataAdapter.Fill(dataTable);

                                productComboBox.Text = "";
                                quantityTextBox.Text = "";
                                priceTextBox.Text = "";
                                productComboBoxLabel.Visible = false;
                                quantityExpLabel.Visible = false;
                                priceExpLabel.Visible = false;
                            }
                            else
                            {
                                db.closedConnection();
                                db.openConnection();
                                SqlCommand sqlCommand = new SqlCommand("UPDATE  NaxnakanPaid SET NaxnakanPaid.Quantity = (SELECT NaxnakanPaid.Quantity FROM NaxnakanPaid WHERE NaxnakanPaid.ProductName = '" + prodcombobox + "' AND NaxnakanPaid.Price = '" + price + "') + '" + quantity + "' WHERE NaxnakanPaid.NaxnakanPaidID = (SELECT NaxnakanPaid.NaxnakanPaidID FROM NaxnakanPaid WHERE NaxnakanPaid.ProductName = '" + prodcombobox + "' AND NaxnakanPaid.Price = '" + price + "')", db.GetConnection());
                                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                                DataTable dataTable = new DataTable();
                                sqlDataAdapter.Fill(dataTable);

                                productComboBox.Text = "";
                                quantityTextBox.Text = "";
                                priceTextBox.Text = "";
                                productComboBoxLabel.Visible = false;
                                quantityExpLabel.Visible = false;
                                priceExpLabel.Visible = false;
                            }
                        }
                        else
                        {
                            if (productComboBoxLabel.Visible == true)
                            {
                                productComboBoxLabel.Visible = false;
                            }
                            if (quantityExpLabel.Visible == true)
                            {
                                quantityExpLabel.Visible = false;
                            }
                            priceExpLabel.Visible = true;
                        }
                    }
                    else
                    {
                        if (productComboBoxLabel.Visible == true)
                        {
                            productComboBoxLabel.Visible = false;
                        }
                        if (priceExpLabel.Visible == true)
                        {
                            priceExpLabel.Visible = false;
                        }
                        quantityExpLabel.Visible = true;
                    }
                }
                else
                {
                    if (quantityExpLabel.Visible == true)
                    {
                        quantityExpLabel.Visible = false;
                    }
                    if (priceExpLabel.Visible == true)
                    {
                        priceExpLabel.Visible = false;
                    }
                    productComboBoxLabel.Visible = true;
                }

            }
            else if (addButton.Text == "Update")
            {

                if (!String.IsNullOrWhiteSpace(productComboBox.Text))
                {
                    if (!String.IsNullOrWhiteSpace(quantityTextBox.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(priceTextBox.Text))
                        {
                            DB db = new DB();
                            string newprodcombobox = productComboBox.Text;
                            string newquantity = quantityTextBox.Text;
                            string newprice = priceTextBox.Text;
                            string id = nonVisibleIdLabel.Text;
                            try
                            {
                                SqlCommand command = new SqlCommand("UPDATE NaxnakanPaid SET Quantity = '" + newquantity + "', Price = '" + newprice + "',ProductName = '" + newprodcombobox + "'  WHERE  NaxnakanPaidID = '" + id + "'  ", db.GetConnection());
                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                DataTable table = new DataTable();
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
                            if (productComboBoxLabel.Visible == true)
                            {
                                productComboBoxLabel.Visible = false;
                            }
                            if (quantityExpLabel.Visible == true)
                            {
                                quantityExpLabel.Visible = false;
                            }
                            priceExpLabel.Visible = true;
                        }
                    }
                    else
                    {
                        if (productComboBoxLabel.Visible == true)
                        {
                            productComboBoxLabel.Visible = false;
                        }
                        if (priceExpLabel.Visible == true)
                        {
                            priceExpLabel.Visible = false;
                        }
                        quantityExpLabel.Visible = true;
                    }
                }
                else
                {
                    if (quantityExpLabel.Visible == true)
                    {
                        quantityExpLabel.Visible = false;
                    }
                    if (priceExpLabel.Visible == true)
                    {
                        priceExpLabel.Visible = false;
                    }
                    productComboBoxLabel.Visible = true;
                }

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
