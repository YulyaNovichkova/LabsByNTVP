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

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public SalaryPayment(string surname, string name, double monthSalary, double rate, uint day)
        {
            Surname = surname;
            Name = name;
            MonthSalary = monthSalary;
            Rate = rate;
            Day = day;
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

        /// <summary>
        /// Возвращает значения итоговой оплаты труда за месяц. 
        /// </summary>
        /// <returns></returns>
        public double Salary()
        {
            double salary = _monthSalary * _rate;
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
            double vacation = (_day * (Salary() * 12) / 12 / 29.3);
            return vacation;
        }
    }
}
