using System;
using System.Globalization;


namespace CsharpConsole
{
    class Program
    {
        static void Discription()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Решение:");
        }
        public static void Calculator()
        {
            while (true)
            {
                Console.Clear();
                double First_Value, Second_Value;

                try
                {
                    Console.WriteLine("Введите первое значение: ");
                    First_Value = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второе значение: ");
                    Second_Value = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите действие со значениями: ");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.Multiply:
                        Discription();
                        Console.WriteLine(First_Value * Second_Value);
                        break;
                    case ConsoleKey.Add:
                        Discription();
                        Console.WriteLine(First_Value + Second_Value);
                        break;
                    case ConsoleKey.Subtract:
                        Discription();
                        Console.WriteLine(First_Value - Second_Value);
                        break;
                    case ConsoleKey.Divide:
                        Discription();
                        if (Second_Value == 0) { Console.WriteLine(0); }
                        else
                            Console.WriteLine(First_Value / Second_Value);
                        break;
                    default:
                        Console.WriteLine("Вы ввели неизвесный символ!");
                        break;
                }
                Console.ReadLine();
            }
        }
        public static void ConverterUSD()
        {
            double USDtoUAH = 29.60, USDtoRUB = 55.22;
        Console.WriteLine("Введите число в USD: ");
            double USD = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(USD + " в UAH = " + USD* USDtoUAH);
        Console.WriteLine(USD + " в RUB = " + USD* USDtoRUB);
        }
        public static void SummaAndDobutok()
        {
            Console.WriteLine("Введите первое число: ");
            double first_Value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double second_Value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            double third_Value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Значение суммы: ");
            Console.WriteLine(first_Value + second_Value + third_Value);

            Console.WriteLine("Значение произведения: ");
            Console.WriteLine(second_Value * third_Value * third_Value);
         
        }
        public static void ParseOrTryparse(string[] args)
        {
            string str = "4646";
            int a;
            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("+" + a);
            }
            else { Console.WriteLine("-" + a); }

        }
        public static void Chetnoy_Nechotnoy_Proverka()
        {
            int y = Convert.ToInt32(Console.ReadLine());
            if(y % 2== 0)
            {
                Console.WriteLine("парне число і");
            }
            else
            {
                Console.WriteLine("Не парне число");
            }           


        }
        public void Convertation1()
        {
            string str = "1,34";
            double number = Convert.ToDouble(str);
            Console.WriteLine(number);
        }
    }
}

