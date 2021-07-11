
namespace FinalProject
{
    partial class moreDoneOperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moreDoneOperationsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.updateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.moreDoneOperationsDataGridView = new System.Windows.Forms.DataGridView();
            this.buyerNameLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moreDoneOperationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripButton,
            this.deleteToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(64, 25);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // updateToolStripButton
            // 
            this.updateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripButton.Image")));
            this.updateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateToolStripButton.Name = "updateToolStripButton";
            this.updateToolStripButton.Size = new System.Drawing.Size(44, 25);
            this.updateToolStripButton.Text = "Edit";
            this.updateToolStripButton.Click += new System.EventHandler(this.updateToolStripButton_Click);
            // 
            // moreDoneOperationsDataGridView
            // 
            this.moreDoneOperationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moreDoneOperationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moreDoneOperationsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.moreDoneOperationsDataGridView.Name = "moreDoneOperationsDataGridView";
            this.moreDoneOperationsDataGridView.Size = new System.Drawing.Size(800, 422);
            this.moreDoneOperationsDataGridView.TabIndex = 1;
            // 
            // buyerNameLabel
            // 
            this.buyerNameLabel.AutoSize = true;
            this.buyerNameLabel.Location = new System.Drawing.Point(168, 12);
            this.buyerNameLabel.Name = "buyerNameLabel";
            this.buyerNameLabel.Size = new System.Drawing.Size(0, 13);
            this.buyerNameLabel.TabIndex = 2;
            // 
            // moreDoneOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buyerNameLabel);
            this.Controls.Add(this.moreDoneOperationsDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "moreDoneOperationsForm";
            this.Text = "moreDoneOperationsForm";
            this.Load += new System.EventHandler(this.moreDoneOperationsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moreDoneOperationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton updateToolStripButton;
        private System.Windows.Forms.DataGridView moreDoneOperationsDataGridView;
        private System.Windows.Forms.Label buyerNameLabel;
    }
}