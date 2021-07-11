
namespace FinalProject
{
    partial class DoneOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoneOperations));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.moreToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.doneOperationDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doneOperationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // moreToolStripButton
            // 
            this.moreToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moreToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("moreToolStripButton.Image")));
            this.moreToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moreToolStripButton.Name = "moreToolStripButton";
            this.moreToolStripButton.Size = new System.Drawing.Size(54, 25);
            this.moreToolStripButton.Text = "More";
            this.moreToolStripButton.Click += new System.EventHandler(this.moreToolStripButton_Click);
            // 
            // doneOperationDataGridView
            // 
            this.doneOperationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doneOperationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doneOperationDataGridView.Location = new System.Drawing.Point(0, 28);
            this.doneOperationDataGridView.Name = "doneOperationDataGridView";
            this.doneOperationDataGridView.Size = new System.Drawing.Size(800, 422);
            this.doneOperationDataGridView.TabIndex = 4;
            // 
            // DoneOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneOperationDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DoneOperations";
            this.Text = "DoneOperations";
            this.Load += new System.EventHandler(this.DoneOperations_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doneOperationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton moreToolStripButton;
        private System.Windows.Forms.DataGridView doneOperationDataGridView;
    }
}