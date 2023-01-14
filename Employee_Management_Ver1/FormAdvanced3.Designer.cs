namespace Employee_Management_Ver1
{
    partial class FormAdvanced3
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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.gvCustomer = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.trackCosts = new System.Windows.Forms.TrackBar();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label105 = new System.Windows.Forms.Label();
            this.txtAmountSold = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.gvCustomerBind = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerBind)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(547, 183);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(220, 23);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // gvCustomer
            // 
            this.gvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colEmail,
            this.colProduct,
            this.colPrice});
            this.gvCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvCustomer.Location = new System.Drawing.Point(26, 228);
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.RowTemplate.Height = 25;
            this.gvCustomer.Size = new System.Drawing.Size(741, 81);
            this.gvCustomer.TabIndex = 48;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 200;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(262, 83);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(22, 15);
            this.lblCommission.TabIndex = 47;
            this.lblCommission.Text = "0.0";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(646, 154);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 23);
            this.txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(547, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(415, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(296, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(172, 154);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 40);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // trackCosts
            // 
            this.trackCosts.LargeChange = 1;
            this.trackCosts.Location = new System.Drawing.Point(160, 103);
            this.trackCosts.Maximum = 100;
            this.trackCosts.Name = "trackCosts";
            this.trackCosts.Size = new System.Drawing.Size(223, 45);
            this.trackCosts.TabIndex = 5;
            this.trackCosts.ValueChanged += new System.EventHandler(this.trackCosts_ValueChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(160, 16);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(203, 23);
            this.cbProduct.TabIndex = 4;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label105.Location = new System.Drawing.Point(12, 101);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(131, 30);
            this.label105.TabIndex = 40;
            this.label105.Text = "Other Costs:";
            // 
            // txtAmountSold
            // 
            this.txtAmountSold.Location = new System.Drawing.Point(571, 110);
            this.txtAmountSold.Name = "txtAmountSold";
            this.txtAmountSold.Size = new System.Drawing.Size(170, 23);
            this.txtAmountSold.TabIndex = 3;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label106.Location = new System.Drawing.Point(415, 104);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(150, 30);
            this.label106.TabIndex = 39;
            this.label106.Text = " Amount Sold:";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label100.Location = new System.Drawing.Point(41, 11);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(89, 30);
            this.label100.TabIndex = 38;
            this.label100.Text = "Product";
            // 
            // txtBaseSalary
            // 
            this.txtBaseSalary.Location = new System.Drawing.Point(547, -36);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(220, 23);
            this.txtBaseSalary.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(415, -43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "Base Salary:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(490, -91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 23);
            this.txtEmail.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(415, -97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, -37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 23);
            this.txtName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, -43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(86, -91);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(277, 23);
            this.txtId.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, -97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label104.Location = new System.Drawing.Point(439, 74);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(114, 30);
            this.label104.TabIndex = 57;
            this.label104.Text = "Base Price:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(566, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label103.Location = new System.Drawing.Point(470, 44);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(69, 30);
            this.label103.TabIndex = 56;
            this.label103.Text = "Email:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 23);
            this.textBox3.TabIndex = 5;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label102.Location = new System.Drawing.Point(55, 44);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(75, 30);
            this.label102.TabIndex = 54;
            this.label102.Text = "Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(566, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 23);
            this.textBox4.TabIndex = 0;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label101.Location = new System.Drawing.Point(488, 16);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(39, 30);
            this.label101.TabIndex = 51;
            this.label101.Text = "ID:";
            // 
            // gvCustomerBind
            // 
            this.gvCustomerBind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomerBind.Location = new System.Drawing.Point(26, 326);
            this.gvCustomerBind.Name = "gvCustomerBind";
            this.gvCustomerBind.RowTemplate.Height = 25;
            this.gvCustomerBind.Size = new System.Drawing.Size(741, 157);
            this.gvCustomerBind.TabIndex = 58;
            // 
            // FormAdvanced3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.gvCustomerBind);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label104);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.gvCustomer);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.trackCosts);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.label105);
            this.Controls.Add(this.txtAmountSold);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.txtBaseSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "FormAdvanced3";
            this.Text = "FormAdvanced3";
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerBind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView gvCustomer;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TrackBar trackCosts;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.TextBox txtAmountSold;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox txtBaseSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridView gvCustomerBind;
    }
}