namespace Model
{
    public interface IPayment
    {
        //Расчет и возвращения начисления за месяц.
        double Payout();
        //Расчет отпускных.
        double Vacation();

        string Surname { get; set; }

        string Name { get; set; }
    }
}
