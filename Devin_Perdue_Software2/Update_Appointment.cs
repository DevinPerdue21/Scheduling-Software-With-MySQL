using Devin_Perdue_Software2.Database;
using Devin_Perdue_Software2.Model;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class Update_Appointment : Form
    {
        private DatabaseQueries databaseQueries;
        private CompanyHours companyHours;
        
        private bool allowSave()
        {
            int number;
            return (!string.IsNullOrEmpty(typeOfAppointment.Text)) && !Int32.TryParse(typeOfAppointment.Text, out number);
        }
        public Update_Appointment()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            databaseQueries = new DatabaseQueries(constr);
            companyHours = new CompanyHours();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy h:mm:ss tt";
       



            userID.Text = databaseQueries.GetUserID(Customers.CurrentUserName).ToString();
            appointmentID.Text = Customers.CurrentAppointmentID.ToString();

            List<string> customerNames = databaseQueries.CustomerNameComboBox();
            List<DateTime> appointmentTimes = databaseQueries.UpdateExistingAppointments(Customers.CurrentAppointmentID);

            customerNamesCombo.DataSource = customerNames;
            getDescription();
            getTime();
        }

        private void getDescription()
        {
            string description = databaseQueries.AppointmentDescription(Customers.CurrentAppointmentID);
            typeOfAppointment.Text = description;
        }

        private void getTime()
        {
            DateTime appointmentTime = databaseQueries.AppointmentTime(Customers.CurrentAppointmentID);
            dateTimePicker1.Value = appointmentTime.ToLocalTime();
        }

        private void cancelAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu f1 = new Main_Menu();
            f1.Show();
        }

        private void saveAppointment_Click(object sender, EventArgs e)
        {
            string name = customerNamesCombo.SelectedItem.ToString();
            string type = typeOfAppointment.Text;
            DateTime time1 = dateTimePicker1.Value;
            DateTime time = TimeZoneInfo.ConvertTimeToUtc(time1);
            TimeSpan appointment = time.TimeOfDay;

            try
            {
                List<DateTime> appointmentTimes = databaseQueries.UpdateExistingAppointments(Customers.CurrentAppointmentID);
                foreach (DateTime appointmentTime in appointmentTimes)
                {
                    if (companyHours.Overlap(appointmentTime, time))
                    {

                        MessageBox.Show("This appointment you are trying to schedule is within 30 minutes of an already scheduled appointment!");
                        return;
                    }
                }

                if (typeOfAppointment.Text.ToUpper() != "SCRUM" && typeOfAppointment.Text.ToUpper() != "PRESENTATION" && typeOfAppointment.Text.ToUpper() != "QUESTIONS")
                {
                    MessageBox.Show("Type of appointment can either be Scrum, Presentation, or Questions");
                    return;
                }

                if (companyHours.OutsideCompanyHours(appointment))
                {
                    MessageBox.Show("You have tried to schedule an appointment outside of our company hours. We are open 8am - 5pm UTC!");
                    return;
                }


                if (databaseQueries.UpdateAppointment(name, type, time))
                {
                    MessageBox.Show("Updated Appointment!");
                }

                else
                {
                    MessageBox.Show("Something Went Wrong");
                }


                this.Hide();
                Main_Menu f1 = new Main_Menu();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void typeOfAppointment_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(typeOfAppointment.Text) || Int32.TryParse(typeOfAppointment.Text, out number))
            {
                typeOfAppointment.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                typeOfAppointment.BackColor = System.Drawing.Color.White;
            }
            saveAppointment.Enabled = allowSave();
        }

       
    }
}
