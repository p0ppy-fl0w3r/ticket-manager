using System;
using System.Threading;
using System.Windows.Forms;

namespace Coursework
{
    // TODO use masked text box while validating fields in ticket system
    public partial class MainForm : Form
    {
        public string current = Constants.LOGIN_FORM;
        public MainForm()
        {
            InitializeComponent();

            Utils.navigate(new LoginForm(), mainPanel);

            Thread observerThread = new Thread(new ThreadStart(observer));

            // Setting observerThread as background will make sure that this thread is aborted when the application closes.
            observerThread.IsBackground = true;

            observerThread.Start();
        }

        public void observer()
        {

            while (true)
            {
                if (current != Utils.currentForm)
                {
                    current = Utils.currentForm;
                    switch (Utils.currentForm)
                    {
                        case Constants.LOGIN_FORM:
                            // Make sure that the actual navigation happens in the main thread.
                            // Updating properties in other thread(such as the observerThread) will not show any changes and-
                            // throw exception.
                            Invoke(new Action(() =>
                            {
                                Utils.navigate(new LoginForm(), mainPanel);
                            }));
                            break;

                        case Constants.ADMIN_FORM:
                            Invoke(new Action(() =>
                            {
                                Utils.navigate(new AdminPanelForm(), mainPanel);
                            }));
                            break;

                        case Constants.TICKET_FORM:
                            Invoke(new Action(() =>
                            {
                                Utils.navigate(new TicketForm(), mainPanel);
                            }));
                            break;

                        case Constants.REPORT_FORM:
                            Invoke(new Action(() =>
                            {
                                Utils.navigate(new ReportForm(), mainPanel);
                            }));
                            break;

                        default:
                            Invoke(new Action(() =>
                            {
                                // If you get any values other than the ones specified in Constants, navigate the user to the login form.
                                Utils.navigate(new LoginForm(), mainPanel);
                            }));
                            break;
                    }


                }
                else
                {
                    Thread.Sleep(10);
                }
            }
        }
    }
}