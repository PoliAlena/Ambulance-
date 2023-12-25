namespace Ambulance
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.surname_t = new System.Windows.Forms.TextBox();
            this.add_p = new System.Windows.Forms.Button();
            this.lastname_t = new System.Windows.Forms.TextBox();
            this.name_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patien = new System.Windows.Forms.GroupBox();
            this.sex_t = new System.Windows.Forms.ComboBox();
            this.spec = new System.Windows.Forms.GroupBox();
            this.button_spec = new System.Windows.Forms.Button();
            this.spec_t = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.act = new System.Windows.Forms.GroupBox();
            this.button_actions = new System.Windows.Forms.Button();
            this.actions_t = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.brigad = new System.Windows.Forms.GroupBox();
            this.spec_b = new System.Windows.Forms.ComboBox();
            this.specializationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulanceDataSet = new Ambulance.ambulanceDataSet();
            this.Specialization = new System.Windows.Forms.Label();
            this.act_b = new System.Windows.Forms.ComboBox();
            this.actionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Number = new System.Windows.Forms.Label();
            this.number_b = new System.Windows.Forms.TextBox();
            this.add_b = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.Label();
            this.calls = new System.Windows.Forms.GroupBox();
            this.brig_t = new System.Windows.Forms.ComboBox();
            this.brigadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pat_t = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_calls = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.address_t = new System.Windows.Forms.TextBox();
            this.fKCallsPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brigadesTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.BrigadesTableAdapter();
            this.patientsTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.PatientsTableAdapter();
            this.callsTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.CallsTableAdapter();
            this.specializationsTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.SpecializationsTableAdapter();
            this.actionsTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.ActionsTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.patien.SuspendLayout();
            this.spec.SuspendLayout();
            this.act.SuspendLayout();
            this.brigad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBindingSource)).BeginInit();
            this.calls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brigadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCallsPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // surname_t
            // 
            this.surname_t.Location = new System.Drawing.Point(15, 88);
            this.surname_t.Name = "surname_t";
            this.surname_t.Size = new System.Drawing.Size(140, 39);
            this.surname_t.TabIndex = 0;
            this.surname_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_t_KeyPress);
            // 
            // add_p
            // 
            this.add_p.BackColor = System.Drawing.Color.Red;
            this.add_p.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_p.ForeColor = System.Drawing.Color.White;
            this.add_p.Location = new System.Drawing.Point(164, 238);
            this.add_p.Name = "add_p";
            this.add_p.Size = new System.Drawing.Size(100, 46);
            this.add_p.TabIndex = 1;
            this.add_p.Text = "Добавить";
            this.add_p.UseVisualStyleBackColor = false;
            this.add_p.Click += new System.EventHandler(this.add_p_Click);
            // 
            // lastname_t
            // 
            this.lastname_t.Location = new System.Drawing.Point(322, 88);
            this.lastname_t.Name = "lastname_t";
            this.lastname_t.Size = new System.Drawing.Size(139, 39);
            this.lastname_t.TabIndex = 4;
            this.lastname_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastname_t_KeyPress);
            // 
            // name_t
            // 
            this.name_t.Location = new System.Drawing.Point(174, 88);
            this.name_t.Name = "name_t";
            this.name_t.Size = new System.Drawing.Size(127, 39);
            this.name_t.TabIndex = 5;
            this.name_t.TextChanged += new System.EventHandler(this.name_t_TextChanged);
            this.name_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_t_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(171, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(318, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(240, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пол";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Звонки",
            "Бригады",
            "Пациенты",
            "Действия",
            "Специализации"});
            this.comboBox1.Location = new System.Drawing.Point(188, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 39);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "Выберите таблицу";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.BackgroundImage = global::Ambulance.Properties.Resources.х;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(530, 12);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 45);
            this.Exit.TabIndex = 12;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ambulance.Properties.Resources.Lovepik_com_400214670_red_cross_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 128);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // patien
            // 
            this.patien.Controls.Add(this.dateTimePicker3);
            this.patien.Controls.Add(this.sex_t);
            this.patien.Controls.Add(this.label1);
            this.patien.Controls.Add(this.surname_t);
            this.patien.Controls.Add(this.label2);
            this.patien.Controls.Add(this.name_t);
            this.patien.Controls.Add(this.add_p);
            this.patien.Controls.Add(this.label5);
            this.patien.Controls.Add(this.label3);
            this.patien.Controls.Add(this.label4);
            this.patien.Controls.Add(this.lastname_t);
            this.patien.Location = new System.Drawing.Point(38, 197);
            this.patien.Name = "patien";
            this.patien.Size = new System.Drawing.Size(482, 303);
            this.patien.TabIndex = 14;
            this.patien.TabStop = false;
            this.patien.Text = "Пациенты";
            this.patien.Visible = false;
            // 
            // sex_t
            // 
            this.sex_t.FormattingEnabled = true;
            this.sex_t.Items.AddRange(new object[] {
            "Ж",
            "М"});
            this.sex_t.Location = new System.Drawing.Point(246, 177);
            this.sex_t.Name = "sex_t";
            this.sex_t.Size = new System.Drawing.Size(66, 39);
            this.sex_t.TabIndex = 11;
            // 
            // spec
            // 
            this.spec.Controls.Add(this.button_spec);
            this.spec.Controls.Add(this.spec_t);
            this.spec.Controls.Add(this.label6);
            this.spec.Controls.Add(this.label7);
            this.spec.Location = new System.Drawing.Point(12, 191);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(466, 252);
            this.spec.TabIndex = 18;
            this.spec.TabStop = false;
            this.spec.Text = "Специализация";
            this.spec.Visible = false;
            // 
            // button_spec
            // 
            this.button_spec.BackColor = System.Drawing.Color.Red;
            this.button_spec.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_spec.ForeColor = System.Drawing.Color.White;
            this.button_spec.Location = new System.Drawing.Point(174, 190);
            this.button_spec.Name = "button_spec";
            this.button_spec.Size = new System.Drawing.Size(92, 35);
            this.button_spec.TabIndex = 17;
            this.button_spec.Text = "Добавить";
            this.button_spec.UseVisualStyleBackColor = false;
            this.button_spec.Click += new System.EventHandler(this.button_spec_Click);
            // 
            // spec_t
            // 
            this.spec_t.Location = new System.Drawing.Point(14, 64);
            this.spec_t.Multiline = true;
            this.spec_t.Name = "spec_t";
            this.spec_t.Size = new System.Drawing.Size(380, 91);
            this.spec_t.TabIndex = 0;
            this.spec_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spec_t_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Специализация бригады";
            // 
            // act
            // 
            this.act.Controls.Add(this.button_actions);
            this.act.Controls.Add(this.actions_t);
            this.act.Controls.Add(this.label13);
            this.act.Location = new System.Drawing.Point(24, 191);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(448, 246);
            this.act.TabIndex = 16;
            this.act.TabStop = false;
            this.act.Text = "Действия";
            this.act.Visible = false;
            // 
            // button_actions
            // 
            this.button_actions.BackColor = System.Drawing.Color.Red;
            this.button_actions.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_actions.ForeColor = System.Drawing.Color.White;
            this.button_actions.Location = new System.Drawing.Point(167, 190);
            this.button_actions.Name = "button_actions";
            this.button_actions.Size = new System.Drawing.Size(92, 35);
            this.button_actions.TabIndex = 17;
            this.button_actions.Text = "Добавить";
            this.button_actions.UseVisualStyleBackColor = false;
            this.button_actions.Click += new System.EventHandler(this.button_actions_Click);
            // 
            // actions_t
            // 
            this.actions_t.Location = new System.Drawing.Point(14, 64);
            this.actions_t.Multiline = true;
            this.actions_t.Name = "actions_t";
            this.actions_t.Size = new System.Drawing.Size(379, 116);
            this.actions_t.TabIndex = 0;
            this.actions_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.actions_t_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(245, 32);
            this.label13.TabIndex = 9;
            this.label13.Text = "Описание действий";
            // 
            // brigad
            // 
            this.brigad.Controls.Add(this.spec_b);
            this.brigad.Controls.Add(this.Specialization);
            this.brigad.Controls.Add(this.act_b);
            this.brigad.Controls.Add(this.Number);
            this.brigad.Controls.Add(this.number_b);
            this.brigad.Controls.Add(this.add_b);
            this.brigad.Controls.Add(this.Actions);
            this.brigad.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brigad.Location = new System.Drawing.Point(17, 201);
            this.brigad.Name = "brigad";
            this.brigad.Size = new System.Drawing.Size(482, 300);
            this.brigad.TabIndex = 15;
            this.brigad.TabStop = false;
            this.brigad.Text = "Бригады";
            this.brigad.Visible = false;
            // 
            // spec_b
            // 
            this.spec_b.DataSource = this.specializationsBindingSource;
            this.spec_b.DisplayMember = "Title";
            this.spec_b.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spec_b.FormattingEnabled = true;
            this.spec_b.Location = new System.Drawing.Point(20, 134);
            this.spec_b.Name = "spec_b";
            this.spec_b.Size = new System.Drawing.Size(402, 39);
            this.spec_b.TabIndex = 13;
            // 
            // specializationsBindingSource
            // 
            this.specializationsBindingSource.DataMember = "Specializations";
            this.specializationsBindingSource.DataSource = this.ambulanceDataSet;
            // 
            // ambulanceDataSet
            // 
            this.ambulanceDataSet.DataSetName = "ambulanceDataSet";
            this.ambulanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Specialization.Location = new System.Drawing.Point(18, 111);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(192, 32);
            this.Specialization.TabIndex = 12;
            this.Specialization.Text = "Специализация";
            // 
            // act_b
            // 
            this.act_b.DataSource = this.actionsBindingSource;
            this.act_b.DisplayMember = "Description_actions";
            this.act_b.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.act_b.FormattingEnabled = true;
            this.act_b.Location = new System.Drawing.Point(22, 203);
            this.act_b.Name = "act_b";
            this.act_b.Size = new System.Drawing.Size(400, 39);
            this.act_b.TabIndex = 11;
            // 
            // actionsBindingSource
            // 
            this.actionsBindingSource.DataMember = "Actions";
            this.actionsBindingSource.DataSource = this.ambulanceDataSet;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(16, 38);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(88, 32);
            this.Number.TabIndex = 6;
            this.Number.Text = "Номер";
            // 
            // number_b
            // 
            this.number_b.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_b.Location = new System.Drawing.Point(22, 62);
            this.number_b.Name = "number_b";
            this.number_b.Size = new System.Drawing.Size(140, 39);
            this.number_b.TabIndex = 0;
            this.number_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_b_KeyPress);
            // 
            // add_b
            // 
            this.add_b.BackColor = System.Drawing.Color.Red;
            this.add_b.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_b.ForeColor = System.Drawing.Color.White;
            this.add_b.Location = new System.Drawing.Point(170, 251);
            this.add_b.Name = "add_b";
            this.add_b.Size = new System.Drawing.Size(100, 46);
            this.add_b.TabIndex = 1;
            this.add_b.Text = "Добавить";
            this.add_b.UseVisualStyleBackColor = false;
            this.add_b.Click += new System.EventHandler(this.add_b_Click);
            // 
            // Actions
            // 
            this.Actions.AutoSize = true;
            this.Actions.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Actions.Location = new System.Drawing.Point(18, 180);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(122, 32);
            this.Actions.TabIndex = 10;
            this.Actions.Text = "Действия";
            // 
            // calls
            // 
            this.calls.Controls.Add(this.dateTimePicker2);
            this.calls.Controls.Add(this.dateTimePicker1);
            this.calls.Controls.Add(this.brig_t);
            this.calls.Controls.Add(this.pat_t);
            this.calls.Controls.Add(this.label8);
            this.calls.Controls.Add(this.label9);
            this.calls.Controls.Add(this.button_calls);
            this.calls.Controls.Add(this.label10);
            this.calls.Controls.Add(this.label11);
            this.calls.Controls.Add(this.label12);
            this.calls.Controls.Add(this.address_t);
            this.calls.Location = new System.Drawing.Point(17, 172);
            this.calls.Name = "calls";
            this.calls.Size = new System.Drawing.Size(538, 303);
            this.calls.TabIndex = 15;
            this.calls.TabStop = false;
            this.calls.Text = "Звонки";
            this.calls.Visible = false;
            // 
            // brig_t
            // 
            this.brig_t.DataSource = this.brigadesBindingSource;
            this.brig_t.DisplayMember = "Number";
            this.brig_t.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brig_t.FormattingEnabled = true;
            this.brig_t.Location = new System.Drawing.Point(13, 177);
            this.brig_t.Name = "brig_t";
            this.brig_t.Size = new System.Drawing.Size(160, 41);
            this.brig_t.TabIndex = 12;
            // 
            // brigadesBindingSource
            // 
            this.brigadesBindingSource.DataMember = "Brigades";
            this.brigadesBindingSource.DataSource = this.ambulanceDataSet;
            // 
            // pat_t
            // 
            this.pat_t.DataSource = this.patientsBindingSource1;
            this.pat_t.DisplayMember = "ID";
            this.pat_t.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pat_t.FormattingEnabled = true;
            this.pat_t.Location = new System.Drawing.Point(225, 177);
            this.pat_t.Name = "pat_t";
            this.pat_t.Size = new System.Drawing.Size(194, 41);
            this.pat_t.TabIndex = 11;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "Patients";
            this.patientsBindingSource1.DataSource = this.ambulanceDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Время";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(171, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Дата";
            // 
            // button_calls
            // 
            this.button_calls.BackColor = System.Drawing.Color.Red;
            this.button_calls.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_calls.ForeColor = System.Drawing.Color.White;
            this.button_calls.Location = new System.Drawing.Point(164, 238);
            this.button_calls.Name = "button_calls";
            this.button_calls.Size = new System.Drawing.Size(140, 46);
            this.button_calls.TabIndex = 1;
            this.button_calls.Text = "Добавить";
            this.button_calls.UseVisualStyleBackColor = false;
            this.button_calls.Click += new System.EventHandler(this.button_calls_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(223, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "Пациент";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(402, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 32);
            this.label11.TabIndex = 8;
            this.label11.Text = "Адрес";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 32);
            this.label12.TabIndex = 9;
            this.label12.Text = "Номер бригады";
            // 
            // address_t
            // 
            this.address_t.Location = new System.Drawing.Point(384, 131);
            this.address_t.Name = "address_t";
            this.address_t.Size = new System.Drawing.Size(139, 39);
            this.address_t.TabIndex = 4;
            // 
            // fKCallsPatientsBindingSource
            // 
            this.fKCallsPatientsBindingSource.DataMember = "FK_Calls_Patients";
            this.fKCallsPatientsBindingSource.DataSource = this.patientsBindingSource;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.ambulanceDataSet;
            // 
            // brigadesTableAdapter
            // 
            this.brigadesTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // callsTableAdapter
            // 
            this.callsTableAdapter.ClearBeforeFill = true;
            // 
            // specializationsTableAdapter
            // 
            this.specializationsTableAdapter.ClearBeforeFill = true;
            // 
            // actionsTableAdapter
            // 
            this.actionsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 39);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(164, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(232, 39);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(15, 177);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 39);
            this.dateTimePicker3.TabIndex = 12;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.calls);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.act);
            this.Controls.Add(this.patien);
            this.Controls.Add(this.brigad);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.patien.ResumeLayout(false);
            this.patien.PerformLayout();
            this.spec.ResumeLayout(false);
            this.spec.PerformLayout();
            this.act.ResumeLayout(false);
            this.act.PerformLayout();
            this.brigad.ResumeLayout(false);
            this.brigad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBindingSource)).EndInit();
            this.calls.ResumeLayout(false);
            this.calls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brigadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCallsPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox surname_t;
        private System.Windows.Forms.Button add_p;
        private System.Windows.Forms.TextBox lastname_t;
        private System.Windows.Forms.TextBox name_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox patien;
        private System.Windows.Forms.ComboBox sex_t;
        private System.Windows.Forms.GroupBox brigad;
        private System.Windows.Forms.ComboBox spec_b;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.ComboBox act_b;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox number_b;
        private System.Windows.Forms.Button add_b;
        private System.Windows.Forms.Label Actions;
        private System.Windows.Forms.GroupBox act;
        private System.Windows.Forms.TextBox actions_t;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox spec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_spec;
        private System.Windows.Forms.TextBox spec_t;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_actions;
        private System.Windows.Forms.GroupBox calls;
        private System.Windows.Forms.ComboBox brig_t;
        private System.Windows.Forms.ComboBox pat_t;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_calls;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox address_t;
        private ambulanceDataSet ambulanceDataSet;
        private System.Windows.Forms.BindingSource brigadesBindingSource;
        private ambulanceDataSetTableAdapters.BrigadesTableAdapter brigadesTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private ambulanceDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource fKCallsPatientsBindingSource;
        private ambulanceDataSetTableAdapters.CallsTableAdapter callsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private System.Windows.Forms.BindingSource specializationsBindingSource;
        private ambulanceDataSetTableAdapters.SpecializationsTableAdapter specializationsTableAdapter;
        private System.Windows.Forms.BindingSource actionsBindingSource;
        private ambulanceDataSetTableAdapters.ActionsTableAdapter actionsTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}