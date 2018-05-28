namespace ConsoleLauncher
{
    //Оплата по окладу.
    public class SalaryPayment : IPayment
    {
        //Значения заданы для проверки работы начисления отпускных.
        //Оклад за месяц.
        private double _salary = 30000.0;
        //Итоговое начисление за месяц.
        private double _sum = 0.0;
        //Коэффициент.
        private double _rate = 1.0;
        //Количество дней в отпуске.
        private int _day = 9;
        //Выплата за пребывание в отпуске.
        private double _vacation = 0.0;

        //Конструктор класса.
        public SalaryPayment() { }

        //Расчет начисления за месяц.
        public void Payout()
        {
            _sum = _salary * _rate;
        }

        //Возвращаем значение начисления за месяц.
        public double GetBalance()
        {
            return _sum;
        }

        //Расчет отпускных.
        public void Vacation()
        {
            //Корректный результат должен быть равен 9215,02
            _vacation = (_day * (_sum * 12) / 12 /29.3);
        }

        //Возвращаем значение отпускных.
        public double GetVacation()
        {
            return _vacation;
        }
    }
}
