using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;


namespace View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class PaymentForm : Form
    {
        /// <summary>
        /// Форма добавления нового сотрудника
        /// </summary>
        private AddObjectForm _addObject;

        /// <summary>
        /// Список сотрудников
        /// </summary>
        private List<IPayment> _payment;

        private BindingSource _bindingSource = new BindingSource();

        public PaymentForm()
        {
            InitializeComponent();

            _addObject = new AddObjectForm();
            _payment = new List<IPayment>();

            _bindingSource.DataSource = _payment;
            dataGridView1.DataSource = _bindingSource;

            dataGridView1.RowHeadersVisible = false;
        }

        private void ButtonRemoveObject_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить?",
                "Подтвердите",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.RowCount > 0)
                {
                    int index = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.Rows.RemoveAt(index);
                }
            }
        }

        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            var result = _addObject.ShowDialog();
            if (result == DialogResult.OK)
            {
                _bindingSource.Add(_addObject.payment);
            }
        }
    }
}
