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
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonRemoveObject = new System.Windows.Forms.Button();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Зарплата.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // Зарплата
            // 
            this.Зарплата.Controls.Add(this.LabelSearch);
            this.Зарплата.Controls.Add(this.TextBoxSearch);
            this.Зарплата.Controls.Add(this.ButtonRemoveObject);
            this.Зарплата.Controls.Add(this.ButtonAddObject);
            this.Зарплата.Controls.Add(this.dataGridView1);
            this.Зарплата.Location = new System.Drawing.Point(22, 30);
            this.Зарплата.Name = "Зарплата";
            this.Зарплата.Size = new System.Drawing.Size(442, 306);
            this.Зарплата.TabIndex = 1;
            this.Зарплата.TabStop = false;
            this.Зарплата.Text = "Зарплаты";
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(116, 258);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(102, 39);
            this.LabelSearch.TabIndex = 5;
            this.LabelSearch.Text = "Поиск.\r\nВведите значение \r\nPayout:";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(224, 271);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(102, 20);
            this.TextBoxSearch.TabIndex = 7;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ButtonRemoveObject
            // 
            this.ButtonRemoveObject.Location = new System.Drawing.Point(332, 269);
            this.ButtonRemoveObject.Name = "ButtonRemoveObject";
            this.ButtonRemoveObject.Size = new System.Drawing.Size(90, 23);
            this.ButtonRemoveObject.TabIndex = 2;
            this.ButtonRemoveObject.Text = "Удалить";
            this.ButtonRemoveObject.UseVisualStyleBackColor = true;
            this.ButtonRemoveObject.Click += new System.EventHandler(this.ButtonRemoveObject_Click);
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Location = new System.Drawing.Point(19, 268);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(91, 23);
            this.ButtonAddObject.TabIndex = 1;
            this.ButtonAddObject.Text = "Добавить";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 348);
            this.Controls.Add(this.Зарплата);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(502, 387);
            this.MinimumSize = new System.Drawing.Size(502, 387);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Зарплата.ResumeLayout(false);
            this.Зарплата.PerformLayout();
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
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
    }
}

