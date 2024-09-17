using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionPractice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginLog_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtUserLog.Text) || !String.IsNullOrEmpty(txtPassLog.Text))
            {
                Models.UsersDataEN _userData = new Models.UsersDataEN();
                _userData.username = txtUserLog.Text;
                _userData.password = txtPassLog.Text;

                using(PracticeEncryptionEntities db = new PracticeEncryptionEntities())
                {
                    var _getUser = db.UserInfoes.FirstOrDefault(d =>  d.Username == _userData.username);
                    
                    if (_getUser != null)
                    {
                        if(Models.Encryption.VerifyHash(_userData.password, _getUser.Password))
                        {
                            MessageBox.Show($"Login Successful! Welcome: {_getUser.Username}");
                        }
                        else
                        {
                            MessageBox.Show("Login Unsuccessful! Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Not FOUND!", "ERROR LOCATING USER!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Verify and Ensure Usernname/Password is typed in before logging in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisterLog_Click(object sender, EventArgs e)
        {
            Register _reg = new Register();
            _reg.Show();
        }
    }
}
