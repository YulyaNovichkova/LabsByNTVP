namespace Model
{
    /// <summary>
    /// Интерфейс IPayment.
    /// </summary>
    public interface IPayment
    {
        /// <value>
        /// Чтение и запись фамилии человека.
        /// </value>
        string Surname { get; set; }

        /// <value>
        /// Чтение и запись имени человека.
        /// </value>
        string Name { get; set; }

        /// <returns>
        /// Чтение значения итоговой оплаты труда за месяц. 
        /// </returns>
        double Payout { get; }

        /// <returns> 
        /// Чтение значения суммы, которую необходимо выплатить за отпуск. 
        /// </returns>
        double Vacation { get; }
    }
}
