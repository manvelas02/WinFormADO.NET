using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Group : Form
    {

        

        public Group()
        {
            InitializeComponent();
            xumbGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Group_Load(object sender, EventArgs e)
        {
            LoadData();

            this.xumbGridView.Columns[0].Visible = false;
            this.xumbGridView.Columns[1].HeaderText = "Xumb";
        }

        public void LoadData()
        {
            DB db = new DB();
            db.openConnection();
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Xumb]", db.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.xumbGridView.DataSource = dataTable;
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

        private void insertButton_Click(object sender, EventArgs e)
        {
            AddGroup addGroup = new AddGroup();
            addGroup.ShowDialog();
            LoadData();

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (xumbGridView.CurrentCell != null)
            {
                DB db = new DB();
                int rowIndex = xumbGridView.CurrentCell.RowIndex;
                string xumbId = xumbGridView.Rows[rowIndex].Cells[0].Value.ToString();

                db.openConnection();
                SqlCommand command2 = new SqlCommand("SELECT  Xumb.XumbName FROM  Xumb INNER JOIN Names ON Xumb.XumbID = Names.XumbID  WHERE  Xumb.XumbID ='" + xumbId + "'", db.GetConnection());

                SqlDataReader reader = command2.ExecuteReader();

                if (!reader.Read())
                {
                    db.closedConnection();
                    try
                    {
                        db.openConnection();
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand("DELETE  Xumb WHERE  XumbID = '" + xumbId + "' ", db.GetConnection());
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    finally
                    {
                        LoadData();
                        db.closedConnection();
                    }
                }
                else
                {
                    db.closedConnection();
                    MessageBox.Show("You can't delete this group because it is used");
                }
            }
            else
            {
                MessageBox.Show("Please select a item wath you want delete");
                LoadData();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (xumbGridView.CurrentCell != null)
            {
                int rowIndex = xumbGridView.CurrentCell.RowIndex;
                string value = xumbGridView.Rows[rowIndex].Cells[1].Value.ToString();

                AddGroup addGroup = new AddGroup(value);
                addGroup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a item wath you want edit");
            }
            LoadData();
        }
    }
}
