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
            this.TextBoxRate = new System.Windows.Forms.TextBox();
            this.LabelRate = new System.Windows.Forms.Label();
            this.TextBoxWorkDay = new System.Windows.Forms.TextBox();
            this.TextBoxVacationDays = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.LabelVacationDays = new System.Windows.Forms.Label();
            this.TextBoxSalary = new System.Windows.Forms.TextBox();
            this.TextBoxHour = new System.Windows.Forms.TextBox();
            this.LabelHour = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "По ставке",
            "По часовая"});
            this.ComboBoxType.Location = new System.Drawing.Point(6, 43);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxType.TabIndex = 0;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(48, 278);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(169, 278);
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
            this.LabelType.Location = new System.Drawing.Point(6, 27);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(117, 13);
            this.LabelType.TabIndex = 3;
            this.LabelType.Text = "Выберите тип оплаты";
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.Location = new System.Drawing.Point(6, 127);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(43, 13);
            this.LabelSalary.TabIndex = 4;
            this.LabelSalary.Text = "Ставка";
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(6, 90);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(121, 20);
            this.TextBoxSurname.TabIndex = 5;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(165, 90);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(121, 20);
            this.TextBoxName.TabIndex = 6;
            // 
            // LabelWorkMonth
            // 
            this.LabelWorkMonth.AutoSize = true;
            this.LabelWorkMonth.Location = new System.Drawing.Point(6, 180);
            this.LabelWorkMonth.Name = "LabelWorkMonth";
            this.LabelWorkMonth.Size = new System.Drawing.Size(144, 13);
            this.LabelWorkMonth.TabIndex = 7;
            this.LabelWorkMonth.Text = "Отработано дней в месяце";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelHour);
            this.groupBox1.Controls.Add(this.TextBoxHour);
            this.groupBox1.Controls.Add(this.TextBoxRate);
            this.groupBox1.Controls.Add(this.LabelRate);
            this.groupBox1.Controls.Add(this.TextBoxWorkDay);
            this.groupBox1.Controls.Add(this.TextBoxVacationDays);
            this.groupBox1.Controls.Add(this.LabelName);
            this.groupBox1.Controls.Add(this.LabelSurname);
            this.groupBox1.Controls.Add(this.LabelVacationDays);
            this.groupBox1.Controls.Add(this.TextBoxSalary);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Controls.Add(this.ButtonClose);
            this.groupBox1.Controls.Add(this.LabelSalary);
            this.groupBox1.Controls.Add(this.ButtonAdd);
            this.groupBox1.Controls.Add(this.LabelWorkMonth);
            this.groupBox1.Controls.Add(this.TextBoxSurname);
            this.groupBox1.Controls.Add(this.ComboBoxType);
            this.groupBox1.Controls.Add(this.LabelType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 322);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // TextBoxRate
            // 
            this.TextBoxRate.Location = new System.Drawing.Point(165, 143);
            this.TextBoxRate.Name = "TextBoxRate";
            this.TextBoxRate.Size = new System.Drawing.Size(121, 20);
            this.TextBoxRate.TabIndex = 15;
            // 
            // LabelRate
            // 
            this.LabelRate.AutoSize = true;
            this.LabelRate.Location = new System.Drawing.Point(166, 127);
            this.LabelRate.Name = "LabelRate";
            this.LabelRate.Size = new System.Drawing.Size(69, 13);
            this.LabelRate.TabIndex = 14;
            this.LabelRate.Text = "Коэфициент";
            // 
            // TextBoxWorkDay
            // 
            this.TextBoxWorkDay.Location = new System.Drawing.Point(6, 196);
            this.TextBoxWorkDay.Name = "TextBoxWorkDay";
            this.TextBoxWorkDay.Size = new System.Drawing.Size(121, 20);
            this.TextBoxWorkDay.TabIndex = 13;
            // 
            // TextBoxVacationDays
            // 
            this.TextBoxVacationDays.Location = new System.Drawing.Point(165, 196);
            this.TextBoxVacationDays.Name = "TextBoxVacationDays";
            this.TextBoxVacationDays.Size = new System.Drawing.Size(121, 20);
            this.TextBoxVacationDays.TabIndex = 12;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(166, 72);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(85, 13);
            this.LabelName.TabIndex = 11;
            this.LabelName.Text = "Имя работника";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(5, 72);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(112, 13);
            this.LabelSurname.TabIndex = 10;
            this.LabelSurname.Text = "Фамилия работника";
            // 
            // LabelVacationDays
            // 
            this.LabelVacationDays.AutoSize = true;
            this.LabelVacationDays.Location = new System.Drawing.Point(166, 180);
            this.LabelVacationDays.Name = "LabelVacationDays";
            this.LabelVacationDays.Size = new System.Drawing.Size(120, 13);
            this.LabelVacationDays.TabIndex = 9;
            this.LabelVacationDays.Text = "Кол-во дней в отпуске";
            // 
            // TextBoxSalary
            // 
            this.TextBoxSalary.Location = new System.Drawing.Point(6, 143);
            this.TextBoxSalary.Name = "TextBoxSalary";
            this.TextBoxSalary.Size = new System.Drawing.Size(121, 20);
            this.TextBoxSalary.TabIndex = 8;
            // 
            // TextBoxHour
            // 
            this.TextBoxHour.Location = new System.Drawing.Point(6, 242);
            this.TextBoxHour.Name = "TextBoxHour";
            this.TextBoxHour.Size = new System.Drawing.Size(121, 20);
            this.TextBoxHour.TabIndex = 9;
            // 
            // LabelHour
            // 
            this.LabelHour.AutoSize = true;
            this.LabelHour.Location = new System.Drawing.Point(6, 226);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.Size = new System.Drawing.Size(109, 13);
            this.LabelHour.TabIndex = 16;
            this.LabelHour.Text = "Кол-во часов в день";
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 346);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddObjectForm";
            this.Text = "AddObjectForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}