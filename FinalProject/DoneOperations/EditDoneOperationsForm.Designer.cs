
namespace FinalProject
{
    partial class EditDoneOperationsForm
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
            this.timeNowLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nonVisibleIdLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.cancleButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.nonVisiblepaidIDLabel = new System.Windows.Forms.Label();
            this.nonVisibledocIDLabel = new System.Windows.Forms.Label();
            this.editQuantityExpLabel = new System.Windows.Forms.Label();
            this.editComboBoxExpLabel = new System.Windows.Forms.Label();
            this.editPriceExpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeNowLabel
            // 
            this.timeNowLabel.AutoSize = true;
            this.timeNowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNowLabel.Location = new System.Drawing.Point(111, 268);
            this.timeNowLabel.Name = "timeNowLabel";
            this.timeNowLabel.Size = new System.Drawing.Size(0, 16);
            this.timeNowLabel.TabIndex = 15;
            this.timeNowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(24, 268);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(81, 16);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Today is : ";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(27, 229);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(532, 22);
            this.dateTimePicker.TabIndex = 14;
            // 
            // nonVisibleIdLabel
            // 
            this.nonVisibleIdLabel.AutoSize = true;
            this.nonVisibleIdLabel.Location = new System.Drawing.Point(178, 148);
            this.nonVisibleIdLabel.Name = "nonVisibleIdLabel";
            this.nonVisibleIdLabel.Size = new System.Drawing.Size(0, 13);
            this.nonVisibleIdLabel.TabIndex = 22;
            // 
            // productLabel
            // 
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(23, 19);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(536, 34);
            this.productLabel.TabIndex = 21;
            this.productLabel.Text = "Select Product";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(423, 119);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(119, 28);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(23, 119);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(119, 28);
            this.quantityLabel.TabIndex = 19;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(423, 154);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(119, 27);
            this.priceTextBox.TabIndex = 18;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(23, 154);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(119, 27);
            this.quantityTextBox.TabIndex = 17;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(23, 56);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(536, 21);
            this.productComboBox.TabIndex = 16;
            this.productComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productComboBox_KeyPress);
            // 
            // cancleButton
            // 
            this.cancleButton.BackColor = System.Drawing.Color.Red;
            this.cancleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleButton.Location = new System.Drawing.Point(342, 316);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(217, 37);
            this.cancleButton.TabIndex = 26;
            this.cancleButton.Text = "Cancle";
            this.cancleButton.UseVisualStyleBackColor = false;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Green;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(23, 316);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(217, 37);
            this.updateButton.TabIndex = 25;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // nonVisiblepaidIDLabel
            // 
            this.nonVisiblepaidIDLabel.AutoSize = true;
            this.nonVisiblepaidIDLabel.Location = new System.Drawing.Point(24, 22);
            this.nonVisiblepaidIDLabel.Name = "nonVisiblepaidIDLabel";
            this.nonVisiblepaidIDLabel.Size = new System.Drawing.Size(0, 13);
            this.nonVisiblepaidIDLabel.TabIndex = 27;
            // 
            // nonVisibledocIDLabel
            // 
            this.nonVisibledocIDLabel.AutoSize = true;
            this.nonVisibledocIDLabel.Location = new System.Drawing.Point(396, 22);
            this.nonVisibledocIDLabel.Name = "nonVisibledocIDLabel";
            this.nonVisibledocIDLabel.Size = new System.Drawing.Size(0, 13);
            this.nonVisibledocIDLabel.TabIndex = 28;
            // 
            // editQuantityExpLabel
            // 
            this.editQuantityExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuantityExpLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.editQuantityExpLabel.Location = new System.Drawing.Point(12, 184);
            this.editQuantityExpLabel.Name = "editQuantityExpLabel";
            this.editQuantityExpLabel.Size = new System.Drawing.Size(251, 34);
            this.editQuantityExpLabel.TabIndex = 29;
            this.editQuantityExpLabel.Text = "You must enter a Quantity";
            this.editQuantityExpLabel.Visible = false;
            // 
            // editComboBoxExpLabel
            // 
            this.editComboBoxExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editComboBoxExpLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.editComboBoxExpLabel.Location = new System.Drawing.Point(24, 90);
            this.editComboBoxExpLabel.Name = "editComboBoxExpLabel";
            this.editComboBoxExpLabel.Size = new System.Drawing.Size(469, 29);
            this.editComboBoxExpLabel.TabIndex = 30;
            this.editComboBoxExpLabel.Text = "You must select a product";
            this.editComboBoxExpLabel.Visible = false;
            // 
            // editPriceExpLabel
            // 
            this.editPriceExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPriceExpLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.editPriceExpLabel.Location = new System.Drawing.Point(338, 184);
            this.editPriceExpLabel.Name = "editPriceExpLabel";
            this.editPriceExpLabel.Size = new System.Drawing.Size(226, 31);
            this.editPriceExpLabel.TabIndex = 31;
            this.editPriceExpLabel.Text = "You must enter a Price";
            this.editPriceExpLabel.Visible = false;
            // 
            // EditDoneOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 373);
            this.Controls.Add(this.editPriceExpLabel);
            this.Controls.Add(this.editComboBoxExpLabel);
            this.Controls.Add(this.editQuantityExpLabel);
            this.Controls.Add(this.nonVisibledocIDLabel);
            this.Controls.Add(this.nonVisiblepaidIDLabel);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.nonVisibleIdLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.timeNowLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "EditDoneOperationsForm";
            this.Text = "EditDoneOperationsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeNowLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label nonVisibleIdLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label nonVisiblepaidIDLabel;
        private System.Windows.Forms.Label nonVisibledocIDLabel;
        private System.Windows.Forms.Label editQuantityExpLabel;
        private System.Windows.Forms.Label editComboBoxExpLabel;
        private System.Windows.Forms.Label editPriceExpLabel;
    }
}