using System;

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
                Console.WriteLine("\n0. Выход.");

                key = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (key)
                {
                    case 1:
                        {
                            salaryPayment.Payout();
                            Console.WriteLine("Начисление прошло успешно.\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Баланс: " + salaryPayment.GetBalance() + "\n");
                            break;
                        }
                    case 3:
                        {
                            salaryPayment.Vacation();
                            Console.WriteLine("Выплата отпускных: " + salaryPayment.GetVacation() + "\n");
                            break;
                        }
                    case 4:
                        {
                            hourlyPayment.AverageDaily();
                            hourlyPayment.Payout();
                            Console.WriteLine("Начисление прошло успешно.\n");
                            break;
                        }
                    case 5:
                        {
                            //Будет выводится корректное значение только после того, как
                            //будет выполнет предыдущий case, иначе будет выведен 0.
                            Console.WriteLine("Баланс: " + hourlyPayment.GetBalance() + "\n");
                            break;
                        }
                    case 6:
                        {
                            hourlyPayment.Vacation();
                            Console.WriteLine("Выплата отпускных: " + hourlyPayment.GetVacation() + "\n");
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
