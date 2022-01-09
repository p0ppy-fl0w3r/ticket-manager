using Coursework.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Coursework
{
    static class Utils
    {

        public static string currentForm = Constants.LOGIN_FORM;
        
        public static List<Visitor> visitorsList = new List<Visitor>();


        /// <summary>
        /// Clears the panel and adds the form to it.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="panel"></param>
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
            panel.Controls.Clear();

            // Garbage collect to free up memory.
            GC.Collect();

            panel.Controls.Add(form);

            form.Show();
        }

        /// <summary>
        /// Checks the key-down event to see if the user pressed a digit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="allowDecimal"></param>
        public static void validateDigitPressed(object sender, KeyEventArgs e, bool allowDecimal)
        {
            int[] exceptionKeyValues = { 8, 37, 39, 46, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105 };
            int[] numericDecimals = { 110, 190 };

            var decimalKeyValues = exceptionKeyValues.Union(numericDecimals);

            if (char.IsDigit((char)e.KeyValue) || (allowDecimal ? decimalKeyValues : exceptionKeyValues).Contains(e.KeyValue))
            {
                ((TextBox)sender).ReadOnly = false;

                if (allowDecimal && ((TextBox)sender).Text.Contains(".") && numericDecimals.Contains(e.KeyValue))
                {
                    ((TextBox)sender).ReadOnly = true;
                }

            }
            else
            {
                ((TextBox)sender).ReadOnly = true;
            }
        }

        /// <summary>
        ///  Increments and saves the ticketId and groupId in a file. Pass a 'false'
        ///  if you do not wish to override the previous IDs.
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="groupId"></param>
        public static void setLastId(bool setTicketId, bool setGroupId)
        {
            Identifiers currentIdentidier = getLastId();
            if (setTicketId)
            {
                currentIdentidier.ticketId = currentIdentidier.ticketId + 1;
            }
            if (setGroupId)
            {
                currentIdentidier.groupId = currentIdentidier.groupId + 1;
            }

            writeToFile(currentIdentidier.toJson(), Constants.ID_FILE);

        }

        /// <summary>
        /// Gets the last Identifiers
        /// </summary>
        /// <returns></returns>
        public static Identifiers getLastId()
        {

            List<Identifiers> identifiers = getFromFile<Identifiers>(Constants.ID_FILE);
            if (identifiers.Count > 0)
            {
                return identifiers[0];
            }

            Identifiers mIdentifier = new Identifiers();
            mIdentifier.ticketId = 100;
            mIdentifier.groupId = 0;
            return mIdentifier;
        }

        /// <summary>
        /// Replaces the contents of a file with "data".
        /// </summary>
        /// <param name="data"></param>
        /// <param name="fileName"></param>
        public static void writeToFile(string data, string fileName)
        {

            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }

            File.WriteAllText(fileName, data);

        }

        /// <summary>
        /// Gets data from a file in a list of <T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<T> getFromFile<T>(string fileName)
        {

            if (File.Exists(fileName))
            {
                using (StreamReader inputFile = File.OpenText(fileName))
                {
                    List<T> objectList = new List<T>();

                    string jsonLine = inputFile.ReadLine();

                    while (jsonLine != null)
                    {
                        T mObject = JsonConvert.DeserializeObject<T>(jsonLine);
                        objectList.Add(mObject);
                        jsonLine = inputFile.ReadLine();
                    }
                    return objectList;
                }
            }

            return new List<T>();
        }

        /// <summary>
        /// Appends the data on the specified file. 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public static void appendOnFile(string data, string filename)
        {

            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }

            File.AppendAllText(filename, data + "\n");

        }

        /// <summary>
        /// Animates the supplied Control with an error animation.
        /// <para>The program will throw an InvalidOperationException if the borders of textBoxes are 3D.
        /// Make sure that the borders are 'FixedSingle' before calling this method.</para>
        /// </summary>
        /// <param name="tBase"></param>
        public static void animateTextBase(Control tBase)
        {
            Thread animationThread = new Thread(() =>
            {
                Color initialBackColor = tBase.BackColor;

                tBase.BackColor = Color.Red;
                Thread.Sleep(500);
                tBase.BackColor = initialBackColor;
            });

            animationThread.Start();
        }

        /// <summary>
        /// Returns true if the provided DateTime is a weekend.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static bool isWeekend(DateTime dateTime) {
            return dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday;
        }

        /// <summary>
        /// Formats the decimal number less than 10 to have a preceding '0'
        /// and only one digit after decimal.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string properDoubleString(double number){
            return string.Format("{0:00.0}", number);
        }

    }
}
