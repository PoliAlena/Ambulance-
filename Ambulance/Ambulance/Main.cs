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
    public partial class Main : Form
    {
        public Main()
        {
            database database = new database();
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.ambulanceDataSet.Patients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Brigades". При необходимости она может быть перемещена или удалена.
            this.brigadesTableAdapter.Fill(this.ambulanceDataSet.Brigades);
            datab.ContextMenuStrip = delete;
            
            SqlConnection myConnection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;");

            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("select Calls.ID, Brigades.Number, Specializations.Title, Actions.Description_actions, Calls.Date, Calls.Time, Calls.Address, concat(Patients.Surname, Patients.Name, Patients.LastName) as FIO, Patients.Date_of_birth, Patients.Sex from Calls join Brigades on Calls.ID_brigade = Brigades.ID join Patients on Calls.ID_patient = Patients.ID join Actions on Brigades.ID_actions = Actions.ID join Specializations on Brigades.ID_specialization = Specializations.ID;", myConnection);
                string selectquery = "select Calls.ID, Brigades.Number, Specializations.Title, Actions.Description_actions, Calls.Date, Calls.Time, Calls.Address, Patients.Surname, Patients.Name, Patients.LastName, Patients.Date_of_birth, Patients.Sex from Calls join Brigades on Calls.ID_brigade = Brigades.ID join Patients on Calls.ID_patient = Patients.ID join Actions on Brigades.ID_actions = Actions.ID join Specializations on Brigades.ID_specialization = Specializations.ID;";
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);

                DataTable table = new DataTable();
                adpt.Fill(table);
                datab.DataSource = table;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add a = new Add();
            a.Show();
        }

        private void directory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directories d = new Directories();
            d.Show();
        }


        private void удалитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (datab.SelectedRows.Count > 0)
            {

                int selectedIndex = datab.SelectedRows[0].Index;

                var primaryKeyValue = datab.Rows[selectedIndex].Cells["ID"].Value;

                using (SqlConnection myConnection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;"))
                {
                    myConnection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM Calls WHERE ID = @ID", myConnection))
                    {
                        command.Parameters.AddWithValue("@ID", primaryKeyValue);
                        command.ExecuteNonQuery();
                    }

                    myConnection.Close();
                }

                datab.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requests a = new Requests();
            a.Show();
        }

        private void datab_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.datab.Columns["ID"].Visible = false;
        }

    }
}
