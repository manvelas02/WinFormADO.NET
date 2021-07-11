
namespace FinalProject
{
    partial class Group
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.insertButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.xumbGridView = new System.Windows.Forms.DataGridView();
            this.xumbIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xumbNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xumbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fnprojXumbDataSet = new FinalProject.FnprojXumbDataSet();
            this.xumbTableAdapter = new FinalProject.FnprojXumbDataSetTableAdapters.XumbTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xumbGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xumbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnprojXumbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertButton,
            this.updateButton,
            this.deleteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(397, 28);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // insertButton
            // 
            this.insertButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Image = ((System.Drawing.Image)(resources.GetObject("insertButton.Image")));
            this.insertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(45, 25);
            this.insertButton.Text = "Add";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 25);
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(44, 25);
            this.updateButton.Text = "Edit";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // xumbGridView
            // 
            this.xumbGridView.AutoGenerateColumns = false;
            this.xumbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xumbGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xumbIDDataGridViewTextBoxColumn,
            this.xumbNameDataGridViewTextBoxColumn});
            this.xumbGridView.DataSource = this.xumbBindingSource;
            this.xumbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xumbGridView.Location = new System.Drawing.Point(0, 28);
            this.xumbGridView.Name = "xumbGridView";
            this.xumbGridView.Size = new System.Drawing.Size(397, 584);
            this.xumbGridView.TabIndex = 5;
            // 
            // xumbIDDataGridViewTextBoxColumn
            // 
            this.xumbIDDataGridViewTextBoxColumn.DataPropertyName = "XumbID";
            this.xumbIDDataGridViewTextBoxColumn.HeaderText = "XumbID";
            this.xumbIDDataGridViewTextBoxColumn.Name = "xumbIDDataGridViewTextBoxColumn";
            this.xumbIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xumbNameDataGridViewTextBoxColumn
            // 
            this.xumbNameDataGridViewTextBoxColumn.DataPropertyName = "XumbName";
            this.xumbNameDataGridViewTextBoxColumn.HeaderText = "XumbName";
            this.xumbNameDataGridViewTextBoxColumn.Name = "xumbNameDataGridViewTextBoxColumn";
            // 
            // xumbBindingSource
            // 
            this.xumbBindingSource.DataMember = "Xumb";
            this.xumbBindingSource.DataSource = this.fnprojXumbDataSet;
            // 
            // fnprojXumbDataSet
            // 
            this.fnprojXumbDataSet.DataSetName = "FnprojXumbDataSet";
            this.fnprojXumbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xumbTableAdapter
            // 
            this.xumbTableAdapter.ClearBeforeFill = true;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 612);
            this.Controls.Add(this.xumbGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Group";
            this.Text = "Group";
            this.Load += new System.EventHandler(this.Group_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xumbGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xumbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnprojXumbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.ToolStripButton insertButton;
        private System.Windows.Forms.DataGridView xumbGridView;
        private FnprojXumbDataSet fnprojXumbDataSet;
        private System.Windows.Forms.BindingSource xumbBindingSource;
        private FnprojXumbDataSetTableAdapters.XumbTableAdapter xumbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn xumbIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xumbNameDataGridViewTextBoxColumn;
    }
}