using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
            this.addButton.Text = "Add";
            this.oldGroupLabel.Visible = false;
            this.oldGroupNameLabel.Visible = false;
        }
        public AddGroup(string value)
        {
            InitializeComponent();
            this.groupNameTextBox.Text = value;
            this.groupName.Text = "Edit Group Name";
            this.oldGroupNameLabel.Text = value;
            this.addButton.Text = "Update";
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.addButton.Text == "Add")
            {
                if (!String.IsNullOrWhiteSpace(groupNameTextBox.Text))
                {
                    if (groupNameExpLabel.Visible == true)
                    {
                        groupNameExpLabel.Visible = false;
                    }
                    string groupName = groupNameTextBox.Text;
                    DB db = new DB();
                    db.openConnection();
                    SqlCommand command2 = new SqlCommand("SELECT  Xumb.XumbID FROM  Xumb WHERE  Xumb.XumbName ='" + groupName + "'", db.GetConnection());

                    SqlDataReader reader = command2.ExecuteReader();

                    if (!reader.Read())
                    {
                        db.closedConnection();
                        string value = groupNameTextBox.Text;

                        try
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO Xumb VALUES('" + value + "')  ", db.GetConnection());
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
                            groupNameTextBox.Text = "";
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
                    groupNameExpLabel.Visible = true;
                }
            }
            else if (this.addButton.Text == "Update")
            {
                if (!String.IsNullOrWhiteSpace(groupNameTextBox.Text))
                {
                    if (groupNameExpLabel.Visible == true)
                    {
                        groupNameExpLabel.Visible = false;
                    }
                    DB db = new DB();
                    string newvalue = groupNameTextBox.Text;
                    string oldvalue = oldGroupNameLabel.Text;
                    if (newvalue != "")
                    {
                        try
                        {
                            SqlCommand command = new SqlCommand("UPDATE Xumb SET XumbName = '" + newvalue + "'  WHERE  XumbName = '" + oldvalue + "' ", db.GetConnection());
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
                        }
                        this.Close();
                    }
                }
                else
                {
                    groupNameExpLabel.Visible = true;
                }
            }
        }
        private void groupNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
