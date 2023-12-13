using Devin_Perdue_Software2.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Devin_Perdue_Software2.Database
{
    internal class DatabaseQueries
    {
        internal static MySqlConnection conn { get; set; }
        string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        private string connectionString;




        public DatabaseQueries(string connection)
        {
            connectionString = connection;
        }

        public DataTable CustomerData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string user = "SELECT customer.customerId, customerName, address.addressId, address, phone, city.cityId, city, country.countryId, country FROM country, city, address, customer WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId";

                using (MySqlCommand cmd = new MySqlCommand(user, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
        }

        public DataTable AppointmentData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string user = "SELECT user.userId, appointmentId, customer.customerId, customer.customerName, type, start FROM customer, appointment, user WHERE customer.customerId = appointment.customerId AND appointment.userId = user.userId";

                using (MySqlCommand cmd = new MySqlCommand(user, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
        }
        public string CustomerName(int customerId)
        {
            string customerName = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string userName = "SELECT customerName FROM customer WHERE customerId = @name";

                using (MySqlCommand cmd = new MySqlCommand(userName, connection))
                {
                    cmd.Parameters.AddWithValue("@name", Customers.CurrentCustomerID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        customerName = reader.GetString(0);
                    }


                }
            }
            return customerName;
        }

        public string CustomerAddress(int customerId)
        {
            string customerAddress = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT address FROM country, city, address, customer WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId AND customerId = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", Customers.CurrentCustomerID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        customerAddress = reader.GetString(0);
                    }


                }
            }
            return customerAddress;

        }

        public string CustomerPhoneNumber(int customerId)
        {
            string customerPhoneNumber = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT phone FROM country, city, address, customer WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId AND customerId = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", Customers.CurrentCustomerID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        customerPhoneNumber = reader.GetString(0);
                    }


                }
            }
            return customerPhoneNumber;
        }

        public string CustomerCity(int customerId)
        {
            string customerCity = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT city FROM country, city, address, customer WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId AND customerId = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", Customers.CurrentCustomerID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        customerCity = reader.GetString(0);
                    }


                }
            }
            return customerCity;
        }

        public string CustomerCountry(int customerId)
        {
            string customerCountry = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT country FROM country, city, address, customer WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId AND customerId = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", Customers.CurrentCustomerID);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        customerCountry = reader.GetString(0);
                    }


                }
            }
            return customerCountry;
        }

        public bool UpdateCustomer(string customerName, string address, string phoneNumber, string cityName, string countryName)
        {
            using (MySqlConnection connection = new MySqlConnection(constr))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string update = "UPDATE country, city, address, customer SET customerName = @name, address = @address, phone = @phone, city = @city, country = @country WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId AND customerId = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(update, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@name", customerName);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@city", cityName);
                        cmd.Parameters.AddWithValue("@country", countryName);
                        cmd.Parameters.AddWithValue("@ID", Customers.CurrentCustomerID);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }
        public bool NewCustomer( string customerName, string address, string phoneNumber, string cityName, string countryName)
        {
            using (MySqlConnection connection = new MySqlConnection(constr))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int countryID;
                    string insertCountry = "INSERT INTO country VALUES (NULL, @country, NOW(), 'test', NOW(), 'test'); SELECT LAST_INSERT_ID()";
                    using (MySqlCommand command = new MySqlCommand(insertCountry, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@country", countryName);
                        countryID = Convert.ToInt32(command.ExecuteScalar());
                    }

                    int cityID;
                    string insertCity = "INSERT INTO city VALUES (NULL, @city, @countryID, NOW(), 'test', NOW(), 'test'); SELECT LAST_INSERT_ID();";
                    using (MySqlCommand command = new MySqlCommand(insertCity, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@city", cityName);
                        command.Parameters.AddWithValue("@countryID", countryID);
                        cityID = Convert.ToInt32(command.ExecuteScalar());
                    }

                    int addressID;
                    string insertAddress = "INSERT INTO address VALUES (NULL, @address, '', @cityID, 12345, @phone, NOW(), 'test', NOW(), 'test'); SELECT LAST_INSERT_ID();";
                    using (MySqlCommand command = new MySqlCommand(insertAddress, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@cityID", cityID);
                        command.Parameters.AddWithValue("@phone", phoneNumber);
                        addressID = Convert.ToInt32(command.ExecuteScalar());
                    }


                    string insertCustomer = "INSERT INTO customer VALUES (NULL, @customerName, @addressID, 1, NOW(), 'test', NOW(), 'test')";
                    using (MySqlCommand command = new MySqlCommand(insertCustomer, connection, transaction))
                    {
                        //command.Parameters.AddWithValue("@customerID", customerID);
                        command.Parameters.AddWithValue("@customerName", customerName);
                        command.Parameters.AddWithValue("@addressID", addressID);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool DeleteCustomer(int customerID, int addressID, int cityID, int countryID)
        {
            using (MySqlConnection connection = new MySqlConnection(constr))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteFromAppointment = "DELETE FROM appointment WHERE customerId= @customerID";
                    using(MySqlCommand command = new MySqlCommand(deleteFromAppointment, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@customerID", customerID);
                        command.ExecuteNonQuery();
                    }
                    string deleteCustomerID = "DELETE FROM customer WHERE customerId = @customerID";
                    using (MySqlCommand command = new MySqlCommand(deleteCustomerID, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@customerID", customerID);
                        command.ExecuteNonQuery();
                    }

                    string deleteAddressID = "DELETE FROM address WHERE addressId = @addressID";
                    using (MySqlCommand command = new MySqlCommand(deleteAddressID, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@addressID", addressID);
                        command.ExecuteNonQuery();
                    }

                    string deleteCityID = "DELETE FROM city WHERE cityId = @cityID";
                    using (MySqlCommand command = new MySqlCommand(deleteCityID, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@cityID", cityID);
                        command.ExecuteNonQuery();
                    }

                    string deleteCountryID = "DELETE FROM country WHERE countryId = @countryID";
                    using (MySqlCommand command = new MySqlCommand(deleteCountryID, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@countryID", countryID);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public int GetAddressID(int customerId)
        {
            int addressID = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT address.addressId FROM address, customer WHERE customer.addressId = address.addressId AND customerId = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", customerId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        addressID = reader.GetInt32(0);
                    }


                }
            }
            return addressID;
        }

        public int GetCityID(int customerId)
        {
            int cityID = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT city.cityId FROM city, address, customer WHERE customer.addressId = address.addressId  AND address.cityId = city.cityId AND customerId = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", customerId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cityID = reader.GetInt32(0);
                    }


                }
            }
            return cityID;
        }

        public int GetCountryID(int customerId)
        {
            int countryID = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT country.countryId FROM country, city, address, customer WHERE customer.addressId = address.addressId  AND address.cityId = city.cityId AND city.countryId = country.countryId AND customerId = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", customerId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        countryID = reader.GetInt32(0);
                    }


                }
            }
            return countryID;
        }

        public List<string> CustomerNameComboBox()
        {
            List<string> customerNames = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string names = "Select customerName from customer";

                using (MySqlCommand cmd = new MySqlCommand(names, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customerNames.Add(reader["customerName"].ToString());
                        }
                    }
                }
            }
            return customerNames;
        }

        public string AppointmentDescription(int appointmentID)
        {
            string appointmentDescription = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string description = "SELECT type from appointment WHERE appointmentId = @appointmentID";

                using (MySqlCommand cmd = new MySqlCommand(description, connection))
                {
                    cmd.Parameters.AddWithValue("@appointmentID", Customers.CurrentAppointmentID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        appointmentDescription = reader.GetString(0);
                    }


                }
            }
            return appointmentDescription;
        }

        public DateTime AppointmentTime(int appointmentID)
        {
            DateTime appointmentTime = DateTime.MinValue;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string time = "SELECT start from appointment WHERE appointmentId = @appointmentID";

                using (MySqlCommand cmd = new MySqlCommand(time, connection))
                {
                    cmd.Parameters.AddWithValue("@appointmentID", Customers.CurrentAppointmentID);
                    object result = cmd.ExecuteScalar();
                    appointmentTime = (DateTime)result;

                }
            }
            return appointmentTime;
        }

        public bool UpdateAppointment(string customerName, string type, DateTime time)
        {
            using (MySqlConnection connection = new MySqlConnection(constr))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string update = "UPDATE appointment SET appointment.customerId = @customerID, type = @type, start = @time, end = @end WHERE appointmentId = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(update, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@customerID", GetCustomerID(customerName));
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.Parameters.AddWithValue("@end", time.AddMinutes(30));
                        cmd.Parameters.AddWithValue("@ID", Customers.CurrentAppointmentID);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public List<DateTime> ExistingAppointments()
        {
            List<DateTime> appointmentTimes = new List<DateTime>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string names = "Select start from appointment";

                using (MySqlCommand cmd = new MySqlCommand(names, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointmentTimes.Add((DateTime)reader["start"]);
                        }
                    }
                }
            }
            return appointmentTimes;
        }

        public List<DateTime> UpdateExistingAppointments(int appointmentID)
        {
            List<DateTime> appointmentTimes = new List<DateTime>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string names = "Select start from appointment WHERE appointmentId != @ID";

                using (MySqlCommand cmd = new MySqlCommand(names, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", appointmentID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointmentTimes.Add((DateTime)reader["start"]);
                        }
                    }
                }
            }
            return appointmentTimes;
        }

        public List<DateTime> UserAppointemnts(int userID)
        {
            List<DateTime> appointmentTimes = new List<DateTime>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string names = "Select start from appointment WHERE userId = @ID";

                using (MySqlCommand cmd = new MySqlCommand(names, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", userID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointmentTimes.Add((DateTime)reader["start"]);
                        }
                    }
                }
            }
            return appointmentTimes;
        }

       

        public int GetUserID(string userName)
        {
            int userID = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT userId from user WHERE userName = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", userName);// Customers.CurrentUserName);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userID = reader.GetInt32(0);
                    }


                }
            }
            return userID;
        }

        //public int NewAppointmentID()
        //{
        //    int appointmentID = 0;
        //    using (MySqlConnection connection = new MySqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string address = "SELECT count(*) from appointment";

        //        using (MySqlCommand cmd = new MySqlCommand(address, connection))
        //        {
        //            string result = cmd.ExecuteScalar()?.ToString();
        //            Int32.TryParse(result, out int result1);
        //            int newResult = result1 + 1;
        //            appointmentID = newResult;


        //        }
        //    }
        //    return appointmentID;
        //}

        public bool NewAppointment(int userID, string customerName, string type, DateTime time)
        {
            using (MySqlConnection connection = new MySqlConnection(constr))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string update = "INSERT INTO appointment VALUES (NULL, @customerID, @userID, 'not needed', 'not needed', 'not needed', 'not needed', @type, 'not needed', @start, @end, NOW(), @username, NOW(), @username)";
                    using (MySqlCommand cmd = new MySqlCommand(update, connection, transaction))
                    {
                        //cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        cmd.Parameters.AddWithValue("@customerID", GetCustomerID(customerName));
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@start", time);
                        cmd.Parameters.AddWithValue("@end", time.AddMinutes(30));
                        cmd.Parameters.AddWithValue("@username", Customers.CurrentUserName);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public int GetCustomerID(string customerName)
        {
            int customerID = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string address = "SELECT customerId FROM customer WHERE customerName = @name";

                using (MySqlCommand cmd = new MySqlCommand(address, connection))
                {
                    cmd.Parameters.AddWithValue("@name", customerName);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        customerID = reader.GetInt32(0);
                    }


                }
            }
            return customerID;
        }

        public bool DeleteAppointment(int appointmentID)
        {
            using (MySqlConnection connection = new MySqlConnection(constr))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteAppointment = "DELETE FROM appointment WHERE appointmentId = @ID";
                    using (MySqlCommand command = new MySqlCommand(deleteAppointment, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ID", appointmentID);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public DataTable GetMonthAppointments(string startDate, string endDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string appointment = "SELECT appointmentId, type, start from appointment WHERE start BETWEEN ('" + startDate + "') AND ('" + endDate + "');";

                using (MySqlCommand cmd = new MySqlCommand(appointment, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
        }

        public DataTable GetWeekAppointments(string startDate, string endDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string appointment = "SELECT appointmentId, type, start from appointment WHERE start BETWEEN ('" + startDate + "') AND ('" + endDate + "');";

                using (MySqlCommand cmd = new MySqlCommand(appointment, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
        }

        public DataTable GetDayAppointments(string startDate, string endDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string appointment = "SELECT * from appointment WHERE start BETWEEN ('" + startDate + "') AND ('" + endDate + "');";
                using (MySqlCommand cmd = new MySqlCommand(appointment, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
        }

        public DataTable AppointmentsByMonth()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string user = "SELECT appointmentId, type, start from appointment";

                using (MySqlCommand cmd = new MySqlCommand(user, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
        }

        public DataTable UserSchedule(string userName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string user = "SELECT appointmentId, type, start from appointment, user WHERE user.userId = appointment.userId AND userName = @Name";

                using (MySqlCommand cmd = new MySqlCommand(user, connection))
                {
                    cmd.Parameters.AddWithValue("Name", userName);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
        }

        public DataTable TotalAppointments()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string user = "SELECT appointmentId, type, start from appointment";

                using (MySqlCommand cmd = new MySqlCommand(user, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
        }

        public List<string> UserNameComboBox()
        {
            List<string> userNames = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string names = "Select userName from user";

                using (MySqlCommand cmd = new MySqlCommand(names, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userNames.Add(reader["userName"].ToString());
                        }
                    }
                }
            }
            return userNames;



        }


    }

}
        
    

