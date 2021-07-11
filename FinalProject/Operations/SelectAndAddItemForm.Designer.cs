
namespace FinalProject
{
    partial class SelectAndAddItemForm
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
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.cancleButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nonVisibleIdLabel = new System.Windows.Forms.Label();
            this.productComboBoxLabel = new System.Windows.Forms.Label();
            this.quantityExpLabel = new System.Windows.Forms.Label();
            this.priceExpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(38, 47);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(468, 21);
            this.productComboBox.TabIndex = 0;
            this.productComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productComboBox_KeyPress);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(39, 137);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(119, 27);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(372, 137);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(119, 27);
            this.priceTextBox.TabIndex = 2;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(39, 102);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(119, 28);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(372, 102);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(119, 28);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productLabel
            // 
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(38, 10);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(468, 34);
            this.productLabel.TabIndex = 7;
            this.productLabel.Text = "Select Product";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancleButton
            // 
            this.cancleButton.BackColor = System.Drawing.Color.Red;
            this.cancleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleButton.Location = new System.Drawing.Point(289, 192);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(217, 37);
            this.cancleButton.TabIndex = 11;
            this.cancleButton.Text = "Cancle";
            this.cancleButton.UseVisualStyleBackColor = false;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(38, 192);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(217, 37);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nonVisibleIdLabel
            // 
            this.nonVisibleIdLabel.AutoSize = true;
            this.nonVisibleIdLabel.Location = new System.Drawing.Point(194, 131);
            this.nonVisibleIdLabel.Name = "nonVisibleIdLabel";
            this.nonVisibleIdLabel.Size = new System.Drawing.Size(0, 13);
            this.nonVisibleIdLabel.TabIndex = 12;
            // 
            // productComboBoxLabel
            // 
            this.productComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboBoxLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.productComboBoxLabel.Location = new System.Drawing.Point(39, 71);
            this.productComboBoxLabel.Name = "productComboBoxLabel";
            this.productComboBoxLabel.Size = new System.Drawing.Size(467, 31);
            this.productComboBoxLabel.TabIndex = 13;
            this.productComboBoxLabel.Text = "You must select a product";
            this.productComboBoxLabel.Visible = false;
            // 
            // quantityExpLabel
            // 
            this.quantityExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityExpLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.quantityExpLabel.Location = new System.Drawing.Point(12, 167);
            this.quantityExpLabel.Name = "quantityExpLabel";
            this.quantityExpLabel.Size = new System.Drawing.Size(271, 22);
            this.quantityExpLabel.TabIndex = 14;
            this.quantityExpLabel.Text = "You must enter a Quantity";
            this.quantityExpLabel.Visible = false;
            // 
            // priceExpLabel
            // 
            this.priceExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceExpLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.priceExpLabel.Location = new System.Drawing.Point(303, 168);
            this.priceExpLabel.Name = "priceExpLabel";
            this.priceExpLabel.Size = new System.Drawing.Size(234, 21);
            this.priceExpLabel.TabIndex = 15;
            this.priceExpLabel.Text = "You must enter a Price";
            this.priceExpLabel.Visible = false;
            // 
            // SelectAndAddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 246);
            this.Controls.Add(this.priceExpLabel);
            this.Controls.Add(this.quantityExpLabel);
            this.Controls.Add(this.productComboBoxLabel);
            this.Controls.Add(this.nonVisibleIdLabel);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productComboBox);
            this.Name = "SelectAndAddItemForm";
            this.Text = "SelectAndAddItemForm";
            this.Load += new System.EventHandler(this.SelectAndAddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label nonVisibleIdLabel;
        private System.Windows.Forms.Label productComboBoxLabel;
        private System.Windows.Forms.Label quantityExpLabel;
        private System.Windows.Forms.Label priceExpLabel;
    }
}