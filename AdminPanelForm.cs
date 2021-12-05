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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.currentForm = Constants.LOGIN_FORM;
        }

        private void hourTextPressed(object sender, KeyEventArgs e)
        {
            Utils.validateDigitPressed(sender, e, true);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Utils.currentForm = Constants.REPORT_FORM;
        }
    }
}
