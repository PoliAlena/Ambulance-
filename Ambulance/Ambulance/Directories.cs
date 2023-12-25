using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ambulance
{
    public partial class Directories : Form
    {
        public Directories()
        {
            database database = new database();
            InitializeComponent();
        }

        private void Dtb( string selectquery, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;");

            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(selectquery, myConnection);
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
        private void Directories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Actions". При необходимости она может быть перемещена или удалена.
            this.actionsTableAdapter.Fill(this.ambulanceDataSet.Actions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Specializations". При необходимости она может быть перемещена или удалена.
            this.specializationsTableAdapter.Fill(this.ambulanceDataSet.Specializations);
            datab.ContextMenuStrip = delete;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( comboBox1.Text == "Бригады") 
            {
                Dtb("select Brigades.ID, Brigades.Number, Specializations.Title, Actions.Description_actions from Brigades join Actions on Brigades.ID_actions = Actions.ID join Specializations on Brigades.ID_specialization = Specializations.ID", e);
            }
            if (comboBox1.Text == "Пациенты")
            {
                Dtb("select* from Patients", e);
            }
            if (comboBox1.Text == "Специализации")
            {
                Dtb("select* from Specializations", e);
            }
            if (comboBox1.Text == "Действия")
            {
                Dtb("select* from Actions", e);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main d = new Main();
            d.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datab.SelectedRows.Count > 0)
            {

                int selectedIndex = datab.SelectedRows[0].Index;

                var primaryKeyValue = datab.Rows[selectedIndex].Cells["ID"].Value;

                using (SqlConnection myConnection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;"))
                {
                    myConnection.Open();
                    if (comboBox1.Text == "Действия")
                    {
                        using (SqlCommand command = new SqlCommand("DELETE FROM Actions WHERE ID = @ID", myConnection))
                        {
                            command.Parameters.AddWithValue("@ID", primaryKeyValue);
                            command.ExecuteNonQuery();
                        }
                    }

                    if (comboBox1.Text == "Специализации")
                    {
                        using (SqlCommand command = new SqlCommand("DELETE FROM Specializations WHERE ID = @ID", myConnection))
                        {
                            command.Parameters.AddWithValue("@ID", primaryKeyValue);
                            command.ExecuteNonQuery();
                        }
                    }

                    if (comboBox1.Text == "Пациенты")
                    {
                        using (SqlCommand command = new SqlCommand("DELETE FROM Patients WHERE ID = @ID", myConnection))
                        {
                            command.Parameters.AddWithValue("@ID", primaryKeyValue);
                            command.ExecuteNonQuery();
                        }
                    }

                    if (comboBox1.Text == "Бригады")
                    {
                        using (SqlCommand command = new SqlCommand("DELETE FROM Brigades WHERE ID = @ID", myConnection))
                        {
                            command.Parameters.AddWithValue("@ID", primaryKeyValue);
                            command.ExecuteNonQuery();
                        }
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

        private void button2_Click(object sender, EventArgs e)
        {
            brigad.Visible = false;
        }

        private void add_b_Click(object sender, EventArgs e)
        {
            if (datab.SelectedRows.Count > 0)
            {
                int selectedIndex = datab.SelectedRows[0].Index;
                var primaryKeyValue = datab.Rows[selectedIndex].Cells["ID"].Value;
                var num = number_b.Text;
                var a = act_b.Text;
                var sp = spec_b.Text;
                string updateQuery = "UPDATE Brigades SET  Number = @newnum, ID_specialization = (select ID from Specializations where Title = @newspec), ID_actions = (select ID from Actions where Description_actions = @newact) WHERE ID = @ID";

                using (SqlConnection connection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;"))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newnum", num);
                        command.Parameters.AddWithValue("@newspec", sp);
                        command.Parameters.AddWithValue("@newact", a);
                        command.Parameters.AddWithValue("@ID", primaryKeyValue);

                        connection.Open();
                        command.ExecuteNonQuery();
                        brigad.Visible = false;
                    }
                }
                MessageBox.Show("Запись успешно изменена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                datab.SelectedRows[0].Cells["Number"].Value = num;
                datab.SelectedRows[0].Cells["Description_actions"].Value = a;
                datab.SelectedRows[0].Cells["Title"].Value = sp;

            }
        }

        private void add_p_Click(object sender, EventArgs e)
        {
            if (datab.SelectedRows.Count > 0)
            {
                int selectedIndex = datab.SelectedRows[0].Index;
                var primaryKeyValue = datab.Rows[selectedIndex].Cells["ID"].Value;
                var sur = surname_t.Text;
                var name = name_t.Text;
                var ln = lastname_t.Text;
                var dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                var s = sex_t.Text;

                string updateQuery = "UPDATE Patients SET Surname = @newsur, Name = @newname, Lastname = @newln, Date_of_birth = @newdob, Sex = @news WHERE ID = @ID";

                using (SqlConnection connection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;"))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newsur", sur);
                        command.Parameters.AddWithValue("@newname", name);
                        command.Parameters.AddWithValue("@newln", ln);
                        command.Parameters.AddWithValue("@newdob", dob);
                        command.Parameters.AddWithValue("@news", s);
                        command.Parameters.AddWithValue("@ID", primaryKeyValue);

                        connection.Open();
                        command.ExecuteNonQuery();
                        patien.Visible = false;
                    }
                }
                MessageBox.Show("Запись успешно изменена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                datab.SelectedRows[0].Cells["Surname"].Value = sur;
                datab.SelectedRows[0].Cells["Name"].Value = name;
                datab.SelectedRows[0].Cells["Lastname"].Value = ln;
                datab.SelectedRows[0].Cells["Date_of_birth"].Value = dob;
                datab.SelectedRows[0].Cells["Sex"].Value = s;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patien.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            spec.Visible= false;
        }

        private void button_spec_Click(object sender, EventArgs e)
        {
            if (datab.SelectedRows.Count > 0)
            {
                int selectedIndex = datab.SelectedRows[0].Index;
                var primaryKeyValue = datab.Rows[selectedIndex].Cells["ID"].Value;
                var t = spec_t.Text;
                string updateQuery = "UPDATE Specializations SET  Title = @newt WHERE ID = @ID";

                using (SqlConnection connection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;"))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newt", t);
                        command.Parameters.AddWithValue("@ID", primaryKeyValue);

                        connection.Open();
                        command.ExecuteNonQuery();
                        spec.Visible = false;
                    }
                }
                MessageBox.Show("Запись успешно изменена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                datab.SelectedRows[0].Cells["Title"].Value = t;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            act.Visible= false;
        }

        private void button_actions_Click(object sender, EventArgs e)
        {
            if (datab.SelectedRows.Count > 0)
            {
                int selectedIndex = datab.SelectedRows[0].Index;
                var primaryKeyValue = datab.Rows[selectedIndex].Cells["ID"].Value;
                var a = actions_t.Text;
                string updateQuery = "UPDATE Actions SET  Description_actions = @newa WHERE ID = @ID";

                using (SqlConnection connection = new SqlConnection("Server = DESKTOP-GDHCIFF; database = ambulance; Integrated Security=True;"))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newa", a);
                        command.Parameters.AddWithValue("@ID", primaryKeyValue);

                        connection.Open();
                        command.ExecuteNonQuery();
                        act.Visible = false;
                    }
                }
                MessageBox.Show("Запись успешно изменена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                datab.SelectedRows[0].Cells["Description_actions"].Value = a;
            }
        }

        private void datab_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.Text == "Действия")
            {
                act.Visible = true;
                actions_t.Text = datab.CurrentRow.Cells[1].Value.ToString();
            }
            if (comboBox1.Text == "Специализации")
            {
                spec.Visible = true;
                spec_t.Text = datab.CurrentRow.Cells[1].Value.ToString();
            }
            if (comboBox1.Text == "Пациенты")
            {
                patien.Visible = true;
                surname_t.Text = datab.CurrentRow.Cells[1].Value.ToString();
                name_t.Text = datab.CurrentRow.Cells[2].Value.ToString();
                lastname_t.Text = datab.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = datab.CurrentRow.Cells[4].Value.ToString();
                sex_t.Text = datab.CurrentRow.Cells[5].Value.ToString();
            }
            if (comboBox1.Text == "Бригады")
            {
                brigad.Visible = true;
                number_b.Text = datab.CurrentRow.Cells[1].Value.ToString();
                spec_b.Text = datab.CurrentRow.Cells[2].Value.ToString();
                act_b.Text = datab.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void datab_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.datab.Columns["ID"].Visible = false;
        }

        private void number_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(number_b.Text, out int value) || value <= 0)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите цифры!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void spec_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void actions_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void surname_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void name_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void lastname_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        
    }
}
