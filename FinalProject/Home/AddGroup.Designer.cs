
namespace FinalProject
{
    partial class AddGroup
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
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.groupName = new System.Windows.Forms.Label();
            this.oldGroupNameLabel = new System.Windows.Forms.Label();
            this.oldGroupLabel = new System.Windows.Forms.Label();
            this.groupNameExpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(28, 44);
            this.groupNameTextBox.Multiline = true;
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(142, 39);
            this.groupNameTextBox.TabIndex = 0;
            this.groupNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupNameTextBox_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(261, 47);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 36);
            this.addButton.TabIndex = 2;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupName
            // 
            this.groupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupName.Location = new System.Drawing.Point(24, 9);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(147, 32);
            this.groupName.TabIndex = 3;
            this.groupName.Text = "Group Name";
            this.groupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldGroupNameLabel
            // 
            this.oldGroupNameLabel.AutoSize = true;
            this.oldGroupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldGroupNameLabel.Location = new System.Drawing.Point(187, 116);
            this.oldGroupNameLabel.Name = "oldGroupNameLabel";
            this.oldGroupNameLabel.Size = new System.Drawing.Size(0, 20);
            this.oldGroupNameLabel.TabIndex = 4;
            // 
            // oldGroupLabel
            // 
            this.oldGroupLabel.AutoSize = true;
            this.oldGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldGroupLabel.Location = new System.Drawing.Point(24, 116);
            this.oldGroupLabel.Name = "oldGroupLabel";
            this.oldGroupLabel.Size = new System.Drawing.Size(157, 20);
            this.oldGroupLabel.TabIndex = 5;
            this.oldGroupLabel.Text = "Old Group Name : ";
            // 
            // groupNameExpLabel
            // 
            this.groupNameExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameExpLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.groupNameExpLabel.Location = new System.Drawing.Point(24, 86);
            this.groupNameExpLabel.Name = "groupNameExpLabel";
            this.groupNameExpLabel.Size = new System.Drawing.Size(292, 30);
            this.groupNameExpLabel.TabIndex = 6;
            this.groupNameExpLabel.Text = "You must enter a grup name";
            this.groupNameExpLabel.Visible = false;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 147);
            this.Controls.Add(this.groupNameExpLabel);
            this.Controls.Add(this.oldGroupLabel);
            this.Controls.Add(this.oldGroupNameLabel);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupNameTextBox);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label groupName;
        private System.Windows.Forms.Label oldGroupNameLabel;
        private System.Windows.Forms.Label oldGroupLabel;
        private System.Windows.Forms.Label groupNameExpLabel;
    }
}