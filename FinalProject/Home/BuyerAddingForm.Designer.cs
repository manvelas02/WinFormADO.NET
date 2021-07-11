
namespace FinalProject
{
    partial class BuyerAddingForm
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
            this.buyerNameTextBox = new System.Windows.Forms.TextBox();
            this.addEditbutton = new System.Windows.Forms.Button();
            this.buyerLabel = new System.Windows.Forms.Label();
            this.oldBuyerLabel = new System.Windows.Forms.Label();
            this.oldBuyerNameLabel = new System.Windows.Forms.Label();
            this.nonVisibleBuyerId = new System.Windows.Forms.Label();
            this.buyerNameExpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buyerNameTextBox
            // 
            this.buyerNameTextBox.Location = new System.Drawing.Point(20, 61);
            this.buyerNameTextBox.Multiline = true;
            this.buyerNameTextBox.Name = "buyerNameTextBox";
            this.buyerNameTextBox.Size = new System.Drawing.Size(185, 43);
            this.buyerNameTextBox.TabIndex = 0;
            this.buyerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buyerNameTextBox_KeyPress);
            // 
            // addEditbutton
            // 
            this.addEditbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditbutton.Location = new System.Drawing.Point(329, 61);
            this.addEditbutton.Name = "addEditbutton";
            this.addEditbutton.Size = new System.Drawing.Size(117, 43);
            this.addEditbutton.TabIndex = 1;
            this.addEditbutton.UseVisualStyleBackColor = true;
            this.addEditbutton.Click += new System.EventHandler(this.addEditbutton_Click);
            // 
            // buyerLabel
            // 
            this.buyerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerLabel.Location = new System.Drawing.Point(20, 22);
            this.buyerLabel.Name = "buyerLabel";
            this.buyerLabel.Size = new System.Drawing.Size(185, 36);
            this.buyerLabel.TabIndex = 2;
            this.buyerLabel.Text = "Add Buyer Name";
            this.buyerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldBuyerLabel
            // 
            this.oldBuyerLabel.AutoSize = true;
            this.oldBuyerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldBuyerLabel.Location = new System.Drawing.Point(20, 147);
            this.oldBuyerLabel.Name = "oldBuyerLabel";
            this.oldBuyerLabel.Size = new System.Drawing.Size(153, 20);
            this.oldBuyerLabel.TabIndex = 3;
            this.oldBuyerLabel.Text = "Old Buyer Name : ";
            // 
            // oldBuyerNameLabel
            // 
            this.oldBuyerNameLabel.AutoSize = true;
            this.oldBuyerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldBuyerNameLabel.Location = new System.Drawing.Point(177, 147);
            this.oldBuyerNameLabel.Name = "oldBuyerNameLabel";
            this.oldBuyerNameLabel.Size = new System.Drawing.Size(0, 20);
            this.oldBuyerNameLabel.TabIndex = 4;
            // 
            // nonVisibleBuyerId
            // 
            this.nonVisibleBuyerId.AutoSize = true;
            this.nonVisibleBuyerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonVisibleBuyerId.Location = new System.Drawing.Point(57, 2);
            this.nonVisibleBuyerId.Name = "nonVisibleBuyerId";
            this.nonVisibleBuyerId.Size = new System.Drawing.Size(0, 20);
            this.nonVisibleBuyerId.TabIndex = 5;
            // 
            // buyerNameExpLabel
            // 
            this.buyerNameExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerNameExpLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.buyerNameExpLabel.Location = new System.Drawing.Point(16, 107);
            this.buyerNameExpLabel.Name = "buyerNameExpLabel";
            this.buyerNameExpLabel.Size = new System.Drawing.Size(303, 28);
            this.buyerNameExpLabel.TabIndex = 6;
            this.buyerNameExpLabel.Text = "You must enter a buyer name";
            this.buyerNameExpLabel.Visible = false;
            // 
            // BuyerAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 186);
            this.Controls.Add(this.buyerNameExpLabel);
            this.Controls.Add(this.nonVisibleBuyerId);
            this.Controls.Add(this.oldBuyerNameLabel);
            this.Controls.Add(this.oldBuyerLabel);
            this.Controls.Add(this.buyerLabel);
            this.Controls.Add(this.addEditbutton);
            this.Controls.Add(this.buyerNameTextBox);
            this.Name = "BuyerAddingForm";
            this.Text = "BuyerAddingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buyerNameTextBox;
        private System.Windows.Forms.Button addEditbutton;
        private System.Windows.Forms.Label buyerLabel;
        private System.Windows.Forms.Label oldBuyerLabel;
        private System.Windows.Forms.Label oldBuyerNameLabel;
        private System.Windows.Forms.Label nonVisibleBuyerId;
        private System.Windows.Forms.Label buyerNameExpLabel;
    }
}