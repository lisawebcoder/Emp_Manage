
namespace Employee_Management_Ver1
{
    partial class Login
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.Label();
            this.btnCreateCred = new System.Windows.Forms.Button();
            this.isEmployee = new System.Windows.Forms.RadioButton();
            this.isManager = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(117, 43);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(117, 173);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(221, 33);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtError
            // 
            this.txtError.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtError.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtError.Location = new System.Drawing.Point(40, 109);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(355, 21);
            this.txtError.TabIndex = 5;
            this.txtError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateCred
            // 
            this.btnCreateCred.BackColor = System.Drawing.Color.Orange;
            this.btnCreateCred.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateCred.Location = new System.Drawing.Point(117, 218);
            this.btnCreateCred.Name = "btnCreateCred";
            this.btnCreateCred.Size = new System.Drawing.Size(221, 33);
            this.btnCreateCred.TabIndex = 6;
            this.btnCreateCred.Text = "CREATE CREDENTIAL";
            this.btnCreateCred.UseVisualStyleBackColor = false;
            this.btnCreateCred.Click += new System.EventHandler(this.btnCreateCred_Click);
            // 
            // isEmployee
            // 
            this.isEmployee.AutoSize = true;
            this.isEmployee.Location = new System.Drawing.Point(134, 148);
            this.isEmployee.Name = "isEmployee";
            this.isEmployee.Size = new System.Drawing.Size(77, 19);
            this.isEmployee.TabIndex = 7;
            this.isEmployee.TabStop = true;
            this.isEmployee.Text = "Employee";
            this.isEmployee.UseVisualStyleBackColor = true;
            // 
            // isManager
            // 
            this.isManager.AutoSize = true;
            this.isManager.Location = new System.Drawing.Point(234, 148);
            this.isManager.Name = "isManager";
            this.isManager.Size = new System.Drawing.Size(72, 19);
            this.isManager.TabIndex = 8;
            this.isManager.TabStop = true;
            this.isManager.Text = "Manager";
            this.isManager.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(117, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "go to advanced";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isManager);
            this.Controls.Add(this.isEmployee);
            this.Controls.Add(this.btnCreateCred);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Button btnCreateCred;
        private System.Windows.Forms.RadioButton isEmployee;
        private System.Windows.Forms.RadioButton isManager;
        private System.Windows.Forms.Button button1;
    }
}