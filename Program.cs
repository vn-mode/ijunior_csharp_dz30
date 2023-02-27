using System;

namespace vn_mode_csharp_dz30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число:");
            int number = GetNumber();
            Console.WriteLine("Отлично! Вы ввели число " + number);
        }

        static int GetNumber()
        {
            bool isOpen = true;
            int resault = 0;

            while (isOpen)
            {
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int resaultParse);

                if (resaultParse != 0)
                {
                    resault = resaultParse;
                    isOpen = false;
                }

                else
                {
                    Console.WriteLine("Ошибка! Попробуйте ещё раз ввести число: ");
                }
            }

            return resault;
        }
    }
}

