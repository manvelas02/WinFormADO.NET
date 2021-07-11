using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
            nameAndXumbdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //0 indexy Names ID
        //1 indexy XumbID
        //2 indexy ProducNames
        //3 indexy XumbName

        private void Names_Load_1(object sender, EventArgs e)
        {
            LoadData();
            this.nameAndXumbdataGridView.Columns[0].Visible = false;
            this.nameAndXumbdataGridView.Columns[1].Visible = false;
            this.nameAndXumbdataGridView.Columns[2].HeaderText = "Product";
            this.nameAndXumbdataGridView.Columns[3].HeaderText = "Xumb";
        }

        public void LoadData()
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Names.NamesID,Names.XumbID,Names.ProducNames,Xumb.XumbName FROM [Names] INNER JOIN [Xumb] ON Xumb.XumbID = Names.XumbID", db.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                nameAndXumbdataGridView.DataSource = dataTable;
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
            AddNames addNames = new AddNames();
            addNames.Show();
            LoadData();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameAndXumbdataGridView.CurrentCell != null)
            {
                int rowIndex = nameAndXumbdataGridView.CurrentCell.RowIndex;
                string nameId = nameAndXumbdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                DB db = new DB();
                db.openConnection();
                SqlCommand command2 = new SqlCommand("SELECT  Paid.NamesID FROM  Paid INNER JOIN Names ON Paid.NamesID = Names.NamesID  WHERE  Paid.NamesID ='" + nameId + "'", db.GetConnection());

                SqlDataReader reader = command2.ExecuteReader();

                if (!reader.Read())
                {
                    db.closedConnection();
                    try
                    {
                        db.openConnection();
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand("DELETE  Names WHERE  NamesID = '" + nameId + "' ", db.GetConnection());
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
                        LoadData();
                    }
                }
                else
                {
                    db.closedConnection();
                    MessageBox.Show("You can't delete this Product because it is used");
                }


                
            }
            else
            {
                MessageBox.Show("Please select wath you want delete");
                LoadData();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (nameAndXumbdataGridView.CurrentCell != null)
            {
                int rowIndex = nameAndXumbdataGridView.CurrentCell.RowIndex;
                string xumbId = nameAndXumbdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                string prodName = nameAndXumbdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                string xumbName = nameAndXumbdataGridView.Rows[rowIndex].Cells[3].Value.ToString();

                AddNames addNames = new AddNames(xumbId, prodName, xumbName);
                addNames.Show();
            }
            else
            {
                MessageBox.Show("Please select wath you want edit");
            }
            LoadData();
        }
    }
}
