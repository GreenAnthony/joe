namespace Joes_Automotive
{
    partial class Form1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.pageButton = new System.Windows.Forms.Button();
            this.vehiclebox = new System.Windows.Forms.CheckBox();
            this.customersBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 199);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pageButton
            // 
            this.pageButton.Location = new System.Drawing.Point(187, 199);
            this.pageButton.Name = "pageButton";
            this.pageButton.Size = new System.Drawing.Size(90, 37);
            this.pageButton.TabIndex = 3;
            this.pageButton.Text = "Next Page";
            this.pageButton.UseVisualStyleBackColor = true;
            this.pageButton.Click += new System.EventHandler(this.pageButton_Click);
            // 
            // vehiclebox
            // 
            this.vehiclebox.AutoSize = true;
            this.vehiclebox.Location = new System.Drawing.Point(187, 44);
            this.vehiclebox.Name = "vehiclebox";
            this.vehiclebox.Size = new System.Drawing.Size(66, 17);
            this.vehiclebox.TabIndex = 4;
            this.vehiclebox.Text = "Vehicles";
            this.vehiclebox.UseVisualStyleBackColor = true;
            // 
            // customersBox
            // 
            this.customersBox.AutoSize = true;
            this.customersBox.Location = new System.Drawing.Point(187, 67);
            this.customersBox.Name = "customersBox";
            this.customersBox.Size = new System.Drawing.Size(75, 17);
            this.customersBox.TabIndex = 5;
            this.customersBox.Text = "Customers";
            this.customersBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 248);
            this.Controls.Add(this.customersBox);
            this.Controls.Add(this.vehiclebox);
            this.Controls.Add(this.pageButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button pageButton;
        private System.Windows.Forms.CheckBox vehiclebox;
        private System.Windows.Forms.CheckBox customersBox;
    }
}

