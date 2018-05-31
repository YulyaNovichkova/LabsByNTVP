namespace Model
{
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
        /// Заработная плата за день.
        /// </summary>
        private double _averageDaily;

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

        /// <value>
        /// Запись и чтение фамилии человека.
        /// </value>
        public string Surname { get; set; }

        /// <value>
        /// Запись и чтение имени человека.
        /// </value>
        public string Name { get; set; }

        /// <value>
        /// Запись и чтение ставки за час.
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
        /// Запись и чтение количество отработаных дней.
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
        /// Запись и чтение количества дней в отпуске.
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
        /// Метод, расчитывающий среднедневную заработную плату.
        /// </summary>
        public void AverageDaily()
        {
            _averageDaily = _hourSalary * _hour;
        }

        /// <returns> 
        /// Возвращает значение итоговой оплаты труда за месяц. 
        /// </returns>
        public double Payout()
        {
            double salary = _averageDaily * _workDay;
            return salary;
        }

        /// <returns> 
        /// Возвращает значение суммы, которую необходимо выплатить за отпуск. 
        /// </returns>
        public double Vacation()
        {
            double vacation = _day * _averageDaily;
            return vacation;
        }
    }
}
