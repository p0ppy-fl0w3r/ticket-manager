using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    // TODO add doc comment to all the functions below.
    static class Utils
    {

        public static string currentForm = "login";

        public static void navigate(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size;


            foreach (Control control in panel.Controls)
            {
                /* Controls.clear() will not dispose the visual elements, causing the application-
                 * to keep the 'previous' forms even when the screen displays a different form.
                 */
                control.Dispose();
            }
            panel.Controls.Clear(); // TODO check if this is redundant

            // Garbage collect to free up memory.
            GC.Collect();

            panel.Controls.Add(form);

            form.Show();
        }

        public static void validateDigitPressed(object sender, KeyEventArgs e, bool allowDecimal)
        {
            int[] exceptionKeyValues = { 8, 37, 39, 46, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105 };
            int[] decimalKeyValues = { 8, 37, 39, 46, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 110, 190 };


            if (Char.IsDigit((char)e.KeyValue) || (allowDecimal ? decimalKeyValues : exceptionKeyValues).Contains(e.KeyValue))
            {
                ((TextBox)sender).ReadOnly = false;
            }
            else
            {
                ((TextBox)sender).ReadOnly = true;
            }
        }

    }
}
