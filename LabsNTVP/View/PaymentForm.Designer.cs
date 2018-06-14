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
            this.ButtonRemoveObject = new System.Windows.Forms.Button();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Зарплата.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // Зарплата
            // 
            this.Зарплата.Controls.Add(this.ButtonRemoveObject);
            this.Зарплата.Controls.Add(this.ButtonAddObject);
            this.Зарплата.Controls.Add(this.dataGridView1);
            this.Зарплата.Location = new System.Drawing.Point(22, 23);
            this.Зарплата.Name = "Зарплата";
            this.Зарплата.Size = new System.Drawing.Size(491, 316);
            this.Зарплата.TabIndex = 1;
            this.Зарплата.TabStop = false;
            this.Зарплата.Text = "Зарплаты";
            // 
            // ButtonRemoveObject
            // 
            this.ButtonRemoveObject.Location = new System.Drawing.Point(368, 277);
            this.ButtonRemoveObject.Name = "ButtonRemoveObject";
            this.ButtonRemoveObject.Size = new System.Drawing.Size(102, 23);
            this.ButtonRemoveObject.TabIndex = 2;
            this.ButtonRemoveObject.Text = "Удалить";
            this.ButtonRemoveObject.UseVisualStyleBackColor = true;
            this.ButtonRemoveObject.Click += new System.EventHandler(this.ButtonRemoveObject_Click);
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Location = new System.Drawing.Point(20, 277);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(89, 23);
            this.ButtonAddObject.TabIndex = 1;
            this.ButtonAddObject.Text = "Добавить";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 351);
            this.Controls.Add(this.Зарплата);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Зарплата.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Зарплата;
        private System.Windows.Forms.Button ButtonRemoveObject;
        private System.Windows.Forms.Button ButtonAddObject;
    }
}

