using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Example : Form
    {
        public Example()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Example control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Example_Load(object sender, EventArgs e)
        {
            dgv.Bounds = new Rectangle(10, 10, 445, 420);
            dgv.AllowUserToAddRows = false;

            var dt = new DataTable();
            dt.Columns.Add("Number", typeof(int));
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Ver");
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Rows.Add("1", "Behzad", "Khosravifar", "13.10.2011");
            dt.Rows.Add("2", "Behzad kh", "Khosravi", "18.10.2012");
            dt.Rows.Add("3", "Behzad", "Khosravifar", "13.10.2011");
            dt.Rows.Add("4", "Behzad", "Khosravifar", "13.10.2011");
            dt.Rows.Add("5", "Behzad", "Khosravifar", "13.10.2011");
            dt.Rows.Add("6", "Behzad", "Khosravifar", "13.10.2014");
            dt.Rows.Add("7", "Behzad", "Khosravifar", "13.10.2013");
            dt.Rows.Add("8", "Behzad", "Khosravifar", "13.10.2011");
            dt.Rows.Add("9", "Behzad", "Khosravifar", "13.10.2011");
            dt.Rows.Add("10", "Behzad", "Khosravifar", "13.10.2011");
            dt.Rows.Add("11", "Behzad kh", "Khosravi", "18.10.2012");

            dgv.DataSource = dt;
        }
    }
}
