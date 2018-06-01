namespace Model
{
    /// <summary>
    /// Класс SalaryPayment.
    /// Работает с данными для оклада по ставке.
    /// </summary>
    public class SalaryPayment : IPayment
    {
        /// <summary>
        /// Ставка за месяц работы.
        /// </summary>
        private double _monthSalary;

        /// <summary>
        /// Коэффициент заработной платы.
        /// </summary>
        private double _rate;

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
        /// Чтение и запись фамилии человека.
        /// </value>
        public string Surname { get; set; }

        /// <value>
        /// Чтение и запись имени человека.
        /// </value>
        public string Name { get; set; }

        /// <value>
        /// Чтение и запись ставки за месяц.
        /// </value>
        public double MonthSalary
        {
            get
            {
                return _monthSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new System.Exception("Значение ставки должно быть больше 0.");
                }
                else _monthSalary = value;
            }
        }

        /// <value>
        /// Чтение и запись коэфицикнта заработной платы.
        /// </value>
        public double Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                if (value < 0)
                {
                    throw new System.Exception("Значение коэфициента должно быть больше 0.");
                }
                else _rate = value;
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

        /// <returns> 
        /// Возвращает значение итоговой оплаты труда за месяц. 
        /// </returns>
        public double Payout()
        {
            double salary = _monthSalary * _rate;
            return salary;
        }

        /// <returns> 
        /// Возвращает значение суммы, которую необходимо выплатить за отпуск. 
        /// </returns>
        public double Vacation()
        {
            double vacation = (_day * (Payout() * 12) / 12 /29.3);
            return vacation;
        }
    }
}
