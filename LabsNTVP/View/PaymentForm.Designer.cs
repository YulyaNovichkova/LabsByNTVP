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
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ButtonRemoveObject = new System.Windows.Forms.Button();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Зарплата.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.Зарплата.Controls.Add(this.groupBox1);
            this.Зарплата.Controls.Add(this.ButtonRemoveObject);
            this.Зарплата.Controls.Add(this.ButtonAddObject);
            this.Зарплата.Controls.Add(this.dataGridView1);
            this.Зарплата.Location = new System.Drawing.Point(22, 23);
            this.Зарплата.Name = "Зарплата";
            this.Зарплата.Size = new System.Drawing.Size(578, 284);
            this.Зарплата.TabIndex = 1;
            this.Зарплата.TabStop = false;
            this.Зарплата.Text = "Зарплаты";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(6, 68);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(102, 20);
            this.TextBoxSearch.TabIndex = 7;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxSearch);
            this.groupBox1.Controls.Add(this.LabelSearch);
            this.groupBox1.Location = new System.Drawing.Point(440, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(3, 16);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(117, 39);
            this.LabelSearch.TabIndex = 5;
            this.LabelSearch.Text = "Введите фамилию \r\nсотрудника, которого\r\nнужно найти:";
            // 
            // ButtonRemoveObject
            // 
            this.ButtonRemoveObject.Location = new System.Drawing.Point(446, 238);
            this.ButtonRemoveObject.Name = "ButtonRemoveObject";
            this.ButtonRemoveObject.Size = new System.Drawing.Size(102, 23);
            this.ButtonRemoveObject.TabIndex = 2;
            this.ButtonRemoveObject.Text = "Удалить";
            this.ButtonRemoveObject.UseVisualStyleBackColor = true;
            this.ButtonRemoveObject.Click += new System.EventHandler(this.ButtonRemoveObject_Click);
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Location = new System.Drawing.Point(446, 119);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(102, 23);
            this.ButtonAddObject.TabIndex = 1;
            this.ButtonAddObject.Text = "Добавить";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 321);
            this.Controls.Add(this.Зарплата);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Зарплата.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Зарплата;
        private System.Windows.Forms.Button ButtonRemoveObject;
        private System.Windows.Forms.Button ButtonAddObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox TextBoxSearch;
    }
}

