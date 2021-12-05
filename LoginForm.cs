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
            // TODO add validation here.
            // TODO add a permanent solution.
            if (usernameTextBox.Text == "admin")
            {
                Utils.currentForm = Constants.ADMIN_FORM;
            }
            else {
                Utils.currentForm = Constants.TICKET_FORM;
            }
            

        }
    }
}
