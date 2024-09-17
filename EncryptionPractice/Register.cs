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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegisterReg_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserReg.Text) && !String.IsNullOrEmpty(txtPassReg.Text))
            {
                using (PracticeEncryption db = new PracticeEncryption())
                {
                    try
                    {
                        //
                        string salt = Models.Encryption.GenerateSalt();

                        //
                        string hashedPassword = Models.Encryption.HashPasswordSalt(txtPassReg.Text, salt);

                        //
                        UserTest _user = new UserTest();

                        // Store Username, hashed password, and salt 
                        _user.Username = txtUserReg.Text;
                        _user.Password = hashedPassword;
                        _user.Salt = salt;
                        _user.Date = DateTime.Now;

                        //
                        db.UserTests.Add(_user);
                        db.SaveChanges();

                        MessageBox.Show($"Register Successful! Please Login: {txtUserReg.Text}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Verify and Ensure Usernname/Password is typed in before logging in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
