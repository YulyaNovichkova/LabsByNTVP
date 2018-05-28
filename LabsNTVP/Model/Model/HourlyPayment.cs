namespace ConsoleLauncher
{
    //Почасовая оплата.
   public class HourlyPayment : IPayment
    {
        //Значения заданы для проверки правильной работы.

        //Оплата за час работы.
        private double _salary = 55.46;
        //Среднедневная заработная плата.
        private double _averageDaily = 0.0;
        //Итоговое начисление за месяц.
        private double _sum = 0.0;
        //Рабочая норма часов в день.
        private int _hour = 8;
        //Количество отработанных часов за месяц.
        private int _workDay = 20;
        //Выплата за пребывание в отпуске.
        private double _vacation = 0.0;
        //Количество дней в отпуске.
        private int _day = 12;

        //Конструктор класса.
        public HourlyPayment() {}

        //Расчет среднедневной заработной платы.
        public void AverageDaily()
        {
            _averageDaily = _salary * _hour;
        }

        //Расчет начисления за месяц.
        public void Payout()
        {
            _sum = _averageDaily * _workDay;
        }

        //Возвращаем значение начисления за месяц.
        public double GetBalance()
        {
            return _sum;
        }

        //Результат будет корректный, если соблюдалась норма в 8 рабочих часов.
        //Расчет отпускных.
        public void Vacation()
        {
            //Корректный результат должен быть равен  5324,23.
            _vacation = _day * _averageDaily;
        }

        //Возвращаем значение отпускных.
        public double GetVacation()
        {
            return _vacation;
        }
    }
}
