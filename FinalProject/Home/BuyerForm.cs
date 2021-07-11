using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BuyerForm : Form
    {
        public BuyerForm()
        {
            InitializeComponent();
            LoadData();
            

        }
        public void LoadData()
        {
            DB db = new DB();
            try
            {
                db.openConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Buyer]", db.GetConnection());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.buyerDataGridView.DataSource = dataTable;
                this.buyerDataGridView.Columns[0].Visible = false;
                this.buyerDataGridView.Columns[1].HeaderText = "Buyer Name";
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

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            BuyerAddingForm buyerAddingForm = new BuyerAddingForm();
            buyerAddingForm.ShowDialog();
            LoadData();
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            if (buyerDataGridView.CurrentCell != null)
            {
                int rowIndex = buyerDataGridView.CurrentCell.RowIndex;
                string buyerid = this.buyerDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                string oldname = buyerDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                BuyerAddingForm buyerAddingForm = new BuyerAddingForm(oldname, buyerid);
                buyerAddingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an item wath you want edit");
            }
            LoadData();

        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (buyerDataGridView.CurrentCell != null)
            {
                int rowIndex = buyerDataGridView.CurrentCell.RowIndex;
                string buyerid = this.buyerDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                DB db = new DB();

                db.openConnection();
                SqlCommand command2 = new SqlCommand("SELECT  Buyer.BuyerName FROM  Buyer INNER JOIN DocExp ON Buyer.BuyerID = DocExp.BuyerID  WHERE  Buyer.BuyerID ='" + buyerid + "'", db.GetConnection());

                SqlDataReader reader = command2.ExecuteReader();

                if (!reader.Read())
                {
                    db.closedConnection();
                    try
                    {
                        db.openConnection();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("DELETE  FROM [Buyer] WHERE BuyerID = '" + buyerid + "'", db.GetConnection());
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        this.buyerDataGridView.DataSource = dataTable;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
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
                    MessageBox.Show("You can't delete this group because it is used");
                }
            }
            else
            {
                MessageBox.Show("Please select an item wath you want delete");
                LoadData();
            }
        }
    }
}
