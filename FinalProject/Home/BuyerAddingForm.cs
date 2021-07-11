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
    public partial class BuyerAddingForm : Form
    {
        public BuyerAddingForm()
        {
            InitializeComponent();
            this.oldBuyerLabel.Visible = false;
            this.oldBuyerNameLabel.Visible = false;
            this.addEditbutton.Text = "Add";
        }
        public BuyerAddingForm(string name,string id)
        {
            InitializeComponent();
            this.oldBuyerNameLabel.Text = name;
            this.buyerNameTextBox.Text = name;
            this.nonVisibleBuyerId.Visible = false;
            this.nonVisibleBuyerId.Text = id;
            this.addEditbutton.Text = "Update";
        }

        private void addEditbutton_Click(object sender, EventArgs e)
        {
            string newName = buyerNameTextBox.Text;
            string index = nonVisibleBuyerId.Text;

            if (addEditbutton.Text == "Add")
            {
                if (!String.IsNullOrWhiteSpace(buyerNameTextBox.Text))
                {
                    if (buyerNameExpLabel.Visible == true)
                    {
                        buyerNameExpLabel.Visible = false;
                    }
                    DB db = new DB();
                    try
                    {
                        db.openConnection();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("INSERT INTO [Buyer] VALUES ('" + newName + "')", db.GetConnection());
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    finally
                    {
                        db.closedConnection();
                        this.buyerNameTextBox.Text = "";
                    }
                }
                else
                {
                    buyerNameExpLabel.Visible = true;
                }
            }
            else if (addEditbutton.Text == "Update")
            {
                if (!String.IsNullOrWhiteSpace(buyerNameExpLabel.Text))
                {
                    if (buyerNameExpLabel.Visible == true)
                    {
                        buyerNameExpLabel.Visible = false;
                    }
                    DB db = new DB();
                    try
                    {
                        db.openConnection();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("UPDATE [Buyer] SET BuyerName = '" + newName + "' WHERE BuyerID = '" + index + "' ", db.GetConnection());
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
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
                    buyerNameExpLabel.Visible = true;
                }
            }
        }

        private void buyerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
