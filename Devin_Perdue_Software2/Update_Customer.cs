using Devin_Perdue_Software2.Database;
using Devin_Perdue_Software2.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devin_Perdue_Software2
{
    public partial class Update_Customer : Form
    {
        internal static MySqlConnection conn { get; set; }
        private DatabaseQueries databaseQueries;
        private bool allowSave()
        {
            int number;
            return (!string.IsNullOrEmpty(customerName.Text)) && !Int32.TryParse(customerName.Text, out number) && (!string.IsNullOrWhiteSpace(customerAddress.Text)) && (!string.IsNullOrWhiteSpace(customerPhoneNumber.Text)) && (!string.IsNullOrWhiteSpace(customerCityName.Text)) && !Int32.TryParse(customerCityName.Text, out number) && (!string.IsNullOrWhiteSpace(customerCountryName.Text)) && !Int32.TryParse(customerCountryName.Text, out number);
        }

        public Update_Customer()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            databaseQueries = new DatabaseQueries(constr);

            customerID.Text = Customers.CurrentCustomerID.ToString();
            getCustomerName(Customers.CurrentCustomerID);
            getCustomerAddress(Customers.CurrentCustomerID);
            getCustomerPhoneNumber(Customers.CurrentCustomerID);
            getCustomerCity(Customers.CurrentCustomerID);
            getCustomerCountry(Customers.CurrentCustomerID);


        }
        private void getCustomerName(int customerId)
        {
            string currentCustomerName = databaseQueries.CustomerName(customerId);
            customerName.Text = currentCustomerName;
        }

        private void getCustomerAddress(int customerId)
        {
            string currentAddress = databaseQueries.CustomerAddress(customerId);
            customerAddress.Text = currentAddress;
        }

        private void getCustomerPhoneNumber(int customerId)
        {
            string currentPhoneNumber = databaseQueries.CustomerPhoneNumber(customerId);
            customerPhoneNumber.Text = currentPhoneNumber;
        }

        private void getCustomerCity(int customerId)
        {
            string currentCity = databaseQueries.CustomerCity(customerId);
            customerCityName.Text = currentCity;
        }

        private void getCustomerCountry(int customerId)
        {
            string currentCountry = databaseQueries.CustomerCountry(customerId);
            customerCountryName.Text = currentCountry;
        }

        private void cancelCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu f1 = new Main_Menu(); 
            f1.Show();
        }

        private void saveCustomer_Click(object sender, EventArgs e)
        {
            string customer = customerName.Text;
            string address = customerAddress.Text;
            string phoneNumber = customerPhoneNumber.Text;
            string cityName = customerCityName.Text;
            string countryName = customerCountryName.Text;

            try
            {
                if (validNumber(phoneNumber)!= true)
                {
                    MessageBox.Show("Phone number must be in 123-4567 format!");
                    return;
                }
                if (databaseQueries.UpdateCustomer(customer, address, phoneNumber, cityName, countryName))
                {
                    MessageBox.Show("Updated Customer!");
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

        private void customerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(customerName.Text) || Int32.TryParse(customerName.Text, out number))
            {
                customerName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                customerName.BackColor = System.Drawing.Color.White;
            }
            saveCustomer.Enabled = allowSave();
        }

        private void customerAddress_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(customerAddress.Text)) 
            {
                customerAddress.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                customerAddress.BackColor = System.Drawing.Color.White;
            }
            saveCustomer.Enabled = allowSave();
        }

        private void customerPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(customerPhoneNumber.Text))
            {
                customerPhoneNumber.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                customerPhoneNumber.BackColor = System.Drawing.Color.White;
            }
            saveCustomer.Enabled = allowSave();
        }

        private void customerCityName_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(customerCityName.Text) || Int32.TryParse(customerCityName.Text, out number))
            {
                customerCityName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                customerCityName.BackColor = System.Drawing.Color.White;
            }
            saveCustomer.Enabled = allowSave();
        }

        private void customerCountryName_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(customerCountryName.Text) || Int32.TryParse(customerCountryName.Text, out number))
            {
                customerCountryName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                customerCountryName.BackColor = System.Drawing.Color.White;
            }
            saveCustomer.Enabled = allowSave();
        }

        private bool validNumber(string phoneNumber)
        {
            string pattern = @"^\d{3}-\d{4}$";
            return Regex.IsMatch(phoneNumber, pattern); 
        }
    }
}
