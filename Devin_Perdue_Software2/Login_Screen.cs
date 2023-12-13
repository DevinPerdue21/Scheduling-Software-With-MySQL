using Devin_Perdue_Software2.Database;
using Devin_Perdue_Software2.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devin_Perdue_Software2
{
    public partial class Login_Screen : Form
    {
        internal static MySqlConnection conn { get; set; }
        private DatabaseQueries databaseQueries;
        private CompanyHours companyHours;
        public DateTime currentTime;
        string fileName = "login.txt";

      

        public void SwitchLanguage(string s)
        {
            switch(s)
            {
                case "en":
                    loginTxt.Text = "Login:"; usernameTxt.Text = "Username:"; passwordTxt.Text = "Password:"; break;
                case "de":
                    loginTxt.Text = "Anmeldung:"; usernameTxt.Text = "Nutzername:"; passwordTxt.Text = "Passwort:"; loginButton.Text = "Anmeldung";  break;
            }
        }

        public Login_Screen()
        {
            InitializeComponent();

            

            DateTime currentTime1 = DateTime.Now;
            currentTime = TimeZoneInfo.ConvertTimeToUtc(currentTime1);


            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            databaseQueries = new DatabaseQueries(constr);
            companyHours = new CompanyHours();


            conn = new MySqlConnection(constr);
            conn.Open();

            string languageCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            SwitchLanguage(languageCode);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            Customers.CurrentUserName = userNameTextBox.Text;
            try
            {

                if (userNameTextBox.Text != string.Empty || passwordTextBox.Text != string.Empty)
                {
                    string login = "SELECT * FROM user WHERE userName ='" + userNameTextBox.Text + "'AND password='" + passwordTextBox.Text + "'";


                    using (MySqlCommand cmd = new MySqlCommand(login, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reader.Close();
                                using (FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                                {
                                    using (StreamWriter fileWriter = new StreamWriter(file))
                                    {
                                        fileWriter.WriteLine(userNameTextBox.Text + " has logged in at " + currentTime);
                                    }
                                }
                                if (language == "en")
                                {
                                    MessageBox.Show("Login successful!");

                                    int userID = databaseQueries.GetUserID(Customers.CurrentUserName);

                                    List<DateTime> appointmentTimes = databaseQueries.UserAppointemnts(userID);
                                    foreach (DateTime appointmentTime in appointmentTimes)
                                    {

                                        if (companyHours.UpcomingAppointemnt(appointmentTime, currentTime))
                                        {
                                            MessageBox.Show("You have an upcoming appointment within 15 minutes!");


                                        }

                                    }

                                    this.Hide();
                                    Main_Menu main = new Main_Menu();
                                    main.Show();

                                }
                                else
                                {
                                    MessageBox.Show("Anmeldung erfolgreich!");

                                    int userID = databaseQueries.GetUserID(Customers.CurrentUserName);

                                    List<DateTime> appointmentTimes = databaseQueries.UserAppointemnts(userID);
                                    foreach (DateTime appointmentTime in appointmentTimes)
                                    {

                                        if (companyHours.UpcomingAppointemnt(appointmentTime, currentTime))
                                        {
                                            MessageBox.Show("Sie haben innerhalb von 15 Minuten einen bevorstehenden Termin!");


                                        }

                                    }
                                    this.Hide();
                                    Main_Menu main = new Main_Menu();
                                    main.Show();
                                }
                            }
                            else
                            {
                                reader.Close();
                                using (FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                                {
                                    using (StreamWriter fileWriter = new StreamWriter(file))
                                    {
                                        fileWriter.WriteLine("Failed login attempt with " + userNameTextBox.Text + " at " + currentTime);
                                    }
                                }
                                if (language == "en")
                                {
                                    MessageBox.Show("Nothing Found!");
                                }
                                else
                                {
                                    MessageBox.Show("Nichts Gefunden!");
                                }

                            }
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
