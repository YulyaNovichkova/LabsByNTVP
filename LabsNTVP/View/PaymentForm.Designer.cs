namespace View
{
    partial class PaymentForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Зарплата = new System.Windows.Forms.GroupBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonRemoveObject = new System.Windows.Forms.Button();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Зарплата.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // Зарплата
            // 
            this.Зарплата.Controls.Add(this.ButtonSave);
            this.Зарплата.Controls.Add(this.ButtonOpen);
            this.Зарплата.Controls.Add(this.LabelSearch);
            this.Зарплата.Controls.Add(this.TextBoxSearch);
            this.Зарплата.Controls.Add(this.ButtonRemoveObject);
            this.Зарплата.Controls.Add(this.ButtonAddObject);
            this.Зарплата.Controls.Add(this.dataGridView1);
            this.Зарплата.Location = new System.Drawing.Point(22, 23);
            this.Зарплата.Name = "Зарплата";
            this.Зарплата.Size = new System.Drawing.Size(578, 278);
            this.Зарплата.TabIndex = 1;
            this.Зарплата.TabStop = false;
            this.Зарплата.Text = "Зарплаты";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(446, 209);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(102, 23);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(446, 238);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(102, 23);
            this.ButtonOpen.TabIndex = 8;
            this.ButtonOpen.Text = "Открыть";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(443, 67);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(117, 39);
            this.LabelSearch.TabIndex = 5;
            this.LabelSearch.Text = "Введите фамилию \r\nсотрудника, которого\r\nнужно найти:";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(446, 121);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(102, 20);
            this.TextBoxSearch.TabIndex = 7;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ButtonRemoveObject
            // 
            this.ButtonRemoveObject.Location = new System.Drawing.Point(446, 164);
            this.ButtonRemoveObject.Name = "ButtonRemoveObject";
            this.ButtonRemoveObject.Size = new System.Drawing.Size(102, 23);
            this.ButtonRemoveObject.TabIndex = 2;
            this.ButtonRemoveObject.Text = "Удалить";
            this.ButtonRemoveObject.UseVisualStyleBackColor = true;
            this.ButtonRemoveObject.Click += new System.EventHandler(this.ButtonRemoveObject_Click);
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Location = new System.Drawing.Point(446, 30);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(102, 23);
            this.ButtonAddObject.TabIndex = 1;
            this.ButtonAddObject.Text = "Добавить";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 317);
            this.Controls.Add(this.Зарплата);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Зарплата.ResumeLayout(false);
            this.Зарплата.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Зарплата;
        private System.Windows.Forms.Button ButtonRemoveObject;
        private System.Windows.Forms.Button ButtonAddObject;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

