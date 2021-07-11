
namespace FinalProject
{
    partial class AddNames
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.oldGroupIdLabelNoNVisibility = new System.Windows.Forms.Label();
            this.oldGroupNameLable = new System.Windows.Forms.Label();
            this.oldGroupLable = new System.Windows.Forms.Label();
            this.oldNameLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addNamestextBox = new System.Windows.Forms.TextBox();
            this.addNamesLabel = new System.Windows.Forms.Label();
            this.xumbDataGridView = new System.Windows.Forms.DataGridView();
            this.xumbIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xumbNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xumbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fnprojXumbDataSet = new FinalProject.FnprojXumbDataSet();
            this.xumbTableAdapter = new FinalProject.FnprojXumbDataSetTableAdapters.XumbTableAdapter();
            this.nameExpLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xumbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xumbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnprojXumbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameExpLabel);
            this.panel1.Controls.Add(this.oldGroupIdLabelNoNVisibility);
            this.panel1.Controls.Add(this.oldGroupNameLable);
            this.panel1.Controls.Add(this.oldGroupLable);
            this.panel1.Controls.Add(this.oldNameLabel);
            this.panel1.Controls.Add(this.productLabel);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.addNamestextBox);
            this.panel1.Controls.Add(this.addNamesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 374);
            this.panel1.TabIndex = 7;
            // 
            // oldGroupIdLabelNoNVisibility
            // 
            this.oldGroupIdLabelNoNVisibility.AutoSize = true;
            this.oldGroupIdLabelNoNVisibility.Location = new System.Drawing.Point(64, 233);
            this.oldGroupIdLabelNoNVisibility.Name = "oldGroupIdLabelNoNVisibility";
            this.oldGroupIdLabelNoNVisibility.Size = new System.Drawing.Size(0, 13);
            this.oldGroupIdLabelNoNVisibility.TabIndex = 13;
            // 
            // oldGroupNameLable
            // 
            this.oldGroupNameLable.AutoSize = true;
            this.oldGroupNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldGroupNameLable.Location = new System.Drawing.Point(114, 177);
            this.oldGroupNameLable.Name = "oldGroupNameLable";
            this.oldGroupNameLable.Size = new System.Drawing.Size(0, 20);
            this.oldGroupNameLable.TabIndex = 12;
            // 
            // oldGroupLable
            // 
            this.oldGroupLable.AutoSize = true;
            this.oldGroupLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldGroupLable.Location = new System.Drawing.Point(22, 177);
            this.oldGroupLable.Name = "oldGroupLable";
            this.oldGroupLable.Size = new System.Drawing.Size(74, 20);
            this.oldGroupLable.TabIndex = 11;
            this.oldGroupLable.Text = "Group : ";
            // 
            // oldNameLabel
            // 
            this.oldNameLabel.AutoSize = true;
            this.oldNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldNameLabel.Location = new System.Drawing.Point(114, 119);
            this.oldNameLabel.Name = "oldNameLabel";
            this.oldNameLabel.Size = new System.Drawing.Size(0, 20);
            this.oldNameLabel.TabIndex = 10;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(22, 119);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(86, 20);
            this.productLabel.TabIndex = 9;
            this.productLabel.Text = "Product : ";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(155, 39);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 40);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addNamestextBox
            // 
            this.addNamestextBox.Location = new System.Drawing.Point(12, 39);
            this.addNamestextBox.Multiline = true;
            this.addNamestextBox.Name = "addNamestextBox";
            this.addNamestextBox.Size = new System.Drawing.Size(116, 40);
            this.addNamestextBox.TabIndex = 0;
            this.addNamestextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addNamestextBox_KeyPress);
            // 
            // addNamesLabel
            // 
            this.addNamesLabel.AutoSize = true;
            this.addNamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNamesLabel.Location = new System.Drawing.Point(19, 15);
            this.addNamesLabel.Name = "addNamesLabel";
            this.addNamesLabel.Size = new System.Drawing.Size(92, 20);
            this.addNamesLabel.TabIndex = 1;
            this.addNamesLabel.Text = "Add Name";
            // 
            // xumbDataGridView
            // 
            this.xumbDataGridView.AutoGenerateColumns = false;
            this.xumbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xumbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xumbIDDataGridViewTextBoxColumn,
            this.xumbNameDataGridViewTextBoxColumn});
            this.xumbDataGridView.DataSource = this.xumbBindingSource;
            this.xumbDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xumbDataGridView.Location = new System.Drawing.Point(247, 0);
            this.xumbDataGridView.Name = "xumbDataGridView";
            this.xumbDataGridView.Size = new System.Drawing.Size(268, 374);
            this.xumbDataGridView.TabIndex = 8;
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
            // nameExpLabel
            // 
            this.nameExpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nameExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameExpLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.nameExpLabel.Location = new System.Drawing.Point(12, 82);
            this.nameExpLabel.Name = "nameExpLabel";
            this.nameExpLabel.Size = new System.Drawing.Size(229, 26);
            this.nameExpLabel.TabIndex = 14;
            this.nameExpLabel.Text = "You must enter a name";
            this.nameExpLabel.Visible = false;
            // 
            // AddNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 374);
            this.Controls.Add(this.xumbDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "AddNames";
            this.Text = "AddNames";
            this.Load += new System.EventHandler(this.AddNames_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xumbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xumbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnprojXumbDataSet)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label addNamesLabel;
        private System.Windows.Forms.TextBox addNamestextBox;
        private System.Windows.Forms.DataGridView xumbDataGridView;
        private FnprojXumbDataSet fnprojXumbDataSet;
        private System.Windows.Forms.BindingSource xumbBindingSource;
        private FnprojXumbDataSetTableAdapters.XumbTableAdapter xumbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn xumbIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xumbNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label oldGroupNameLable;
        private System.Windows.Forms.Label oldGroupLable;
        private System.Windows.Forms.Label oldNameLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label oldGroupIdLabelNoNVisibility;
        private System.Windows.Forms.Label nameExpLabel;
    }
}