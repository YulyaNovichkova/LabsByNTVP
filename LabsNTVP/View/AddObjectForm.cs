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

        public bool IsTrue = false;

        public AddObjectForm()
        {
            InitializeComponent();
            MakeElementsInvisible(IsTrue);
#if !DEBUG
            ButtonRandomPerson_Click.Visible = false;
#endif
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
                    payment = new SalaryPayment(SurnameTextBox1.Text, NameTextBox1.Text, Convert.ToDouble(SalaryTextBox.Text),
                        Convert.ToDouble(RateTextBox.Text), Convert.ToUInt32(VacationDaysTextBox1.Text));
                }
                else if (ComboBoxType.SelectedIndex == 1)
                {
                    payment = new HourlyPayment(SurnameTextBox2.Text, NameTextBox2.Text, Convert.ToDouble(SalaryTextBox.Text),
                        Convert.ToUInt32(WorkDayTextBox.Text), Convert.ToUInt32(VacationDaysTextBox2.Text), Convert.ToUInt32(HourTextBox.Text));
                }
            ClearTextBoxes();
            DialogResult = DialogResult.OK;
            ComboBoxType.SelectedIndex = -1;
            MakeElementsInvisible(IsTrue);
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
            MakeElementsInvisible(IsTrue);
            ComboBoxType.SelectedIndex = -1;
            Close();
        }

        /// <summary>
        /// Метод очистки полей.
        /// </summary>
        private void ClearTextBoxes()
        {
            SurnameTextBox1.Text = String.Empty;
            NameTextBox1.Text = String.Empty;
            SalaryTextBox.Text = String.Empty;
            RateTextBox.Text = String.Empty;
            VacationDaysTextBox1.Text = String.Empty;

            SurnameTextBox2.Text = String.Empty;
            NameTextBox2.Text = String.Empty;
            WorkDayTextBox.Text = String.Empty;
            HourTextBox.Text = String.Empty;
            VacationDaysTextBox2.Text = String.Empty;
        }

        /// <summary>
        /// Обработчик события на изменение данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeElementsInvisible(!IsTrue);
            ButtonAdd.Visible = true;
            ButtonClose.Visible = true;

            if (ComboBoxType.SelectedIndex == 0)
            {
                SalaryGroupBox.Visible = true;
                HourlyGroupBox.Visible = false;
            }
            if (ComboBoxType.SelectedIndex == 1)
            {
                HourlyGroupBox.Visible = true;
                SalaryGroupBox.Visible = false;

                int x = HourlyGroupBox.Location.X - 306;
                int y = HourlyGroupBox.Location.Y;
                HourlyGroupBox.Location = new Point(x, y);
            }
        }

        /// <summary>
        /// Метод скрывающий элементы формы.
        /// </summary>
        private void MakeElementsInvisible(bool IsTrue)
        {
            SalaryGroupBox.Visible = IsTrue;
            HourlyGroupBox.Visible = IsTrue;
            ButtonAdd.Visible = IsTrue;
            ButtonClose.Visible = IsTrue;
        }

        /// <summary>
        /// Метод, вызываетмый для генерации случайных значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandomPerson_Click(object sender, EventArgs e)
        {
#if DEBUG
            Random random = new Random();

            string[] surname = new string[15] { "Иванов", "Петров", "Сидоров", "Трофимов", "Вакулин", "Колесник",
                "Соловов", "Калинин", "Калачев", "Ермолаев","Тихонов", "Бродт", "Дворной", "Пушкарёв", "Муленок" };
            string[] name = new string[15] { "Дмитрий", "Павел", "Александр", "Сергей", "Илья","Ярослав", "Алексей",
                "Кирилл", "Николай", "Иван", "Владислав", "Слава", "Георгий", "Евгений", "Виталя" };

            string randomSurname = surname[random.Next(15)].ToString();
            string randomName = name[random.Next(15)].ToString();

            int randomType = random.Next(2);
            int randomSalaryPayment = random.Next(1, 50000);
            int randomSalaryHourly = random.Next(1, 200);
            double randomRate = random.Next(2);
            int randomWorkDay = random.Next(25);
            int randomVacationDays = random.Next(28);
            int randomHour = random.Next(1,10);

            if (randomType == 0)
            {
                payment = new SalaryPayment(randomSurname, randomName, randomSalaryPayment, randomRate, Convert.ToUInt32(randomVacationDays));
            }
            else
            {
                payment = new HourlyPayment(randomSurname, randomName, randomSalaryHourly, Convert.ToUInt32(randomWorkDay),
                    Convert.ToUInt32(randomVacationDays), Convert.ToUInt32(randomHour));
            }
            ClearTextBoxes();
            DialogResult = DialogResult.OK;
            ComboBoxType.SelectedIndex = -1;
            MakeElementsInvisible(IsTrue);
            Close();
#endif
        }
    }
}
