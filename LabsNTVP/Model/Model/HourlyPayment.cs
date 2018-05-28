namespace ConsoleLauncher
{
    //Почасовая оплата.
   public class HourlyPayment : IPayment
    {
        //Значения заданы для проверки правильной работы.
        private double _salary = 800.0;
        private double _sum = 0.0;
        private int _hour = 6;

        public HourlyPayment() {}


        public void Payout()
        {
            _sum = _salary * _hour;
        }

        public double GetBalance()
        {
            return _sum;
        }
    }
}
