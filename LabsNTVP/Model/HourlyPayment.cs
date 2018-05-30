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
        private double _bet;

        /// <summary>
        /// Заработная плата за день.
        /// </summary>
        private double _averageDaily = 0.0;

        /// <summary>
        /// Рабочая норма часов в день.
        /// </summary>
        private int _hour = 8;

        /// <summary>
        /// Количество отработанных часов за месяц.
        /// </summary>
        private int _workDay = 20;

        /// <summary>
        /// Количество дней в отпуске.
        /// </summary>
        private int _day = 12;

        /// <summary>
        /// Данные о человеке, получающего зарплату.
        /// </summary>
        private string _surname;
        private string _name;

        /// <value>
        /// Запись и чтение фамилии человека.
        /// </value>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        /// <value>
        /// Запись и чтение имени человека.
        /// </value>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <value>
        /// Запись и чтение ставки за час.
        /// </value>
        public double Bet
        {
            get
            {
                return _bet;
            }
            set
            {
                if (value > 0)
                {
                    _bet = value;
                }
                else throw new System.Exception("Значение оклада за час должно быть больше 0.");
            }
        }

        /// <summary>
        /// Метод, расчитывающий среднедневную заработную плату.
        /// </summary>
        public void AverageDaily()
        {
            _averageDaily = _bet * _hour;
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
