namespace EncryptionPractice
{
    partial class Register
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
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.txtUserReg = new System.Windows.Forms.TextBox();
            this.btnRegisterReg = new System.Windows.Forms.Button();
            this.lblPassReg = new System.Windows.Forms.Label();
            this.lblUserReg = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassReg
            // 
            this.txtPassReg.Location = new System.Drawing.Point(187, 202);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.Size = new System.Drawing.Size(175, 20);
            this.txtPassReg.TabIndex = 4;
            this.txtPassReg.UseSystemPasswordChar = true;
            // 
            // txtUserReg
            // 
            this.txtUserReg.Location = new System.Drawing.Point(187, 176);
            this.txtUserReg.Name = "txtUserReg";
            this.txtUserReg.Size = new System.Drawing.Size(175, 20);
            this.txtUserReg.TabIndex = 3;
            // 
            // btnRegisterReg
            // 
            this.btnRegisterReg.AutoSize = true;
            this.btnRegisterReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterReg.Location = new System.Drawing.Point(187, 228);
            this.btnRegisterReg.Name = "btnRegisterReg";
            this.btnRegisterReg.Size = new System.Drawing.Size(75, 27);
            this.btnRegisterReg.TabIndex = 7;
            this.btnRegisterReg.Text = "Register";
            this.btnRegisterReg.UseVisualStyleBackColor = true;
            this.btnRegisterReg.Click += new System.EventHandler(this.btnRegisterReg_Click);
            // 
            // lblPassReg
            // 
            this.lblPassReg.AutoSize = true;
            this.lblPassReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassReg.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPassReg.Location = new System.Drawing.Point(110, 202);
            this.lblPassReg.Name = "lblPassReg";
            this.lblPassReg.Size = new System.Drawing.Size(70, 17);
            this.lblPassReg.TabIndex = 9;
            this.lblPassReg.Text = "Password:";
            // 
            // lblUserReg
            // 
            this.lblUserReg.AutoSize = true;
            this.lblUserReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserReg.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUserReg.Location = new System.Drawing.Point(108, 176);
            this.lblUserReg.Name = "lblUserReg";
            this.lblUserReg.Size = new System.Drawing.Size(73, 17);
            this.lblUserReg.TabIndex = 8;
            this.lblUserReg.Text = "Username:";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.SystemColors.Window;
            this.lblReg.Location = new System.Drawing.Point(183, 152);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(117, 21);
            this.lblReg.TabIndex = 10;
            this.lblReg.Text = "Register Here!";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblPassReg);
            this.Controls.Add(this.lblUserReg);
            this.Controls.Add(this.btnRegisterReg);
            this.Controls.Add(this.txtPassReg);
            this.Controls.Add(this.txtUserReg);
            this.Name = "Register";
            this.Text = "Register: Next For Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassReg;
        private System.Windows.Forms.TextBox txtUserReg;
        private System.Windows.Forms.Button btnRegisterReg;
        private System.Windows.Forms.Label lblPassReg;
        private System.Windows.Forms.Label lblUserReg;
        private System.Windows.Forms.Label lblReg;
    }
}