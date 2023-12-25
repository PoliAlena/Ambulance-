namespace Ambulance
{
    partial class Directories
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
            this.datab = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patien = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sex_t = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.surname_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_t = new System.Windows.Forms.TextBox();
            this.add_p = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastname_t = new System.Windows.Forms.TextBox();
            this.brigad = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.specializationsTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.SpecializationsTableAdapter();
            this.actionsTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.ActionsTableAdapter();
            this.spec = new System.Windows.Forms.GroupBox();
            this.button_spec = new System.Windows.Forms.Button();
            this.spec_t = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.act = new System.Windows.Forms.GroupBox();
            this.button_actions = new System.Windows.Forms.Button();
            this.actions_t = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.datab)).BeginInit();
            this.delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.patien.SuspendLayout();
            this.brigad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBindingSource)).BeginInit();
            this.spec.SuspendLayout();
            this.act.SuspendLayout();
            this.SuspendLayout();
            // 
            // datab
            // 
            this.datab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datab.Location = new System.Drawing.Point(26, 208);
            this.datab.Name = "datab";
            this.datab.RowHeadersWidth = 62;
            this.datab.RowTemplate.Height = 28;
            this.datab.Size = new System.Drawing.Size(1245, 242);
            this.datab.TabIndex = 0;
            this.datab.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datab_CellDoubleClick);
            this.datab.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datab_DataBindingComplete);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Бригады",
            "Пациенты",
            "Действия",
            "Специализации"});
            this.comboBox1.Location = new System.Drawing.Point(21, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 39);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Выберите справочник";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(340, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вывести данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.AllowDrop = true;
            this.delete.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.delete.Name = "contextMenuStrip1";
            this.delete.Size = new System.Drawing.Size(149, 36);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.BackgroundImage = global::Ambulance.Properties.Resources.х;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(1204, 12);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(70, 72);
            this.Exit.TabIndex = 5;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ambulance.Properties.Resources.Lovepik_com_400214670_red_cross_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // patien
            // 
            this.patien.Controls.Add(this.dateTimePicker1);
            this.patien.Controls.Add(this.button3);
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
            this.patien.Location = new System.Drawing.Point(402, 106);
            this.patien.Name = "patien";
            this.patien.Size = new System.Drawing.Size(482, 303);
            this.patien.TabIndex = 15;
            this.patien.TabStop = false;
            this.patien.Text = "Пациенты";
            this.patien.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Ambulance.Properties.Resources.х;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(423, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 43);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sex_t
            // 
            this.sex_t.FormattingEnabled = true;
            this.sex_t.Items.AddRange(new object[] {
            "Ж",
            "М"});
            this.sex_t.Location = new System.Drawing.Point(235, 177);
            this.sex_t.Name = "sex_t";
            this.sex_t.Size = new System.Drawing.Size(66, 28);
            this.sex_t.TabIndex = 11;
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
            // surname_t
            // 
            this.surname_t.Location = new System.Drawing.Point(15, 100);
            this.surname_t.Name = "surname_t";
            this.surname_t.Size = new System.Drawing.Size(140, 26);
            this.surname_t.TabIndex = 0;
            this.surname_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_t_KeyPress);
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
            // name_t
            // 
            this.name_t.Location = new System.Drawing.Point(174, 100);
            this.name_t.Name = "name_t";
            this.name_t.Size = new System.Drawing.Size(127, 26);
            this.name_t.TabIndex = 5;
            this.name_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_t_KeyPress);
            // 
            // add_p
            // 
            this.add_p.BackColor = System.Drawing.Color.Red;
            this.add_p.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_p.ForeColor = System.Drawing.Color.White;
            this.add_p.Location = new System.Drawing.Point(164, 238);
            this.add_p.Name = "add_p";
            this.add_p.Size = new System.Drawing.Size(156, 46);
            this.add_p.TabIndex = 1;
            this.add_p.Text = "Изменить";
            this.add_p.UseVisualStyleBackColor = false;
            this.add_p.Click += new System.EventHandler(this.add_p_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(232, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пол";
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
            // lastname_t
            // 
            this.lastname_t.Location = new System.Drawing.Point(324, 100);
            this.lastname_t.Name = "lastname_t";
            this.lastname_t.Size = new System.Drawing.Size(139, 26);
            this.lastname_t.TabIndex = 4;
            this.lastname_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastname_t_KeyPress);
            // 
            // brigad
            // 
            this.brigad.Controls.Add(this.button2);
            this.brigad.Controls.Add(this.spec_b);
            this.brigad.Controls.Add(this.Specialization);
            this.brigad.Controls.Add(this.act_b);
            this.brigad.Controls.Add(this.Number);
            this.brigad.Controls.Add(this.number_b);
            this.brigad.Controls.Add(this.add_b);
            this.brigad.Controls.Add(this.Actions);
            this.brigad.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brigad.Location = new System.Drawing.Point(396, 48);
            this.brigad.Name = "brigad";
            this.brigad.Size = new System.Drawing.Size(482, 302);
            this.brigad.TabIndex = 16;
            this.brigad.TabStop = false;
            this.brigad.Text = "Бригады";
            this.brigad.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::Ambulance.Properties.Resources.х;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(415, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 54);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // spec_b
            // 
            this.spec_b.DataSource = this.specializationsBindingSource;
            this.spec_b.DisplayMember = "Title";
            this.spec_b.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spec_b.FormattingEnabled = true;
            this.spec_b.Location = new System.Drawing.Point(20, 141);
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
            this.act_b.Location = new System.Drawing.Point(22, 210);
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
            this.number_b.Location = new System.Drawing.Point(22, 73);
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
            this.add_b.Location = new System.Drawing.Point(160, 256);
            this.add_b.Name = "add_b";
            this.add_b.Size = new System.Drawing.Size(141, 46);
            this.add_b.TabIndex = 1;
            this.add_b.Text = "Изменить";
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::Ambulance.Properties.Resources.х;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(391, 19);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 44);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::Ambulance.Properties.Resources.х;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(401, 13);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 54);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // specializationsTableAdapter
            // 
            this.specializationsTableAdapter.ClearBeforeFill = true;
            // 
            // actionsTableAdapter
            // 
            this.actionsTableAdapter.ClearBeforeFill = true;
            // 
            // spec
            // 
            this.spec.Controls.Add(this.button_spec);
            this.spec.Controls.Add(this.button5);
            this.spec.Controls.Add(this.spec_t);
            this.spec.Controls.Add(this.label6);
            this.spec.Controls.Add(this.label7);
            this.spec.Location = new System.Drawing.Point(371, 104);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(466, 252);
            this.spec.TabIndex = 19;
            this.spec.TabStop = false;
            this.spec.Text = "Специализация";
            this.spec.Visible = false;
            // 
            // button_spec
            // 
            this.button_spec.BackColor = System.Drawing.Color.Red;
            this.button_spec.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_spec.ForeColor = System.Drawing.Color.White;
            this.button_spec.Location = new System.Drawing.Point(135, 190);
            this.button_spec.Name = "button_spec";
            this.button_spec.Size = new System.Drawing.Size(131, 41);
            this.button_spec.TabIndex = 17;
            this.button_spec.Text = "Изменить";
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
            this.label6.Size = new System.Drawing.Size(0, 20);
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
            this.act.Controls.Add(this.button4);
            this.act.Controls.Add(this.button_actions);
            this.act.Controls.Add(this.actions_t);
            this.act.Controls.Add(this.label13);
            this.act.Location = new System.Drawing.Point(389, 72);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(448, 246);
            this.act.TabIndex = 20;
            this.act.TabStop = false;
            this.act.Text = "Действия";
            this.act.Visible = false;
            // 
            // button_actions
            // 
            this.button_actions.BackColor = System.Drawing.Color.Red;
            this.button_actions.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_actions.ForeColor = System.Drawing.Color.White;
            this.button_actions.Location = new System.Drawing.Point(143, 190);
            this.button_actions.Name = "button_actions";
            this.button_actions.Size = new System.Drawing.Size(141, 38);
            this.button_actions.TabIndex = 17;
            this.button_actions.Text = "Изменить";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Directories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 515);
            this.Controls.Add(this.patien);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.datab);
            this.Controls.Add(this.brigad);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.act);
            this.Name = "Directories";
            this.Text = "Directories";
            this.Load += new System.EventHandler(this.Directories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datab)).EndInit();
            this.delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.patien.ResumeLayout(false);
            this.patien.PerformLayout();
            this.brigad.ResumeLayout(false);
            this.brigad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsBindingSource)).EndInit();
            this.spec.ResumeLayout(false);
            this.spec.PerformLayout();
            this.act.ResumeLayout(false);
            this.act.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datab;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ContextMenuStrip delete;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox patien;
        private System.Windows.Forms.ComboBox sex_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_t;
        private System.Windows.Forms.Button add_p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastname_t;
        private System.Windows.Forms.GroupBox brigad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox spec_b;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.ComboBox act_b;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox number_b;
        private System.Windows.Forms.Button add_b;
        private System.Windows.Forms.Label Actions;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private ambulanceDataSet ambulanceDataSet;
        private System.Windows.Forms.BindingSource specializationsBindingSource;
        private ambulanceDataSetTableAdapters.SpecializationsTableAdapter specializationsTableAdapter;
        private System.Windows.Forms.BindingSource actionsBindingSource;
        private ambulanceDataSetTableAdapters.ActionsTableAdapter actionsTableAdapter;
        private System.Windows.Forms.GroupBox spec;
        private System.Windows.Forms.Button button_spec;
        private System.Windows.Forms.TextBox spec_t;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox act;
        private System.Windows.Forms.Button button_actions;
        private System.Windows.Forms.TextBox actions_t;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}