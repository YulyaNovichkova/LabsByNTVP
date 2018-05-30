namespace Model
{
    //Оплата по окладу.
    public class SalaryPayment : IPayment
    {
        //Оклад за месяц.
        private double _bet;
        //Коэффициент.
        private double _rate;
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
                _surname = value;
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
                _name = value;
            }
        }

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
