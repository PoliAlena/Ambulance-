using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ambulance
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
            database database = new database();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main d = new Main();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;");

            try
            {
                myConnection.Open();

                if (req.Text == "Бригады")
                {
                    SqlCommand myCommand = new SqlCommand("SELECT Brigades.Number, Calls.Date, COUNT(*) AS calls_count FROM Calls join Brigades on Calls.ID_brigade = Brigades.ID GROUP BY Brigades.Number, Calls.Date ORDER BY Brigades.Number, Calls.Date;", myConnection);
                    string selectquery = "SELECT Brigades.Number, Calls.Date, COUNT(*) AS calls_count FROM Calls join Brigades on Calls.ID_brigade = Brigades.ID GROUP BY Brigades.Number, Calls.Date ORDER BY Brigades.Number, Calls.Date;";
                    SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                    DataTable table = new DataTable();
                    adpt.Fill(table);
                    datab.DataSource = table;
                }
                if (req.Text == "Специализации")
                {
                    SqlCommand myCommand = new SqlCommand("SELECT MONTH(Calls.Date) AS Month, Specializations.Title, COUNT(*) AS total_calls, Actions.Description_actions, COUNT(*) OVER(PARTITION BY Specializations.Title, Actions.Description_actions, MONTH(Calls.Date)) AS action_count FROM Calls join Brigades on Calls.ID_brigade = Brigades.ID join Patients on Calls.ID_patient = Patients.ID join Actions on Brigades.ID_actions = Actions.ID join Specializations on Brigades.ID_specialization = Specializations.ID GROUP BY MONTH(Calls.Date), Specializations.Title, Actions.Description_actions ORDER BY MONTH(Calls.Date);", myConnection);
                    string selectquery = "SELECT MONTH(Calls.Date) AS Month, Specializations.Title, COUNT(*) AS total_calls, Actions.Description_actions, COUNT(*) OVER(PARTITION BY Specializations.Title, Actions.Description_actions, MONTH(Calls.Date)) AS action_count FROM Calls join Brigades on Calls.ID_brigade = Brigades.ID join Patients on Calls.ID_patient = Patients.ID join Actions on Brigades.ID_actions = Actions.ID join Specializations on Brigades.ID_specialization = Specializations.ID GROUP BY MONTH(Calls.Date), Specializations.Title, Actions.Description_actions ORDER BY MONTH(Calls.Date);";
                    SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                    DataTable table = new DataTable();
                    adpt.Fill(table);
                    datab.DataSource = table;
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}
