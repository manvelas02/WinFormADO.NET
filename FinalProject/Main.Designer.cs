
namespace FinalProject
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.doneOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namesToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.buyerToolStripMenuItem});
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // namesToolStripMenuItem
            // 
            this.namesToolStripMenuItem.Name = "namesToolStripMenuItem";
            this.namesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.namesToolStripMenuItem.Text = "Product List";
            this.namesToolStripMenuItem.Click += new System.EventHandler(this.namesToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // buyerToolStripMenuItem
            // 
            this.buyerToolStripMenuItem.Name = "buyerToolStripMenuItem";
            this.buyerToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.buyerToolStripMenuItem.Text = "Buyer";
            this.buyerToolStripMenuItem.Click += new System.EventHandler(this.գնորդToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expencesToolStripMenuItem});
            this.operationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // expencesToolStripMenuItem
            // 
            this.expencesToolStripMenuItem.Name = "expencesToolStripMenuItem";
            this.expencesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.expencesToolStripMenuItem.Text = "Expences";
            this.expencesToolStripMenuItem.Click += new System.EventHandler(this.expensesToolStripMenuItem_Click);
            // 
            // doneOperationsToolStripMenuItem
            // 
            this.doneOperationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneOperationsToolStripMenuItem.Name = "doneOperationsToolStripMenuItem";
            this.doneOperationsToolStripMenuItem.Size = new System.Drawing.Size(151, 25);
            this.doneOperationsToolStripMenuItem.Text = "Done Operations";
            this.doneOperationsToolStripMenuItem.Click += new System.EventHandler(this.կատարվածԳործողություններToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 488);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneOperationsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem buyerToolStripMenuItem;
    }
}

