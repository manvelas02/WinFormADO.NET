
namespace FinalProject
{
    partial class Names
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Names));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.insertButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.ToolStripButton();
            this.nameAndXumbdataGridView = new System.Windows.Forms.DataGridView();
            this.fnprojDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xumbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameAndXumbdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnprojDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xumbBindingSource)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(393, 28);
            this.toolStrip1.TabIndex = 5;
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
            // nameAndXumbdataGridView
            // 
            this.nameAndXumbdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nameAndXumbdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameAndXumbdataGridView.Location = new System.Drawing.Point(0, 28);
            this.nameAndXumbdataGridView.Name = "nameAndXumbdataGridView";
            this.nameAndXumbdataGridView.Size = new System.Drawing.Size(393, 587);
            this.nameAndXumbdataGridView.TabIndex = 6;
            // 
            // Names
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 615);
            this.Controls.Add(this.nameAndXumbdataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Names";
            this.Text = "Names";
            this.Load += new System.EventHandler(this.Names_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameAndXumbdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnprojDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xumbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton insertButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton updateButton;
        private System.Windows.Forms.DataGridView nameAndXumbdataGridView;
        private System.Windows.Forms.BindingSource fnprojDataSet2BindingSource;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private System.Windows.Forms.BindingSource xumbBindingSource;
    }
}