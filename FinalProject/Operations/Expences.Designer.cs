
using System;
using System.Windows.Forms;

namespace FinalProject
{
    partial class Expences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expences));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buyertabPage = new System.Windows.Forms.TabPage();
            this.timeNowLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buyerNameComboBox = new System.Windows.Forms.ComboBox();
            this.buyerNameLabel = new System.Windows.Forms.Label();
            this.costtabPage = new System.Windows.Forms.TabPage();
            this.naxnakanPaidDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.Button();
            this.cancleButton = new System.Windows.Forms.Button();
            this.checkBoxExaptionLable = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.buyertabPage.SuspendLayout();
            this.costtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naxnakanPaidDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.buyertabPage);
            this.tabControl1.Controls.Add(this.costtabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 235);
            this.tabControl1.TabIndex = 0;
            // 
            // buyertabPage
            // 
            this.buyertabPage.Controls.Add(this.checkBoxExaptionLable);
            this.buyertabPage.Controls.Add(this.timeNowLabel);
            this.buyertabPage.Controls.Add(this.timeLabel);
            this.buyertabPage.Controls.Add(this.dateTimePicker);
            this.buyertabPage.Controls.Add(this.buyerNameComboBox);
            this.buyertabPage.Controls.Add(this.buyerNameLabel);
            this.buyertabPage.Location = new System.Drawing.Point(4, 22);
            this.buyertabPage.Name = "buyertabPage";
            this.buyertabPage.Padding = new System.Windows.Forms.Padding(3);
            this.buyertabPage.Size = new System.Drawing.Size(465, 209);
            this.buyertabPage.TabIndex = 0;
            this.buyertabPage.Text = "Buyer Page";
            this.buyertabPage.UseVisualStyleBackColor = true;
            // 
            // timeNowLabel
            // 
            this.timeNowLabel.AutoSize = true;
            this.timeNowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNowLabel.Location = new System.Drawing.Point(96, 178);
            this.timeNowLabel.Name = "timeNowLabel";
            this.timeNowLabel.Size = new System.Drawing.Size(0, 16);
            this.timeNowLabel.TabIndex = 12;
            this.timeNowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(9, 178);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(81, 16);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Today is : ";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 109);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(429, 22);
            this.dateTimePicker.TabIndex = 10;
            // 
            // buyerNameComboBox
            // 
            this.buyerNameComboBox.FormattingEnabled = true;
            this.buyerNameComboBox.Location = new System.Drawing.Point(11, 49);
            this.buyerNameComboBox.Name = "buyerNameComboBox";
            this.buyerNameComboBox.Size = new System.Drawing.Size(426, 21);
            this.buyerNameComboBox.TabIndex = 11;
            this.buyerNameComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buyerNameComboBox_KeyPress);
            // 
            // buyerNameLabel
            // 
            this.buyerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerNameLabel.Location = new System.Drawing.Point(12, 9);
            this.buyerNameLabel.Name = "buyerNameLabel";
            this.buyerNameLabel.Size = new System.Drawing.Size(426, 36);
            this.buyerNameLabel.TabIndex = 3;
            this.buyerNameLabel.Text = "Enter Buyer Name";
            this.buyerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costtabPage
            // 
            this.costtabPage.Controls.Add(this.naxnakanPaidDataGridView);
            this.costtabPage.Controls.Add(this.toolStrip1);
            this.costtabPage.Location = new System.Drawing.Point(4, 22);
            this.costtabPage.Name = "costtabPage";
            this.costtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.costtabPage.Size = new System.Drawing.Size(465, 209);
            this.costtabPage.TabIndex = 1;
            this.costtabPage.Text = "Expances";
            this.costtabPage.UseVisualStyleBackColor = true;
            // 
            // naxnakanPaidDataGridView
            // 
            this.naxnakanPaidDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.naxnakanPaidDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naxnakanPaidDataGridView.Location = new System.Drawing.Point(3, 28);
            this.naxnakanPaidDataGridView.Name = "naxnakanPaidDataGridView";
            this.naxnakanPaidDataGridView.Size = new System.Drawing.Size(459, 178);
            this.naxnakanPaidDataGridView.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(459, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(33, 22);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(32, 22);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(12, 241);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(217, 37);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancleButton
            // 
            this.cancleButton.BackColor = System.Drawing.Color.Red;
            this.cancleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleButton.Location = new System.Drawing.Point(250, 241);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(217, 37);
            this.cancleButton.TabIndex = 9;
            this.cancleButton.Text = "Cancle";
            this.cancleButton.UseVisualStyleBackColor = false;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // checkBoxExaptionLable
            // 
            this.checkBoxExaptionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExaptionLable.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxExaptionLable.Location = new System.Drawing.Point(12, 73);
            this.checkBoxExaptionLable.Name = "checkBoxExaptionLable";
            this.checkBoxExaptionLable.Size = new System.Drawing.Size(426, 17);
            this.checkBoxExaptionLable.TabIndex = 13;
            this.checkBoxExaptionLable.Text = "You must select Buyer Name";
            this.checkBoxExaptionLable.Visible = false;
            // 
            // Expences
            // 
            this.ClientSize = new System.Drawing.Size(473, 289);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Expences";
            this.Load += new System.EventHandler(this.Expences_Load);
            this.tabControl1.ResumeLayout(false);
            this.buyertabPage.ResumeLayout(false);
            this.buyertabPage.PerformLayout();
            this.costtabPage.ResumeLayout(false);
            this.costtabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naxnakanPaidDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        private Label buyerNameLabel;
        private Label timeLabel;
        private Button addButton;
        #endregion
        private DateTimePicker dateTimePicker;
        private ComboBox buyerNameComboBox;
        private Label timeNowLabel;
        private TabControl tabControl1;
        private TabPage buyertabPage;
        private TabPage costtabPage;
        private Button cancleButton;
        public  DataGridView naxnakanPaidDataGridView;
        private ToolStrip toolStrip1;
        private ToolStripButton addToolStripButton;
        private ToolStripButton editToolStripButton;
        private ToolStripButton deleteToolStripButton;
        private Label checkBoxExaptionLable;
    }
}