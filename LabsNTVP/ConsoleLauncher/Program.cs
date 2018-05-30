using System;

namespace Model
{
    namespace ConsoleLauncher
    {
        class Program
        {
            static void Main(string[] args)
            {
                SalaryPayment salaryPayment = new SalaryPayment();
                HourlyPayment hourlyPayment = new HourlyPayment();

                int key;
                do
                {
                    Console.WriteLine("Заработная плата по окладу:\n");
                    Console.WriteLine("1. Начислить заработную плату по окладу.");
                    Console.WriteLine("2. Узнать баланс для заработной платы по окладу.");
                    Console.WriteLine("3. Узнать выплату за пребывание в отпуске.");
                    Console.WriteLine("\nПочасовая заработная плата:\n");
                    Console.WriteLine("4. Начислить заработную плату для почасовой формы.");
                    Console.WriteLine("5. Узнать баланс для почасовой заработной платы.");
                    Console.WriteLine("6. Узнать выплату за пребывание в отпуске.");
                    Console.WriteLine("7. Получить полную информацию.");
                    Console.WriteLine("\n0. Выход.");

                    key = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (key)
                    {
                        case 1:
                            {
                                salaryPayment.Bet = 30000;
                                salaryPayment.Rate = 1;
                                salaryPayment.Payout();
                                Console.WriteLine("Начисление прошло успешно.\n");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Баланс: " + salaryPayment.Payout() + "\n");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Выплата отпускных: " + salaryPayment.Vacation() + "\n");
                                break;
                            }
                        case 4:
                            {
                                hourlyPayment.Bet = 55.46;
                                hourlyPayment.AverageDaily();
                                hourlyPayment.Payout();
                                Console.WriteLine("Начисление прошло успешно.\n");
                                break;
                            }
                        case 5:
                            {
                                //Будет выводится корректное значение только после того, как
                                //будет выполнет предыдущий case, иначе будет выведен 0.
                                Console.WriteLine("Баланс: " + hourlyPayment.Payout() + "\n");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Выплата отпускных: " + hourlyPayment.Vacation() + "\n");
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("\tКонтрольный вывод для ставки по окладу.\n");

                                salaryPayment.Surname = "Иванов";
                                salaryPayment.Name = "Иван";
                                salaryPayment.Bet = 30000;
                                salaryPayment.Rate = 1;
                                salaryPayment.Payout();

                                Console.WriteLine("Информация для " + salaryPayment.Surname + " " + salaryPayment.Name + "\n");
                                Console.WriteLine("Получит зарплату за месяц: " + salaryPayment.Payout() + "\n");
                                Console.WriteLine("Получит отпускных: " + salaryPayment.Vacation() + "\n");

                                Console.WriteLine("\tКонтрольный вывод для почасовой ставки.\n");

                                hourlyPayment.Surname = "Петров";
                                hourlyPayment.Name = "Петр";
                                hourlyPayment.Bet = 55.46;
                                hourlyPayment.AverageDaily();
                                hourlyPayment.Payout();

                                Console.WriteLine("Информация для " + hourlyPayment.Surname + " " + hourlyPayment.Name + "\n");
                                Console.WriteLine("Получит зарплату за месяц: " + hourlyPayment.Payout() + "\n");
                                Console.WriteLine("Получит отпускных: " + hourlyPayment.Vacation() + "\n");
                                break;
                            }
                        case 0:
                            {
                                Console.WriteLine("Welcome back.");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Mistake. Try again.\n");
                                break;
                            }
                    }
                } while (key != 0);
            }
        }
    }
}
