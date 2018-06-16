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
            this.LabelSalary = new System.Windows.Forms.Label();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelWorkMonth = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelHour = new System.Windows.Forms.Label();
            this.LabelRate = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxHour = new System.Windows.Forms.TextBox();
            this.TextBoxRate = new System.Windows.Forms.TextBox();
            this.TextBoxWorkDay = new System.Windows.Forms.TextBox();
            this.TextBoxVacationDays = new System.Windows.Forms.TextBox();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.LabelVacationDays = new System.Windows.Forms.Label();
            this.TextBoxSalary = new System.Windows.Forms.TextBox();
            this.ButtonRandomPerson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "По ставке",
            "По часовая"});
            this.ComboBoxType.Location = new System.Drawing.Point(23, 60);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxType.TabIndex = 0;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(46, 209);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(162, 209);
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
            this.LabelType.Location = new System.Drawing.Point(26, 35);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(117, 13);
            this.LabelType.TabIndex = 3;
            this.LabelType.Text = "Выберите тип оплаты";
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.Location = new System.Drawing.Point(6, 62);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(43, 13);
            this.LabelSalary.TabIndex = 4;
            this.LabelSalary.Text = "Ставка";
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(2, 37);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(121, 20);
            this.TextBoxSurname.TabIndex = 5;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(162, 37);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(121, 20);
            this.TextBoxName.TabIndex = 6;
            // 
            // LabelWorkMonth
            // 
            this.LabelWorkMonth.AutoSize = true;
            this.LabelWorkMonth.Location = new System.Drawing.Point(-1, 110);
            this.LabelWorkMonth.Name = "LabelWorkMonth";
            this.LabelWorkMonth.Size = new System.Drawing.Size(144, 13);
            this.LabelWorkMonth.TabIndex = 7;
            this.LabelWorkMonth.Text = "Отработано дней в месяце";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelHour);
            this.groupBox1.Controls.Add(this.LabelRate);
            this.groupBox1.Controls.Add(this.LabelName);
            this.groupBox1.Controls.Add(this.TextBoxHour);
            this.groupBox1.Controls.Add(this.TextBoxRate);
            this.groupBox1.Controls.Add(this.TextBoxWorkDay);
            this.groupBox1.Controls.Add(this.TextBoxVacationDays);
            this.groupBox1.Controls.Add(this.LabelSurname);
            this.groupBox1.Controls.Add(this.LabelVacationDays);
            this.groupBox1.Controls.Add(this.TextBoxSalary);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Controls.Add(this.ButtonClose);
            this.groupBox1.Controls.Add(this.LabelSalary);
            this.groupBox1.Controls.Add(this.ButtonAdd);
            this.groupBox1.Controls.Add(this.LabelWorkMonth);
            this.groupBox1.Controls.Add(this.TextBoxSurname);
            this.groupBox1.Location = new System.Drawing.Point(23, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 247);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // LabelHour
            // 
            this.LabelHour.AutoSize = true;
            this.LabelHour.Location = new System.Drawing.Point(3, 158);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.Size = new System.Drawing.Size(109, 13);
            this.LabelHour.TabIndex = 16;
            this.LabelHour.Text = "Кол-во часов в день";
            // 
            // LabelRate
            // 
            this.LabelRate.AutoSize = true;
            this.LabelRate.Location = new System.Drawing.Point(166, 62);
            this.LabelRate.Name = "LabelRate";
            this.LabelRate.Size = new System.Drawing.Size(69, 13);
            this.LabelRate.TabIndex = 14;
            this.LabelRate.Text = "Коэфициент";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(159, 21);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(85, 13);
            this.LabelName.TabIndex = 11;
            this.LabelName.Text = "Имя работника";
            // 
            // TextBoxHour
            // 
            this.TextBoxHour.Location = new System.Drawing.Point(0, 174);
            this.TextBoxHour.Name = "TextBoxHour";
            this.TextBoxHour.Size = new System.Drawing.Size(121, 20);
            this.TextBoxHour.TabIndex = 9;
            // 
            // TextBoxRate
            // 
            this.TextBoxRate.Location = new System.Drawing.Point(162, 78);
            this.TextBoxRate.Name = "TextBoxRate";
            this.TextBoxRate.Size = new System.Drawing.Size(121, 20);
            this.TextBoxRate.TabIndex = 15;
            // 
            // TextBoxWorkDay
            // 
            this.TextBoxWorkDay.Location = new System.Drawing.Point(2, 126);
            this.TextBoxWorkDay.Name = "TextBoxWorkDay";
            this.TextBoxWorkDay.Size = new System.Drawing.Size(121, 20);
            this.TextBoxWorkDay.TabIndex = 13;
            // 
            // TextBoxVacationDays
            // 
            this.TextBoxVacationDays.Location = new System.Drawing.Point(162, 126);
            this.TextBoxVacationDays.Name = "TextBoxVacationDays";
            this.TextBoxVacationDays.Size = new System.Drawing.Size(121, 20);
            this.TextBoxVacationDays.TabIndex = 12;
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(3, 21);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(112, 13);
            this.LabelSurname.TabIndex = 10;
            this.LabelSurname.Text = "Фамилия работника";
            // 
            // LabelVacationDays
            // 
            this.LabelVacationDays.AutoSize = true;
            this.LabelVacationDays.Location = new System.Drawing.Point(159, 110);
            this.LabelVacationDays.Name = "LabelVacationDays";
            this.LabelVacationDays.Size = new System.Drawing.Size(120, 13);
            this.LabelVacationDays.TabIndex = 9;
            this.LabelVacationDays.Text = "Кол-во дней в отпуске";
            // 
            // TextBoxSalary
            // 
            this.TextBoxSalary.Location = new System.Drawing.Point(2, 78);
            this.TextBoxSalary.Name = "TextBoxSalary";
            this.TextBoxSalary.Size = new System.Drawing.Size(121, 20);
            this.TextBoxSalary.TabIndex = 8;
            // 
            // ButtonRandomPerson
            // 
            this.ButtonRandomPerson.Location = new System.Drawing.Point(172, 35);
            this.ButtonRandomPerson.Name = "ButtonRandomPerson";
            this.ButtonRandomPerson.Size = new System.Drawing.Size(142, 46);
            this.ButtonRandomPerson.TabIndex = 9;
            this.ButtonRandomPerson.Text = "Добавить случайного сотрудника";
            this.ButtonRandomPerson.UseVisualStyleBackColor = true;
            this.ButtonRandomPerson.Click += new System.EventHandler(this.ButtonRandomPerson_Click);
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 346);
            this.Controls.Add(this.ButtonRandomPerson);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.LabelType);
            this.Name = "AddObjectForm";
            this.Text = "AddObjectForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelSalary;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelWorkMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelVacationDays;
        private System.Windows.Forms.TextBox TextBoxSalary;
        private System.Windows.Forms.TextBox TextBoxWorkDay;
        private System.Windows.Forms.TextBox TextBoxVacationDays;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.TextBox TextBoxRate;
        private System.Windows.Forms.Label LabelRate;
        private System.Windows.Forms.TextBox TextBoxHour;
        private System.Windows.Forms.Label LabelHour;
        private System.Windows.Forms.Button ButtonRandomPerson;
    }
}