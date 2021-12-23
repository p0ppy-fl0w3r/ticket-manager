using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            logUserIn();
        }

        private void logUserIn() {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                Utils.currentForm = Constants.ADMIN_FORM;
            }
            else if (usernameTextBox.Text == "user" && passwordTextBox.Text == "user")
            {
                Utils.currentForm = Constants.TICKET_FORM;
            }
            else
            {
                MessageBox.Show("Username or Password incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void passswordKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logUserIn();
            }
        }
    }
}
