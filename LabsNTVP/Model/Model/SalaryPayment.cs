namespace ConsoleLauncher
{
    //Оплата по окладу.
    public class SalaryPayment : IPayment
    {
        //Значения заданы для проверки работы начисления отпускных.
        private double _salary = 30000.0;
        private double _sum = 0.0;
        private double _rate = 1.0;
        //Количество дней в отпуске.
        private int _day = 9;
        //Выплата за пребывание в отпуске.
        private double _vacation = 0.0;

        public SalaryPayment() { }

        public void Payout()
        {
            _sum = _salary * _rate;
        }

        //Расчет отпускных.
        public void Vacation()
        {
            //Корректный результат должен быть равен 9215,02
            _vacation = (_day * (_sum * 12) / 12 /29.3);
        }

        public double GetBalance()
        {
            return _sum;
        }

        public double GetVacation()
        {
            return _vacation;
        }
    }
}
