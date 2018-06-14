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
    /// Форма добавления нового сотрудника
    /// </summary>
    public partial class AddObjectForm : Form
    {
        public IPayment payment { get; private set; }

        public AddObjectForm()
        {
            InitializeComponent();
            MakeElementsInvisible();
        }

        /// <summary>
        /// Метод, вызываемый для добавления сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
                if (ComboBoxType.SelectedIndex == 0)
                {
                    payment = new SalaryPayment(TextBoxSurname.Text, TextBoxName.Text, Convert.ToDouble(TextBoxSalary.Text),
                        Convert.ToDouble(TextBoxRate.Text), Convert.ToUInt32(TextBoxVacationDays.Text));
                }
                else if (ComboBoxType.SelectedIndex == 1)
                {
                    payment = new HourlyPayment(TextBoxSurname.Text, TextBoxName.Text, Convert.ToDouble(TextBoxSalary.Text),
                        Convert.ToUInt32(TextBoxWorkDay.Text), Convert.ToUInt32(TextBoxVacationDays.Text), Convert.ToUInt32(TextBoxHour.Text));
                }
            ClearTextBoxes();
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Метод, вызываемый при нажатии кнопки "Закрыть".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Метод очистки полей.
        /// </summary>
        private void ClearTextBoxes()
        {
            TextBoxSurname.Text = String.Empty;
            TextBoxName.Text = String.Empty;
            TextBoxSalary.Text = String.Empty;
            TextBoxWorkDay.Text = String.Empty;
            TextBoxVacationDays.Text = String.Empty;
            TextBoxRate.Text = String.Empty;
        }

        /// <summary>
        /// Обработчик события на изменение данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeElementsInvisible();
            ButtonAdd.Visible = true;
            ButtonClose.Visible = true;

            if (ComboBoxType.SelectedIndex == 0)
            {
                LabelName.Visible = true;
                LabelSurname.Visible = true;
                LabelRate.Visible = true;
                LabelSalary.Visible = true;
                LabelVacationDays.Visible = true;

                TextBoxSurname.Visible = true;
                TextBoxName.Visible = true;
                TextBoxSalary.Visible = true;
                TextBoxRate.Visible = true;
                TextBoxVacationDays.Visible = true;
            }
            if (ComboBoxType.SelectedIndex == 1)
            {
                LabelName.Visible = true;
                LabelSurname.Visible = true;
                LabelSalary.Visible = true;
                LabelVacationDays.Visible = true;
                LabelWorkMonth.Visible = true;
                LabelHour.Visible = true;

                TextBoxSurname.Visible = true;
                TextBoxName.Visible = true;
                TextBoxSalary.Visible = true;
                TextBoxWorkDay.Visible = true;
                TextBoxVacationDays.Visible = true;
                TextBoxHour.Visible = true;
            }
        }

        /// <summary>
        /// Метод скрывающий элементы формы.
        /// </summary>
        private void MakeElementsInvisible()
        {
            ButtonAdd.Visible = false;
            ButtonClose.Visible = false;

            LabelName.Visible = false;
            LabelSurname.Visible = false;
            LabelRate.Visible = false;
            LabelSalary.Visible = false;
            LabelVacationDays.Visible = false;
            LabelWorkMonth.Visible = false;
            LabelHour.Visible = false;

            TextBoxSurname.Visible = false;
            TextBoxName.Visible = false;
            TextBoxSalary.Visible = false;
            TextBoxWorkDay.Visible = false;
            TextBoxRate.Visible = false;
            TextBoxVacationDays.Visible = false;
            TextBoxHour.Visible = false;
        }
    }
}
