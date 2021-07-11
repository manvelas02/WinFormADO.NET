using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddNames : Form
    {
        public AddNames()
        {
            InitializeComponent();
            xumbDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.oldGroupIdLabelNoNVisibility.Visible = false;
            this.oldGroupLable.Visible = false;
            this.oldGroupNameLable.Visible = false;
            this.oldNameLabel.Visible = false;
            this.productLabel.Visible = false;
        }
        public AddNames(string xumbIdvalue,string prodNamevalue, string xumbNamevalue)
        {
            InitializeComponent();
            xumbDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.oldGroupIdLabelNoNVisibility.Visible = false;
            this.oldGroupIdLabelNoNVisibility.Text = xumbIdvalue;
            this.oldGroupNameLable.Text = xumbNamevalue;
            this.oldNameLabel.Text = prodNamevalue;
            this.addButton.Text = "Update";
            this.addNamesLabel.Text = "Edit Name";
            this.addNamestextBox.Text = prodNamevalue;
        }
        public void LoadData()
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Xumb]", db.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.xumbDataGridView.DataSource = dataTable;
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
        private void AddNames_Load(object sender, EventArgs e)
        {
            LoadData();
            this.xumbDataGridView.Columns[0].Visible = false;
            this.xumbDataGridView.Columns[1].HeaderText = "Xumb";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addButton.Text == "Add" )
            {
                if (!String.IsNullOrWhiteSpace(addNamestextBox.Text))
                {
                    if (nameExpLabel.Visible == true)
                    {
                        nameExpLabel.Visible = false;
                    }
                    if (xumbDataGridView.CurrentCell != null)
                    {
                        string prodName = oldNameLabel.Text;
                        DB db = new DB();
                        db.openConnection();
                        SqlCommand command2 = new SqlCommand("SELECT  Names.NamesID FROM  Names WHERE  Names.ProducNames ='" + prodName + "'", db.GetConnection());

                        SqlDataReader reader = command2.ExecuteReader();

                        if (!reader.Read())
                        {
                            db.closedConnection();
                            int rowIndex = xumbDataGridView.CurrentCell.RowIndex;
                            string value = xumbDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                            string value1 = addNamestextBox.Text;
                            try
                            {
                                SqlCommand command = new SqlCommand("INSERT INTO Names VALUES('" + value + "','" + value1 + "')  ", db.GetConnection());
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
                                addNamestextBox.Text = "";
                            }
                        }
                        else
                        {
                            db.closedConnection();
                            MessageBox.Show("Already have like items");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must select a Group");
                    }
                }
                else
                {
                    nameExpLabel.Visible = true;
                }
            }
            else if (addButton.Text == "Update")
            {
                DB db = new DB();
                int rowIndex = xumbDataGridView.CurrentCell.RowIndex;
                string newvalue = xumbDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                int newintvalue = Convert.ToInt32(newvalue);
                string newvalue1 = addNamestextBox.Text;
                string oldvalue = oldGroupIdLabelNoNVisibility.Text;
                int oldintvalue = Convert.ToInt32(oldvalue);
                string oldvalue1 = oldNameLabel.Text;
                if (newvalue1 != "" )
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("UPDATE Names SET ProducNames = '" + newvalue1 + "', XumbID = '" + newintvalue + "'  WHERE  XumbID = '" + oldintvalue + "' AND  ProducNames = '" + oldvalue1 + "'  ", db.GetConnection());
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
                        addNamestextBox.Text = "";
                        this.Close();
                    }
                }
            }
        }

        private void addNamestextBox_KeyPress(object sender, KeyPressEventArgs e)
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
