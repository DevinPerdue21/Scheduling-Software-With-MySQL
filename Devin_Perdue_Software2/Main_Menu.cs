using Devin_Perdue_Software2.Database;
using Devin_Perdue_Software2.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto.Encodings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devin_Perdue_Software2
{
    public partial class Main_Menu : Form
    {
        private DatabaseQueries databaseQueries;

        internal static MySqlConnection conn { get; set; }
        private static int idxSelectedCustomer;
        private static int idxSelectedAppointment;
        public Main_Menu()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            databaseQueries = new DatabaseQueries(constr);
            idxSelectedCustomer = -1;
            idxSelectedAppointment = -1;



            customerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDGV.ReadOnly = true;
            customerDGV.MultiSelect = false;
            customerDGV.AllowUserToAddRows = false;

            appointmentDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentDGV.ReadOnly = true;
            appointmentDGV.MultiSelect = false;
            appointmentDGV.AllowUserToAddRows = false;

            DataTable d1 = databaseQueries.CustomerData();
            customerDGV.DataSource = d1;

            DataTable d2 = databaseQueries.AppointmentData();
            d2.DefaultView.Sort = "start ASC";
            appointmentDGV.DataSource = d2;

            for (int idx = 0; idx < d2.Rows.Count; idx++)
            {
                d2.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)d2.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
            }


        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customerDGV.ClearSelection();
        }

        private void myBindingComplete1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Customer f3 = new Add_Customer();
            f3.Show();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            if (idxSelectedCustomer >= 0)
            {
                this.Hide();
                Update_Customer f2 = new Update_Customer();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer to update!");
            }
        }

        private void Customer(object sender, DataGridViewCellEventArgs e)
        {
            idxSelectedCustomer = customerDGV.CurrentCell.RowIndex;
            Customers.CurrentCustomerID = (int)customerDGV.Rows[idxSelectedCustomer].Cells[0].Value;
            customerDGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if (customerDGV.CurrentRow == null || !customerDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a customer to delete!");
                return;
            }
                if (customerDGV.CurrentRow != null || !customerDGV.CurrentRow.Selected)
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                     {
                        int customerID = Customers.CurrentCustomerID;
                        int addressID = databaseQueries.GetAddressID(customerID);
                        int cityID = databaseQueries.GetCityID(customerID);
                        int countryID = databaseQueries.GetCountryID(customerID);


                    if (databaseQueries.DeleteCustomer(customerID, addressID, cityID, countryID))
                    {
                        MessageBox.Show("Customer successfully deleted!");
                        this.Hide();
                        Main_Menu f1 = new Main_Menu();
                        f1.Show();

                    }

                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
            }

            else
            {
                MessageBox.Show("Please select a customer to delete!");
         
            }

        }

        private void customerDataBinding(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            appointmentDGV.ClearSelection();
        }

        private void Appointment(object sender, DataGridViewCellEventArgs e)
        {
            idxSelectedAppointment = appointmentDGV.CurrentCell.RowIndex;
            Customers.CurrentUserID = (int)appointmentDGV.Rows[idxSelectedAppointment].Cells[0].Value;
            Customers.CurrentAppointmentID = (int)appointmentDGV.Rows[idxSelectedAppointment].Cells[1].Value;
            appointmentDGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
        }

        private void addAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Appointment f3 = new Add_Appointment();
            f3.Show();
        }

        private void updateAppointment_Click(object sender, EventArgs e)
        {

            if (idxSelectedAppointment >= 0)
            {
                this.Hide();
                Update_Appointment f2 = new Update_Appointment();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Please select an appointment to update!");
            }
            
        }

        private void deleteAppointment_Click(object sender, EventArgs e)
        {
            if (appointmentDGV.CurrentRow == null || !appointmentDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Please select an appointment to delete!");
                return;
            }
            if (appointmentDGV.CurrentRow != null || !appointmentDGV.CurrentRow.Selected)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int appointmentId = Customers.CurrentAppointmentID;
                    


                    if (databaseQueries.DeleteAppointment(appointmentId))
                    {
                        MessageBox.Show("Appointment successfully deleted!");
                        this.Hide();
                        Main_Menu f1 = new Main_Menu();
                        f1.Show();

                    }

                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
            }

        }

        private void filterAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filter_Appointments f3 = new Filter_Appointments();
            f3.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generate_Reports f3 = new Generate_Reports();
            f3.Show();
        }
    }
    }






