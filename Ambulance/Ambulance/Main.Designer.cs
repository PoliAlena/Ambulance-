namespace Ambulance
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.datab = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brigadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulanceDataSet = new Ambulance.ambulanceDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brigadesTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.BrigadesTableAdapter();
            this.patientsTableAdapter = new Ambulance.ambulanceDataSetTableAdapters.PatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brigadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datab
            // 
            this.datab.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datab.Location = new System.Drawing.Point(18, 206);
            this.datab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datab.Name = "datab";
            this.datab.RowHeadersWidth = 62;
            this.datab.Size = new System.Drawing.Size(1558, 648);
            this.datab.TabIndex = 0;
            this.datab.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datab_DataBindingComplete);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Red;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Location = new System.Drawing.Point(1390, 140);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(186, 57);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(457, 140);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "Запросы";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // directory
            // 
            this.directory.BackColor = System.Drawing.Color.Red;
            this.directory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.directory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directory.ForeColor = System.Drawing.Color.White;
            this.directory.Location = new System.Drawing.Point(218, 140);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(194, 58);
            this.directory.TabIndex = 7;
            this.directory.Text = "Справочники";
            this.directory.UseVisualStyleBackColor = false;
            this.directory.Click += new System.EventHandler(this.directory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ambulance.Properties.Resources.Lovepik_com_400214670_red_cross_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 177);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.BackgroundImage = global::Ambulance.Properties.Resources.х;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(1506, 20);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(70, 72);
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
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
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click_1);
            // 
            // brigadesBindingSource
            // 
            this.brigadesBindingSource.DataMember = "Brigades";
            this.brigadesBindingSource.DataSource = this.ambulanceDataSet;
            // 
            // ambulanceDataSet
            // 
            this.ambulanceDataSet.DataSetName = "ambulanceDataSet";
            this.ambulanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1878, 872);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.datab);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brigadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datab;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button directory;
        private System.Windows.Forms.ContextMenuStrip delete;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private ambulanceDataSet ambulanceDataSet;
        private System.Windows.Forms.BindingSource brigadesBindingSource;
        private ambulanceDataSetTableAdapters.BrigadesTableAdapter brigadesTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private ambulanceDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
    }
}

