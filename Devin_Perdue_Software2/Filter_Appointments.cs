using Devin_Perdue_Software2.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devin_Perdue_Software2
{
    public partial class Filter_Appointments : Form
    {
        private DatabaseQueries databaseQueries;
        internal static MySqlConnection conn { get; set; }
        DateTime currentDate;
       // DataTable d1 = new DataTable();
        public Filter_Appointments()
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            calendar.AddBoldedDate(currentDate);
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            databaseQueries = new DatabaseQueries(constr);

            filteredAppointmentsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            filteredAppointmentsDGV.ReadOnly = true;
            filteredAppointmentsDGV.MultiSelect = false;
            filteredAppointmentsDGV.AllowUserToAddRows = false;


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu f3 = new Main_Menu();
            f3.Show();
        }

        private void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            handleDay();
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            handleWeek ();
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            handleMonth();
        }

        private void handleMonth()
        {
            calendar.RemoveAllBoldedDates();
            int month = currentDate.Month;
            int year = currentDate.Year;
            int day = 0;
            string startDate = year.ToString() + "-" + month.ToString() + "-" + "01" + " 00:00:00";
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    day = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                default:
                    day = 29;
                    break;
                
            }
            for (int i = 0; i < day; i++)
            {
                calendar.AddBoldedDate(currentDate.AddDays(i));    
            }
            calendar.UpdateBoldedDates();
            string endDate = year.ToString() + "-"+ month.ToString() + "-" + day.ToString() + " 23:59:59";
            DataTable d1 = databaseQueries.GetMonthAppointments(startDate, endDate);
            d1.DefaultView.Sort = "start ASC";
            filteredAppointmentsDGV.AutoGenerateColumns = false;

            DataTable d2 = d1.Clone();
            foreach (DataRow row in d1.Rows)
            {
                d2.ImportRow(row);
            }

            for (int idx = 0; idx < d2.Rows.Count; idx++)
            {
                d2.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)d2.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
            }

            filteredAppointmentsDGV.DataSource = d2.DefaultView.ToTable();


        }

        private void handleWeek()
        {
            calendar.RemoveAllBoldedDates();
            int dayOfWeek = (int)currentDate.DayOfWeek;
            string startDate = currentDate.AddDays(-dayOfWeek).ToString("yyyy-MM-dd");
            DateTime tempDate = Convert.ToDateTime(startDate);
            for (int i = 0;i < 7; i++)
            {
                calendar.AddBoldedDate(tempDate.AddDays(i));
            }
            calendar.UpdateBoldedDates();
            string endDate = currentDate.AddDays(7 - dayOfWeek).ToString("yyyy-MM-dd");
            DataTable d1 = databaseQueries.GetWeekAppointments(startDate, endDate);

            d1.DefaultView.Sort = "start ASC";
            filteredAppointmentsDGV.AutoGenerateColumns = false;

            DataTable d2 = d1.Clone();
            foreach (DataRow row in d1.Rows)
            {
                d2.ImportRow(row);
            }

            for (int idx = 0; idx < d2.Rows.Count; idx++)
            {
                d2.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)d2.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
            }

            filteredAppointmentsDGV.DataSource = d2.DefaultView.ToTable();

        }

        private void handleDay()
        {
            calendar.RemoveAllBoldedDates();
            calendar.AddBoldedDate(currentDate);
            calendar.UpdateBoldedDates();

            string startDate = currentDate.ToString("yyyy-MM-dd") + " 00:00:00";
            string endDate = currentDate.ToString("yyyy-MM-dd") + " 23:59:59";
            DataTable d1 = databaseQueries.GetDayAppointments(startDate, endDate);

            d1.DefaultView.Sort = "start ASC";
            filteredAppointmentsDGV.AutoGenerateColumns = false;

            DataTable d2 = d1.Clone(); 
            foreach (DataRow row in d1.Rows)
            {
                d2.ImportRow(row);
            }
            
            for (int idx = 0; idx < d2.Rows.Count; idx++)
            {
                d2.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)d2.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
            }

            filteredAppointmentsDGV.DataSource = d2.DefaultView.ToTable();




        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            currentDate = e.Start;
            if (rbMonth.Checked)
            {
                handleMonth();
            }
            else
            {
                if (rbWeek.Checked)
                {
                    handleWeek();
                }
                else
                {
                    handleDay();
                }
            }
        }
    }
}
