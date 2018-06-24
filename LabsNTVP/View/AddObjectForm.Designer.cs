namespace View
{
    partial class AddObjectForm
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
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelType = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox1 = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.WorkMonthLabel = new System.Windows.Forms.Label();
            this.SalaryGroupBox = new System.Windows.Forms.GroupBox();
            this.HourLabel = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.HourTextBox = new System.Windows.Forms.TextBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.WorkDayTextBox = new System.Windows.Forms.TextBox();
            this.VacationDaysTextBox1 = new System.Windows.Forms.TextBox();
            this.SurnameLabel1 = new System.Windows.Forms.Label();
            this.VacationDaysLabel1 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.ButtonRandomPerson = new System.Windows.Forms.Button();
            this.HourlyGroupBox = new System.Windows.Forms.GroupBox();
            this.SurnameLabel2 = new System.Windows.Forms.Label();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.VacationDaysLabel2 = new System.Windows.Forms.Label();
            this.SurnameTextBox2 = new System.Windows.Forms.TextBox();
            this.NameTextBox2 = new System.Windows.Forms.TextBox();
            this.VacationDaysTextBox2 = new System.Windows.Forms.TextBox();
            this.SalaryGroupBox.SuspendLayout();
            this.HourlyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "По ставке",
            "По часовая"});
            this.ComboBoxType.Location = new System.Drawing.Point(29, 25);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxType.TabIndex = 0;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(75, 213);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(181, 213);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(26, 9);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(117, 13);
            this.LabelType.TabIndex = 3;
            this.LabelType.Text = "Выберите тип оплаты";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(6, 73);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(43, 13);
            this.SalaryLabel.TabIndex = 4;
            this.SalaryLabel.Text = "Ставка";
            // 
            // SurnameTextBox1
            // 
            this.SurnameTextBox1.Location = new System.Drawing.Point(158, 18);
            this.SurnameTextBox1.Name = "SurnameTextBox1";
            this.SurnameTextBox1.Size = new System.Drawing.Size(121, 20);
            this.SurnameTextBox1.TabIndex = 5;
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(158, 44);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(121, 20);
            this.NameTextBox1.TabIndex = 6;
            // 
            // WorkMonthLabel
            // 
            this.WorkMonthLabel.AutoSize = true;
            this.WorkMonthLabel.Location = new System.Drawing.Point(6, 73);
            this.WorkMonthLabel.Name = "WorkMonthLabel";
            this.WorkMonthLabel.Size = new System.Drawing.Size(144, 13);
            this.WorkMonthLabel.TabIndex = 7;
            this.WorkMonthLabel.Text = "Отработано дней в месяце";
            // 
            // SalaryGroupBox
            // 
            this.SalaryGroupBox.Controls.Add(this.RateLabel);
            this.SalaryGroupBox.Controls.Add(this.NameLabel1);
            this.SalaryGroupBox.Controls.Add(this.RateTextBox);
            this.SalaryGroupBox.Controls.Add(this.VacationDaysTextBox1);
            this.SalaryGroupBox.Controls.Add(this.SurnameLabel1);
            this.SalaryGroupBox.Controls.Add(this.VacationDaysLabel1);
            this.SalaryGroupBox.Controls.Add(this.SalaryTextBox);
            this.SalaryGroupBox.Controls.Add(this.NameTextBox1);
            this.SalaryGroupBox.Controls.Add(this.SalaryLabel);
            this.SalaryGroupBox.Controls.Add(this.SurnameTextBox1);
            this.SalaryGroupBox.Location = new System.Drawing.Point(23, 52);
            this.SalaryGroupBox.Name = "SalaryGroupBox";
            this.SalaryGroupBox.Size = new System.Drawing.Size(300, 155);
            this.SalaryGroupBox.TabIndex = 8;
            this.SalaryGroupBox.TabStop = false;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(6, 99);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(109, 13);
            this.HourLabel.TabIndex = 16;
            this.HourLabel.Text = "Кол-во часов в день";
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(6, 99);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(69, 13);
            this.RateLabel.TabIndex = 14;
            this.RateLabel.Text = "Коэфициент";
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Location = new System.Drawing.Point(6, 47);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(29, 13);
            this.NameLabel1.TabIndex = 11;
            this.NameLabel1.Text = "Имя";
            // 
            // HourTextBox
            // 
            this.HourTextBox.Location = new System.Drawing.Point(158, 96);
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(121, 20);
            this.HourTextBox.TabIndex = 9;
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(158, 96);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(121, 20);
            this.RateTextBox.TabIndex = 15;
            // 
            // WorkDayTextBox
            // 
            this.WorkDayTextBox.Location = new System.Drawing.Point(158, 70);
            this.WorkDayTextBox.Name = "WorkDayTextBox";
            this.WorkDayTextBox.Size = new System.Drawing.Size(121, 20);
            this.WorkDayTextBox.TabIndex = 13;
            // 
            // VacationDaysTextBox1
            // 
            this.VacationDaysTextBox1.Location = new System.Drawing.Point(158, 122);
            this.VacationDaysTextBox1.Name = "VacationDaysTextBox1";
            this.VacationDaysTextBox1.Size = new System.Drawing.Size(121, 20);
            this.VacationDaysTextBox1.TabIndex = 12;
            // 
            // SurnameLabel1
            // 
            this.SurnameLabel1.AutoSize = true;
            this.SurnameLabel1.Location = new System.Drawing.Point(6, 21);
            this.SurnameLabel1.Name = "SurnameLabel1";
            this.SurnameLabel1.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel1.TabIndex = 10;
            this.SurnameLabel1.Text = "Фамилия";
            // 
            // VacationDaysLabel1
            // 
            this.VacationDaysLabel1.AutoSize = true;
            this.VacationDaysLabel1.Location = new System.Drawing.Point(6, 125);
            this.VacationDaysLabel1.Name = "VacationDaysLabel1";
            this.VacationDaysLabel1.Size = new System.Drawing.Size(120, 13);
            this.VacationDaysLabel1.TabIndex = 9;
            this.VacationDaysLabel1.Text = "Кол-во дней в отпуске";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(158, 70);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(121, 20);
            this.SalaryTextBox.TabIndex = 8;
            // 
            // ButtonRandomPerson
            // 
            this.ButtonRandomPerson.Location = new System.Drawing.Point(181, 25);
            this.ButtonRandomPerson.Name = "ButtonRandomPerson";
            this.ButtonRandomPerson.Size = new System.Drawing.Size(95, 21);
            this.ButtonRandomPerson.TabIndex = 9;
            this.ButtonRandomPerson.Text = "Random";
            this.ButtonRandomPerson.UseVisualStyleBackColor = true;
            this.ButtonRandomPerson.Click += new System.EventHandler(this.ButtonRandomPerson_Click);
            // 
            // HourlyGroupBox
            // 
            this.HourlyGroupBox.Controls.Add(this.VacationDaysTextBox2);
            this.HourlyGroupBox.Controls.Add(this.NameTextBox2);
            this.HourlyGroupBox.Controls.Add(this.SurnameTextBox2);
            this.HourlyGroupBox.Controls.Add(this.SurnameLabel2);
            this.HourlyGroupBox.Controls.Add(this.NameLabel2);
            this.HourlyGroupBox.Controls.Add(this.VacationDaysLabel2);
            this.HourlyGroupBox.Controls.Add(this.HourLabel);
            this.HourlyGroupBox.Controls.Add(this.WorkMonthLabel);
            this.HourlyGroupBox.Controls.Add(this.HourTextBox);
            this.HourlyGroupBox.Controls.Add(this.WorkDayTextBox);
            this.HourlyGroupBox.Location = new System.Drawing.Point(329, 52);
            this.HourlyGroupBox.Name = "HourlyGroupBox";
            this.HourlyGroupBox.Size = new System.Drawing.Size(300, 155);
            this.HourlyGroupBox.TabIndex = 10;
            this.HourlyGroupBox.TabStop = false;
            this.HourlyGroupBox.Text = " ";
            // 
            // SurnameLabel2
            // 
            this.SurnameLabel2.AutoSize = true;
            this.SurnameLabel2.Location = new System.Drawing.Point(6, 21);
            this.SurnameLabel2.Name = "SurnameLabel2";
            this.SurnameLabel2.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel2.TabIndex = 16;
            this.SurnameLabel2.Text = "Фамилия";
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Location = new System.Drawing.Point(6, 47);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(29, 13);
            this.NameLabel2.TabIndex = 17;
            this.NameLabel2.Text = "Имя";
            // 
            // VacationDaysLabel2
            // 
            this.VacationDaysLabel2.AutoSize = true;
            this.VacationDaysLabel2.Location = new System.Drawing.Point(6, 125);
            this.VacationDaysLabel2.Name = "VacationDaysLabel2";
            this.VacationDaysLabel2.Size = new System.Drawing.Size(120, 13);
            this.VacationDaysLabel2.TabIndex = 18;
            this.VacationDaysLabel2.Text = "Кол-во дней в отпуске";
            // 
            // SurnameTextBox2
            // 
            this.SurnameTextBox2.Location = new System.Drawing.Point(158, 18);
            this.SurnameTextBox2.Name = "SurnameTextBox2";
            this.SurnameTextBox2.Size = new System.Drawing.Size(121, 20);
            this.SurnameTextBox2.TabIndex = 19;
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Location = new System.Drawing.Point(158, 44);
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(121, 20);
            this.NameTextBox2.TabIndex = 20;
            // 
            // VacationDaysTextBox2
            // 
            this.VacationDaysTextBox2.Location = new System.Drawing.Point(158, 122);
            this.VacationDaysTextBox2.Name = "VacationDaysTextBox2";
            this.VacationDaysTextBox2.Size = new System.Drawing.Size(121, 20);
            this.VacationDaysTextBox2.TabIndex = 21;
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 246);
            this.Controls.Add(this.HourlyGroupBox);
            this.Controls.Add(this.ButtonRandomPerson);
            this.Controls.Add(this.SalaryGroupBox);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonClose);
            this.Name = "AddObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddObjectForm";
            this.SalaryGroupBox.ResumeLayout(false);
            this.SalaryGroupBox.PerformLayout();
            this.HourlyGroupBox.ResumeLayout(false);
            this.HourlyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox SurnameTextBox1;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.Label WorkMonthLabel;
        private System.Windows.Forms.GroupBox SalaryGroupBox;
        private System.Windows.Forms.Label VacationDaysLabel1;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox WorkDayTextBox;
        private System.Windows.Forms.TextBox VacationDaysTextBox1;
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.Label SurnameLabel1;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.TextBox HourTextBox;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Button ButtonRandomPerson;
        private System.Windows.Forms.GroupBox HourlyGroupBox;
        private System.Windows.Forms.TextBox VacationDaysTextBox2;
        private System.Windows.Forms.TextBox NameTextBox2;
        private System.Windows.Forms.TextBox SurnameTextBox2;
        private System.Windows.Forms.Label SurnameLabel2;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.Label VacationDaysLabel2;
    }
}