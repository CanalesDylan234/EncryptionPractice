namespace EncryptionPractice
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
            this.txtUserLog = new System.Windows.Forms.TextBox();
            this.txtPassLog = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLoginLog = new System.Windows.Forms.Button();
            this.btnRegisterLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserLog
            // 
            this.txtUserLog.Location = new System.Drawing.Point(167, 188);
            this.txtUserLog.Name = "txtUserLog";
            this.txtUserLog.Size = new System.Drawing.Size(175, 20);
            this.txtUserLog.TabIndex = 1;
            // 
            // txtPassLog
            // 
            this.txtPassLog.Location = new System.Drawing.Point(167, 214);
            this.txtPassLog.Name = "txtPassLog";
            this.txtPassLog.Size = new System.Drawing.Size(175, 20);
            this.txtPassLog.TabIndex = 2;
            this.txtPassLog.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUser.Location = new System.Drawing.Point(88, 188);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 17);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPass.Location = new System.Drawing.Point(90, 214);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 17);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password:";
            // 
            // btnLoginLog
            // 
            this.btnLoginLog.AutoSize = true;
            this.btnLoginLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLog.Location = new System.Drawing.Point(167, 240);
            this.btnLoginLog.Name = "btnLoginLog";
            this.btnLoginLog.Size = new System.Drawing.Size(75, 27);
            this.btnLoginLog.TabIndex = 5;
            this.btnLoginLog.Text = "Login";
            this.btnLoginLog.UseVisualStyleBackColor = true;
            this.btnLoginLog.Click += new System.EventHandler(this.btnLoginLog_Click);
            // 
            // btnRegisterLog
            // 
            this.btnRegisterLog.AutoSize = true;
            this.btnRegisterLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterLog.Location = new System.Drawing.Point(267, 240);
            this.btnRegisterLog.Name = "btnRegisterLog";
            this.btnRegisterLog.Size = new System.Drawing.Size(75, 27);
            this.btnRegisterLog.TabIndex = 6;
            this.btnRegisterLog.Text = "Register";
            this.btnRegisterLog.UseVisualStyleBackColor = true;
            this.btnRegisterLog.Click += new System.EventHandler(this.btnRegisterLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::EncryptionPractice.Properties.Resources.EBSLogo;
            this.pictureBox1.Location = new System.Drawing.Point(167, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btnRegisterLog);
            this.Controls.Add(this.btnLoginLog);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPassLog);
            this.Controls.Add(this.txtUserLog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login: Next For Windows";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserLog;
        private System.Windows.Forms.TextBox txtPassLog;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnLoginLog;
        private System.Windows.Forms.Button btnRegisterLog;
    }
}

