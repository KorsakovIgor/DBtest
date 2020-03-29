namespace DBtest
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_employ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_unemploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statDataGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.statComboBox = new System.Windows.Forms.ComboBox();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(145, 25);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 510);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.restartButton);
            this.tabPage1.Controls.Add(this.staffDataGridView);
            this.tabPage1.Controls.Add(this.SearchButton);
            this.tabPage1.Controls.Add(this.statusComboBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.postComboBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.depComboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.secondNameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список сотрудников";
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AllowUserToAddRows = false;
            this.staffDataGridView.AllowUserToDeleteRows = false;
            this.staffDataGridView.AllowUserToResizeColumns = false;
            this.staffDataGridView.AllowUserToResizeRows = false;
            this.staffDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Status_name,
            this.dep_name,
            this.post_name,
            this.date_employ,
            this.date_unemploy});
            this.staffDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.staffDataGridView.Location = new System.Drawing.Point(10, 107);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.ReadOnly = true;
            this.staffDataGridView.RowHeadersVisible = false;
            this.staffDataGridView.RowHeadersWidth = 4;
            this.staffDataGridView.RowTemplate.ReadOnly = true;
            this.staffDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.staffDataGridView.Size = new System.Drawing.Size(998, 364);
            this.staffDataGridView.TabIndex = 9;
            // 
            // FIO
            // 
            this.FIO.Frozen = true;
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 200;
            // 
            // Status_name
            // 
            this.Status_name.Frozen = true;
            this.Status_name.HeaderText = "Статус";
            this.Status_name.Name = "Status_name";
            this.Status_name.ReadOnly = true;
            this.Status_name.Width = 159;
            // 
            // dep_name
            // 
            this.dep_name.Frozen = true;
            this.dep_name.HeaderText = "Отдел";
            this.dep_name.Name = "dep_name";
            this.dep_name.ReadOnly = true;
            this.dep_name.Width = 159;
            // 
            // post_name
            // 
            this.post_name.Frozen = true;
            this.post_name.HeaderText = "Должность";
            this.post_name.Name = "post_name";
            this.post_name.ReadOnly = true;
            this.post_name.Width = 159;
            // 
            // date_employ
            // 
            this.date_employ.Frozen = true;
            this.date_employ.HeaderText = "Дата приема";
            this.date_employ.Name = "date_employ";
            this.date_employ.ReadOnly = true;
            this.date_employ.Width = 159;
            // 
            // date_unemploy
            // 
            this.date_unemploy.Frozen = true;
            this.date_unemploy.HeaderText = "Дата увольнения";
            this.date_unemploy.Name = "date_unemploy";
            this.date_unemploy.ReadOnly = true;
            this.date_unemploy.Width = 159;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(897, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 24);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownWidth = 200;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(737, 22);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(111, 24);
            this.statusComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Статус";
            // 
            // postComboBox
            // 
            this.postComboBox.DropDownWidth = 200;
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Location = new System.Drawing.Point(531, 22);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(111, 24);
            this.postComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Должность:";
            // 
            // depComboBox
            // 
            this.depComboBox.DropDownWidth = 200;
            this.depComboBox.FormattingEnabled = true;
            this.depComboBox.Location = new System.Drawing.Point(291, 22);
            this.depComboBox.Name = "depComboBox";
            this.depComboBox.Size = new System.Drawing.Size(111, 24);
            this.depComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отдел:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(83, 22);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(111, 22);
            this.secondNameTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.statButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.endDateTimePicker);
            this.tabPage2.Controls.Add(this.beginDateTimePicker);
            this.tabPage2.Controls.Add(this.statComboBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.statDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика";
            // 
            // statDataGridView
            // 
            this.statDataGridView.AllowUserToAddRows = false;
            this.statDataGridView.AllowUserToDeleteRows = false;
            this.statDataGridView.AllowUserToResizeColumns = false;
            this.statDataGridView.AllowUserToResizeRows = false;
            this.statDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.statDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.StaffCount});
            this.statDataGridView.Location = new System.Drawing.Point(6, 6);
            this.statDataGridView.Name = "statDataGridView";
            this.statDataGridView.ReadOnly = true;
            this.statDataGridView.RowHeadersVisible = false;
            this.statDataGridView.RowHeadersWidth = 5;
            this.statDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statDataGridView.Size = new System.Drawing.Size(340, 465);
            this.statDataGridView.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 170;
            // 
            // StaffCount
            // 
            this.StaffCount.Frozen = true;
            this.StaffCount.HeaderText = "Кол-во сотрудников";
            this.StaffCount.Name = "StaffCount";
            this.StaffCount.ReadOnly = true;
            this.StaffCount.Width = 170;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Статус:";
            // 
            // statComboBox
            // 
            this.statComboBox.FormattingEnabled = true;
            this.statComboBox.Location = new System.Drawing.Point(585, 6);
            this.statComboBox.Name = "statComboBox";
            this.statComboBox.Size = new System.Drawing.Size(174, 24);
            this.statComboBox.TabIndex = 2;
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.Location = new System.Drawing.Point(484, 74);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(170, 22);
            this.beginDateTimePicker.TabIndex = 3;
            this.beginDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(683, 74);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(170, 22);
            this.endDateTimePicker.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Период:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "—";
            // 
            // statButton
            // 
            this.statButton.Location = new System.Drawing.Point(612, 159);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(121, 41);
            this.statButton.TabIndex = 7;
            this.statButton.Text = "Показать статистику";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(897, 67);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(111, 23);
            this.restartButton.TabIndex = 10;
            this.restartButton.Text = "Сброс";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1075, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Сотрудники";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox postComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox depComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn post_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_employ;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_unemploy;
        private System.Windows.Forms.DataGridView statDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffCount;
        private System.Windows.Forms.Button statButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.ComboBox statComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restartButton;
    }
}

