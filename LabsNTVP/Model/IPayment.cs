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
        /// Запись и чтение фамилии человека.
        /// </value>
        string Surname { get; set; }

        /// <value>
        /// Запись и чтение имени человека.
        /// </value>
        string Name { get; set; }
    }
}
