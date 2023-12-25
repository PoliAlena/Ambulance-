using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ambulance
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            database database = new database();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Бригады")
            {
                brigad.Visible= true;
                patien.Visible = false;
                act.Visible = false;
                calls.Visible = false;
                spec.Visible = false;
            }
                
            if (comboBox1.Text == "Пациенты")
            {
                brigad.Visible = false;
                patien.Visible = true;
                act.Visible = false;
                spec.Visible = false;
                calls.Visible = false;
            }
            if (comboBox1.Text == "Специализации")
            {
                brigad.Visible = false;
                patien.Visible = false;
                act.Visible = false;
                spec.Visible = true;
                calls.Visible = false;
            }
            if (comboBox1.Text == "Действия")
            {
                brigad.Visible = false;
                patien.Visible = false;
                act.Visible = true;
                spec.Visible = false;
                calls.Visible = false;
            }
            if (comboBox1.Text == "Звонки")
            {
                brigad.Visible = false;
                patien.Visible = false;
                act.Visible = false;
                spec.Visible = false;
                calls.Visible = true;
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main d = new Main();
            d.Show();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Actions". При необходимости она может быть перемещена или удалена.
            this.actionsTableAdapter.Fill(this.ambulanceDataSet.Actions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Specializations". При необходимости она может быть перемещена или удалена.
            this.specializationsTableAdapter.Fill(this.ambulanceDataSet.Specializations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Calls". При необходимости она может быть перемещена или удалена.
            this.callsTableAdapter.Fill(this.ambulanceDataSet.Calls);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.ambulanceDataSet.Patients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ambulanceDataSet.Brigades". При необходимости она может быть перемещена или удалена.
            this.brigadesTableAdapter.Fill(this.ambulanceDataSet.Brigades);



        }

        private void button_actions_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openconection();
          
            if (double.TryParse(actions_t.Text, out double t) is false)
            {
                var actions = actions_t.Text;
                var addType = $"insert into Actions (Description_actions) values ('{actions}')";
                var command = new SqlCommand(addType, database.getconnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Данные некорректны", "Попробуйте еще раз!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_calls_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openconection();

            if ( double.TryParse(address_t.Text, out double a) is false)
            {
                var time_t1 = dateTimePicker1.Value.ToString("hh-mm-ss");
                var date_t1 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                var address_t1 = address_t.Text;
                var brig_t1 = brig_t.Text;
                var pat_t1 = pat_t.Text;

                var addType = $"insert into Calls (ID_brigade, Date, Time, Address, ID_patient) values ((select ID from Brigades where Number = '{brig_t1}'),'{date_t1}', '{time_t1}', '{address_t1}', '{pat_t1}')";
                var command = new SqlCommand(addType, database.getconnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeconection();
            }
            else
            {
                MessageBox.Show("Данные некорректны", "Попробуйте еще раз!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void add_b_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openconection();

            if (double.TryParse(number_b.Text, out double t) is false)
            { 
                var number_b1 = number_b.Text;
                var spec_b1 = spec_b.Text;
                var act_b1 = act_b.Text;

                var addType = $"insert into Brigades (Number, ID_specialization, ID_actions) values ('{number_b1}', (select ID from Specializations where Title = '{spec_b1}'), (select ID from Actions where Description_actions = '{act_b1}'))";
                var command = new SqlCommand(addType, database.getconnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeconection();
            }
            else
            {
                MessageBox.Show("Данные некорректны", "Попробуйте еще раз!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_spec_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openconection();
            if (double.TryParse(spec_t.Text, out double t) is false)
            {

                var spect_t1 = spec_t.Text;

                var addType = $"insert into Specializations (Title) values ('{spect_t1}')";
                var command = new SqlCommand(addType, database.getconnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeconection();
            }
            else
            {
                MessageBox.Show("Данные некорректны", "Попробуйте еще раз!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void add_p_Click(object sender, EventArgs e)
        {
            database database = new database();
            database.openconection();
            if (double.TryParse(name_t.Text, out double t) is false || double.TryParse(surname_t.Text, out double s) is false || double.TryParse(lastname_t.Text, out double l) is false)
            {
                var name_t1 = name_t.Text;
                var surname_t1 = surname_t.Text;
                var lastname_t1 = lastname_t.Text;
                var date_of_birth_t1 = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                var sex_t1 = sex_t.Text;

                var addType = $"insert into Patients (Surname, Name, Lastname, Date_of_birth, Sex) values ('{surname_t1}', '{name_t1}', '{lastname_t1}', '{date_of_birth_t1}', '{sex_t1}')";
                var command = new SqlCommand(addType, database.getconnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeconection();
            }
            else
            {
                MessageBox.Show("Данные некорректны", "Попробуйте еще раз!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
{
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void name_t_TextChanged(object sender, EventArgs e)
        {

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
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
{
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
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

        private void time_t_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
