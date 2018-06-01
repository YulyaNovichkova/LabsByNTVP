namespace Model
{
    /// <summary>
    /// Интерфейс IPayment.
    /// </summary>
    public interface IPayment
    {
        /// <returns>
        /// Расчет и возвращение начисления за месяц.
        /// </returns>
        double Payout();

        /// <returns> 
        /// Расчитывает и возвращает значение суммы, которую необходимо выплатить за отпуск. 
        /// </returns>
        double Vacation();

        /// <value>
        /// Чтение и запись фамилии человека.
        /// </value>
        string Surname { get; set; }

        /// <value>
        /// Чтение и запись имени человека.
        /// </value>
        string Name { get; set; }
    }
}
