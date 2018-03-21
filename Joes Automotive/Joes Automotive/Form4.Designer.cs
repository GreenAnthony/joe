namespace Joes_Automotive
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.oilBox = new System.Windows.Forms.CheckBox();
            this.airBox = new System.Windows.Forms.CheckBox();
            this.brakesBox = new System.Windows.Forms.CheckBox();
            this.steeringBox = new System.Windows.Forms.CheckBox();
            this.heatingBox = new System.Windows.Forms.CheckBox();
            this.LubeBox = new System.Windows.Forms.CheckBox();
            this.batteryBox = new System.Windows.Forms.CheckBox();
            this.tiresBox = new System.Windows.Forms.CheckBox();
            this.fluidBox = new System.Windows.Forms.CheckBox();
            this.plugsBox = new System.Windows.Forms.CheckBox();
            this.invoicesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oilMoney = new System.Windows.Forms.Label();
            this.airMoney = new System.Windows.Forms.Label();
            this.brakeMoney = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.batteryMoney = new System.Windows.Forms.Label();
            this.tiresMoney = new System.Windows.Forms.Label();
            this.tansmissionMoney = new System.Windows.Forms.Label();
            this.sparkMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Done";
            // 
            // oilBox
            // 
            this.oilBox.AutoSize = true;
            this.oilBox.Location = new System.Drawing.Point(26, 82);
            this.oilBox.Name = "oilBox";
            this.oilBox.Size = new System.Drawing.Size(78, 17);
            this.oilBox.TabIndex = 1;
            this.oilBox.Text = "Oil Change";
            this.oilBox.UseVisualStyleBackColor = true;
            this.oilBox.CheckedChanged += new System.EventHandler(this.oilBox_CheckedChanged);
            // 
            // airBox
            // 
            this.airBox.AutoSize = true;
            this.airBox.Location = new System.Drawing.Point(26, 105);
            this.airBox.Name = "airBox";
            this.airBox.Size = new System.Drawing.Size(99, 17);
            this.airBox.TabIndex = 2;
            this.airBox.Text = "Air Conditioning";
            this.airBox.UseVisualStyleBackColor = true;
            this.airBox.CheckedChanged += new System.EventHandler(this.airBox_CheckedChanged);
            // 
            // brakesBox
            // 
            this.brakesBox.AutoSize = true;
            this.brakesBox.Location = new System.Drawing.Point(26, 128);
            this.brakesBox.Name = "brakesBox";
            this.brakesBox.Size = new System.Drawing.Size(59, 17);
            this.brakesBox.TabIndex = 3;
            this.brakesBox.Text = "Brakes";
            this.brakesBox.UseVisualStyleBackColor = true;
            // 
            // steeringBox
            // 
            this.steeringBox.AutoSize = true;
            this.steeringBox.Location = new System.Drawing.Point(26, 151);
            this.steeringBox.Name = "steeringBox";
            this.steeringBox.Size = new System.Drawing.Size(65, 17);
            this.steeringBox.TabIndex = 4;
            this.steeringBox.Text = "Steering";
            this.steeringBox.UseVisualStyleBackColor = true;
            // 
            // heatingBox
            // 
            this.heatingBox.AutoSize = true;
            this.heatingBox.Location = new System.Drawing.Point(26, 174);
            this.heatingBox.Name = "heatingBox";
            this.heatingBox.Size = new System.Drawing.Size(122, 17);
            this.heatingBox.TabIndex = 5;
            this.heatingBox.Text = "Heating and Cooling";
            this.heatingBox.UseVisualStyleBackColor = true;
            this.heatingBox.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // LubeBox
            // 
            this.LubeBox.AutoSize = true;
            this.LubeBox.Location = new System.Drawing.Point(26, 197);
            this.LubeBox.Name = "LubeBox";
            this.LubeBox.Size = new System.Drawing.Size(70, 17);
            this.LubeBox.TabIndex = 6;
            this.LubeBox.Text = "Lubricate";
            this.LubeBox.UseVisualStyleBackColor = true;
            // 
            // batteryBox
            // 
            this.batteryBox.AutoSize = true;
            this.batteryBox.Location = new System.Drawing.Point(26, 220);
            this.batteryBox.Name = "batteryBox";
            this.batteryBox.Size = new System.Drawing.Size(99, 17);
            this.batteryBox.TabIndex = 7;
            this.batteryBox.Text = "Battery Change";
            this.batteryBox.UseVisualStyleBackColor = true;
            // 
            // tiresBox
            // 
            this.tiresBox.AutoSize = true;
            this.tiresBox.Location = new System.Drawing.Point(26, 243);
            this.tiresBox.Name = "tiresBox";
            this.tiresBox.Size = new System.Drawing.Size(49, 17);
            this.tiresBox.TabIndex = 8;
            this.tiresBox.Text = "Tires";
            this.tiresBox.UseVisualStyleBackColor = true;
            // 
            // fluidBox
            // 
            this.fluidBox.AutoSize = true;
            this.fluidBox.Location = new System.Drawing.Point(26, 266);
            this.fluidBox.Name = "fluidBox";
            this.fluidBox.Size = new System.Drawing.Size(112, 17);
            this.fluidBox.TabIndex = 9;
            this.fluidBox.Text = "Transmission Fluid";
            this.fluidBox.UseVisualStyleBackColor = true;
            // 
            // plugsBox
            // 
            this.plugsBox.AutoSize = true;
            this.plugsBox.Location = new System.Drawing.Point(26, 289);
            this.plugsBox.Name = "plugsBox";
            this.plugsBox.Size = new System.Drawing.Size(83, 17);
            this.plugsBox.TabIndex = 10;
            this.plugsBox.Text = "Spark Plugs";
            this.plugsBox.UseVisualStyleBackColor = true;
            // 
            // invoicesButton
            // 
            this.invoicesButton.Location = new System.Drawing.Point(224, 370);
            this.invoicesButton.Name = "invoicesButton";
            this.invoicesButton.Size = new System.Drawing.Size(75, 38);
            this.invoicesButton.TabIndex = 11;
            this.invoicesButton.Text = "Invoices";
            this.invoicesButton.UseVisualStyleBackColor = true;
            this.invoicesButton.Click += new System.EventHandler(this.invoicesButton_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(154, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(102, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 14;
            // 
            // oilMoney
            // 
            this.oilMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oilMoney.Location = new System.Drawing.Point(103, 83);
            this.oilMoney.Name = "oilMoney";
            this.oilMoney.Size = new System.Drawing.Size(37, 15);
            this.oilMoney.TabIndex = 15;
            // 
            // airMoney
            // 
            this.airMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.airMoney.Location = new System.Drawing.Point(131, 106);
            this.airMoney.Name = "airMoney";
            this.airMoney.Size = new System.Drawing.Size(37, 15);
            this.airMoney.TabIndex = 16;
            // 
            // brakeMoney
            // 
            this.brakeMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.brakeMoney.Location = new System.Drawing.Point(90, 129);
            this.brakeMoney.Name = "brakeMoney";
            this.brakeMoney.Size = new System.Drawing.Size(37, 15);
            this.brakeMoney.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(97, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 18;
            // 
            // batteryMoney
            // 
            this.batteryMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.batteryMoney.Location = new System.Drawing.Point(131, 221);
            this.batteryMoney.Name = "batteryMoney";
            this.batteryMoney.Size = new System.Drawing.Size(37, 15);
            this.batteryMoney.TabIndex = 19;
            // 
            // tiresMoney
            // 
            this.tiresMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tiresMoney.Location = new System.Drawing.Point(74, 247);
            this.tiresMoney.Name = "tiresMoney";
            this.tiresMoney.Size = new System.Drawing.Size(37, 15);
            this.tiresMoney.TabIndex = 20;
            // 
            // tansmissionMoney
            // 
            this.tansmissionMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tansmissionMoney.Location = new System.Drawing.Point(144, 268);
            this.tansmissionMoney.Name = "tansmissionMoney";
            this.tansmissionMoney.Size = new System.Drawing.Size(37, 15);
            this.tansmissionMoney.TabIndex = 21;
            // 
            // sparkMoney
            // 
            this.sparkMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sparkMoney.Location = new System.Drawing.Point(115, 290);
            this.sparkMoney.Name = "sparkMoney";
            this.sparkMoney.Size = new System.Drawing.Size(37, 15);
            this.sparkMoney.TabIndex = 22;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 437);
            this.Controls.Add(this.sparkMoney);
            this.Controls.Add(this.tansmissionMoney);
            this.Controls.Add(this.tiresMoney);
            this.Controls.Add(this.batteryMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.brakeMoney);
            this.Controls.Add(this.airMoney);
            this.Controls.Add(this.oilMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invoicesButton);
            this.Controls.Add(this.plugsBox);
            this.Controls.Add(this.fluidBox);
            this.Controls.Add(this.tiresBox);
            this.Controls.Add(this.batteryBox);
            this.Controls.Add(this.LubeBox);
            this.Controls.Add(this.heatingBox);
            this.Controls.Add(this.steeringBox);
            this.Controls.Add(this.brakesBox);
            this.Controls.Add(this.airBox);
            this.Controls.Add(this.oilBox);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox oilBox;
        private System.Windows.Forms.CheckBox airBox;
        private System.Windows.Forms.CheckBox brakesBox;
        private System.Windows.Forms.CheckBox steeringBox;
        private System.Windows.Forms.CheckBox heatingBox;
        private System.Windows.Forms.CheckBox LubeBox;
        private System.Windows.Forms.CheckBox batteryBox;
        private System.Windows.Forms.CheckBox tiresBox;
        private System.Windows.Forms.CheckBox fluidBox;
        private System.Windows.Forms.CheckBox plugsBox;
        private System.Windows.Forms.Button invoicesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label oilMoney;
        private System.Windows.Forms.Label airMoney;
        private System.Windows.Forms.Label brakeMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label batteryMoney;
        private System.Windows.Forms.Label tiresMoney;
        private System.Windows.Forms.Label tansmissionMoney;
        private System.Windows.Forms.Label sparkMoney;
    }
}