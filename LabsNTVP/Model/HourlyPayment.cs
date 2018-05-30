namespace Model
{
    //Почасовая оплата.
   public class HourlyPayment : IPayment
    {
        //Значения заданы для проверки правильной работы.

        //Оплата за час работы.
        private double _bet = 55.46;
        //Среднедневная заработная плата.
        private double _averageDaily = 0.0;
        //Рабочая норма часов в день.
        private int _hour = 8;
        //Количество отработанных часов за месяц.
        private int _workDay = 20;
        //Количество дней в отпуске.
        private int _day = 12;

        private string _surname;
        private string _name;

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = Surname;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = Name;
            }
        }

        //Расчет среднедневной заработной платы.
        public void AverageDaily()
        {
            _averageDaily = _bet * _hour;
        }

        //Расчет начисления за месяц.
        public double Payout()
        {
            double salary = _averageDaily * _workDay;
            return salary;
        }

        //Результат будет корректный, если соблюдалась норма в 8 рабочих часов.
        //Расчет отпускных.
        public double Vacation()
        {
            //Корректный результат должен быть равен  5324,23.
            double vacation = _day * _averageDaily;
            return vacation;
        }
    }
}
