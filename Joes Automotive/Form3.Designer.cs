namespace Joes_Automotive
{
    partial class showCustomersButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.customersSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.workButton = new System.Windows.Forms.Button();
            this.customersDataSet = new Joes_Automotive.customersDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Joes_Automotive.customersDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Joes_Automotive.customersDataSetTableAdapters.TableAdapterManager();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // customersSearch
            // 
            this.customersSearch.Location = new System.Drawing.Point(295, 30);
            this.customersSearch.Name = "customersSearch";
            this.customersSearch.Size = new System.Drawing.Size(142, 20);
            this.customersSearch.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(321, 56);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // workButton
            // 
            this.workButton.Location = new System.Drawing.Point(321, 334);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(75, 36);
            this.workButton.TabIndex = 3;
            this.workButton.Text = "Work Done";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "customersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customersDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Joes_Automotive.customersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(36, 116);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(244, 220);
            this.customersDataGridView.TabIndex = 5;
            this.customersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show all Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(127, 87);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(75, 23);
            this.saveButton1.TabIndex = 7;
            this.saveButton1.Text = "Save";
            this.saveButton1.UseVisualStyleBackColor = true;
            // 
            // showCustomersButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 382);
            this.Controls.Add(this.saveButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customersSearch);
            this.Controls.Add(this.label1);
            this.Name = "showCustomersButton";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customersSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button workButton;
        private customersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private customersDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private customersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton1;
    }
}