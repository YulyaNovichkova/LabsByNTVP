using System;

namespace Model
{
    [Serializable]
    /// <summary>
    /// Класс HourlyPayment.
    /// Работает с данными для почасофой заработной платы.
    /// </summary>
    public class HourlyPayment : IPayment
    {
        /// <summary>
        /// Ставка за час работы.
        /// </summary>
        private double _hourSalary;

        /// <summary>
        /// Рабочая норма часов в день.
        /// </summary>
        private uint _hour;

        /// <summary>
        /// Количество отработанных часов за месяц.
        /// </summary>
        private uint _workDay;

        /// <summary>
        /// Количество дней в отпуске.
        /// </summary>
        private uint _day;

        /// <summary>
        /// Данные о человеке, получающего зарплату.
        /// </summary>
        private string _surname;
        private string _name;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public HourlyPayment(string surname, string name, double hourSalary, uint workDay, uint day, uint hour)
        {
            Surname = surname;
            Name = name;
            HourSalary = hourSalary;
            WorkDay = workDay;
            Day = day;
            Hour = hour;
        }

        /// <value>
        /// Чтение и запись фамилии человека.
        /// </value>
        public string Surname { get; set; }

        /// <value>
        /// Чтение и запись имени человека.
        /// </value>
        public string Name { get; set; }

        /// <value>
        /// Чтение и запись ставки за час.
        /// </value>
        public double HourSalary
        {
            get
            {
                return _hourSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new System.Exception("Значение оклада за час должно быть больше 0.");
                }
                else _hourSalary = value;
            }
        }

        /// <value>
        /// Чтение и запись часовой рабочей нормы в день.
        /// </value>
        public uint Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                _hour = value;
            }
        }

        /// <value>
        /// Чтение и запись количество отработаных дней.
        /// </value>
        public uint WorkDay
        {
            get
            {
                return _workDay;
            }
            set
            {
                _workDay = value;
            }
        }

        /// <value>
        /// Чтение и запись количества дней в отпуске.
        /// </value>
        public uint Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
            }
        }

        /// <summary>
        /// Возвращает значения итоговой оплаты труда за месяц. 
        /// </summary>
        /// <returns></returns>
        public double Salary()
        {
            double salary = (_hourSalary * _hour) * _workDay;
            return salary;
        }

        /// <returns> 
        /// Чтение значения итоговой оплаты труда за месяц. 
        /// </returns>
        public double Payout
        {
            get
            {
                return Salary();
            }
        }

        /// <returns> 
        /// Чтение значения суммы, которую необходимо выплатить за отпуск. 
        /// </returns>
        public double Vacation
        {
            get
            {
                return CalculationVacation();
            }
        }

        /// <summary>
        /// Расчитывает значение суммы, которую необходимо выплатить за отпуск. 
        /// </summary>
        /// <returns></returns>
        public double CalculationVacation()
        {
            double vacation = _day * (_hourSalary * _hour);
            return vacation;
        }
    }
}
