using Devin_Perdue_Software2.Database;
using Devin_Perdue_Software2.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Devin_Perdue_Software2
{
    public partial class Add_Customer : Form
    {
        private DatabaseQueries databaseQueries;
        //internal static MySqlConnection conn { get; set; }
        private bool allowSave()
        {
            int number;
            return (!string.IsNullOrEmpty(customerName.Text)) && !Int32.TryParse(customerName.Text, out number) && (!string.IsNullOrWhiteSpace(customerAddress.Text)) && (!string.IsNullOrWhiteSpace(customerPhoneNumber.Text)) && (!string.IsNullOrWhiteSpace(customerCityName.Text)) && !Int32.TryParse(customerCityName.Text, out number) && (!string.IsNullOrWhiteSpace(customerCountryName.Text)) && !Int32.TryParse(customerCountryName.Text, out number);
        }
        public Add_Customer()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            databaseQueries = new DatabaseQueries(constr);
            requiredFields();
          
        }

        private void requiredFields()
        {
            if (string.IsNullOrWhiteSpace(customerName.Text))
            {
                customerName.BackColor = Color.Salmon;
            }
            if (string.IsNullOrWhiteSpace(customerAddress.Text))
            {
                customerAddress.BackColor = Color.Salmon;
            }
            if (string.IsNullOrWhiteSpace(customerPhoneNumber.Text))
            {
                customerPhoneNumber.BackColor = Color.Salmon;
            }
            if (string.IsNullOrWhiteSpace(customerCityName.Text))
            {
                customerCityName.BackColor = Color.Salmon;
            }
            if (string.IsNullOrWhiteSpace(customerCountryName.Text))
            {
                customerCountryName.BackColor = Color.Salmon;
            }
            saveCustomer.Enabled = false;
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

        private void saveCustomer_Click(object sender, EventArgs e)
        {
            string customer = customerName.Text;
            string address = customerAddress.Text;
            string phoneNumber = customerPhoneNumber.Text;
            string cityName = customerCityName.Text;
            string countryName = customerCountryName.Text;

            try
            {
                if (validNumber(phoneNumber) != true)
                {
                    MessageBox.Show("Phone number must be in 123-4567 format!");
                    return;
                }
                if (databaseQueries.NewCustomer(customer, address, phoneNumber, cityName, countryName))
                {
                    MessageBox.Show("Added New Customer!");
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


        private void cancelCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu f1 = new Main_Menu();
            f1.Show();
        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {

        }

        private void customerID_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validNumber(string phoneNumber)
        {
            string pattern = @"^\d{3}-\d{4}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
