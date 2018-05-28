
namespace ConsoleLauncher
{
    public interface IPayment
    {
        //Расчет начисления за месяц.
        void Payout();
        //Расчет отпускных.
        void Vacation();
    }
}
