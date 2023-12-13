using Devin_Perdue_Software2.Database;
using Devin_Perdue_Software2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devin_Perdue_Software2
{
    public partial class Generate_Reports : Form
    {
        private DatabaseQueries databaseQueries;
        public Generate_Reports()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            databaseQueries = new DatabaseQueries(constr);

            reportDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportDGV.ReadOnly = true;
            reportDGV.MultiSelect = false;
            reportDGV.AllowUserToAddRows = false;
        }

        private void apptByMonth_CheckedChanged(object sender, EventArgs e)
        {
            apptsMonth();
        }

        private void scheduleForUser_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Generate_Schedule f1 = new Generate_Schedule();
            f1.Show();
           
        }

        private void numberOfAppointments_CheckedChanged(object sender, EventArgs e)
        {
            totalAppts();
        }

        private void apptsMonth()
        {
            DataTable d1 = databaseQueries.AppointmentsByMonth();
            reportDGV.DataSource = d1;

            for (int idx = 0; idx < d1.Rows.Count; idx++)
            {
                d1.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)d1.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
            }

            reportTxt.ScrollBars = ScrollBars.Vertical;

            reportTxt.Text = "Report: Number of each meeting types by month\r\n\r\n";
            string[] Months = new string[] { "November", "December", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October" };

            foreach (string month in Months)
            {
                reportTxt.Text = reportTxt.Text + month + "\r\n";
                int numScrum = 0;
                int numPresentation = 0;
                int numQuestions = 0;

                foreach(DataRow row in d1.Rows)
                {
                    DateTime start = (DateTime)row["Start"];
                    if (month == start.ToString("MMMM", CultureInfo.InvariantCulture))
                    {
                        if (row["Type"].ToString().ToUpper() == "SCRUM")
                        {
                            numScrum++;
                        }
                        if (row["Type"].ToString().ToUpper() == "PRESENTATION")
                        {
                            numPresentation++;
                        }
                        if (row["Type"].ToString().ToUpper() == "QUESTIONS")
                        {
                            numQuestions++;
                        }
                    }
                }
                reportTxt.Text = reportTxt.Text +
                    "\tScrum\t\t" + numScrum + "\r\n" +
                    "\tPresentation\t" + numPresentation + "\r\n" +
                    "\tQuestions\t\t" + numQuestions + "\r\n";
                //reportTxt.Select(0, 0);
            }
        }

       

        private void totalAppts()
        {
            DataTable d1 = databaseQueries.TotalAppointments();
            reportDGV.DataSource = d1;

            for (int idx = 0; idx < d1.Rows.Count; idx++)
            {
                d1.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)d1.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
            }

            reportTxt.Text = "Report: Total number of scrum appointments scheduled\r\n\r\n";

            int total = 0;
            foreach (DataRow row in  d1.Rows)
            {

                if ("SCRUM" == row["Type"].ToString().ToUpper()) 
                {
                    total++;
                }
                
            }
            reportTxt.Text = reportTxt.Text +  "Total Scrum Appointments: " + total;
        }

        private void Generate_Reports_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu f3 = new Main_Menu();
            f3.Show();
        }
    }
}
