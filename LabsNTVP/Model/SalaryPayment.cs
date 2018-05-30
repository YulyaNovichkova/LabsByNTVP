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
        private double _bet;

        /// <summary>
        /// Коэффициент заработной платы.
        /// </summary>
        private double _rate;

        /// <summary>
        /// Количество дней в отпуске.
        /// </summary>
        private int _day = 9;

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
        /// Запись и чтение ставки за месяц.
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
                else throw new System.Exception("Значение ставки должно быть больше 0.");
            }
        }

        /// <value>
        /// Запись и чтение коэфицикнта заработной платы.
        /// </value>
        public double Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                if (value > 0)
                {
                    _rate = value;
                }
                else throw new System.Exception("Значение коэфициента должно быть больше 0.");
            }
        }

        /// <returns> 
        /// Возвращает значение итоговой оплаты труда за месяц. 
        /// </returns>
        public double Payout()
        {
            double salary = _bet * _rate;
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
