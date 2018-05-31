using System;
using Model;

    namespace ConsoleLauncher
    {
        class Program
        {
            static void Main(string[] args)
            {
                SalaryPayment salaryPayment = new SalaryPayment();
                HourlyPayment hourlyPayment = new HourlyPayment();
                IPayment pay = salaryPayment;
                int key;
                do
                {
                    Console.WriteLine("Заработная плата по окладу:\n");
                    Console.WriteLine("1. Начислить заработную плату по окладу.");
                    Console.WriteLine("2. Узнать выплату за пребывание в отпуске.");
                    Console.WriteLine("\nПочасовая заработная плата:\n");
                    Console.WriteLine("3. Начислить заработную плату для почасовой формы.");
                    Console.WriteLine("4. Узнать выплату за пребывание в отпуске.");
                    Console.WriteLine("\nПолная информация.\n");
                    Console.WriteLine("5. Получить полную информацию.");
                    Console.WriteLine("\n0. Выход.");

                    key = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (key)
                    {
                        case 1:
                            {
                                salaryPayment.MonthSalary = 30000;
                                salaryPayment.Rate = 1;
                                salaryPayment.Payout();
                                Console.WriteLine("Начисление прошло успешно.\n");
                                Console.WriteLine("Баланс: " + pay.Payout() + "\n");
                                break;
                            }
                        case 2:
                            {
                                salaryPayment.Day = 9;
                                Console.WriteLine("Выплата отпускных: " + pay.Vacation() + "\n");
                                break;
                            }
                        case 3:
                            {
                                hourlyPayment.HourSalary = 55.46;
                                hourlyPayment.Hour = 8;
                                hourlyPayment.AverageDaily();
                                hourlyPayment.WorkDay = 20;
                                hourlyPayment.Payout();
                                Console.WriteLine("Начисление прошло успешно.\n");
                                Console.WriteLine("Баланс: " + hourlyPayment.Payout() + "\n");
                                break;
                            }
                        case 4:
                            {
                                hourlyPayment.Day = 12;
                                Console.WriteLine("Выплата отпускных: " + hourlyPayment.Vacation() + "\n");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("\tКонтрольный вывод для ставки по окладу.\n");

                                salaryPayment.Surname = "Иванов";
                                salaryPayment.Name = "Иван";
                                salaryPayment.MonthSalary = 30000;
                                salaryPayment.Rate = 1;
                                salaryPayment.Day = 9;
                                salaryPayment.Payout();

                                Console.WriteLine("Информация для " + salaryPayment.Surname + " " + salaryPayment.Name + "\n");
                                Console.WriteLine("Получит зарплату за месяц: " + pay.Payout() + "\n");
                                Console.WriteLine("Получит отпускных: " + pay.Vacation() + "\n");

                                Console.WriteLine("\tКонтрольный вывод для почасовой ставки.\n");

                                hourlyPayment.Surname = "Петров";
                                hourlyPayment.Name = "Петр";
                                hourlyPayment.HourSalary = 55.46;
                                hourlyPayment.Hour = 8;
                                hourlyPayment.AverageDaily();
                                hourlyPayment.WorkDay = 20;
                                hourlyPayment.Day = 12;
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
