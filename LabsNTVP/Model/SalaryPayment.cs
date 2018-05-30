namespace Model
{
    //Оплата по окладу.
    public class SalaryPayment : IPayment
    {
        //Значения заданы для проверки работы начисления отпускных.
        //Оклад за месяц.
        private double _bet = 30000.0;
        //Коэффициент.
        private double _rate = 1.0;
        //Количество дней в отпуске.
        private int _day = 9;

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

        //Расчет начисления за месяц.
        public double Payout()
        {
            double salary = _bet * _rate;
            return salary;
        }

        //Расчет отпускных.
        public double Vacation()
        {
            //Корректный результат должен быть равен 9215,02
            double vacation = (_day * (Payout() * 12) / 12 /29.3);
            return vacation;
        }
    }
}
