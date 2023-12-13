using Devin_Perdue_Software2.Database;
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
    public partial class Generate_Schedule : Form
    {
        private DatabaseQueries databaseQueries;
        public Generate_Schedule()
        {
            InitializeComponent();

            reportDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportDGV.ReadOnly = true;
            reportDGV.MultiSelect = false;
            reportDGV.AllowUserToAddRows = false;

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            databaseQueries = new DatabaseQueries(constr);

            List<string> UserNames = databaseQueries.UserNameComboBox();
            userComboBox.DataSource = UserNames;

            
        }

        private void generateSchedule_Click(object sender, EventArgs e)
        {
            string userSelected = userComboBox.SelectedItem.ToString();
            DataTable d1 = databaseQueries.UserSchedule(userSelected);
            reportDGV.DataSource = d1;

            for (int idx = 0; idx < d1.Rows.Count; idx++)
            {
                d1.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)d1.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu f1 = new Main_Menu();
            f1.Show();
        }
    }
}
