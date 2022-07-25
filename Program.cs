using System;

namespace vn_mode_csharp_dz30
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            bool isOpen = true;


            while (isOpen)
            {
                Console.Write("Введите целое число: ");
                RequestInt(Console.ReadLine(), out userNumber);
                if (userNumber != 0)
                {
                    isOpen = false;
                }
            }

            static void RequestInt(string message, out int userNumber)
            {
                bool result = int.TryParse(message, out userNumber);
                if (result)
                {
                    Console.WriteLine("Отлично! Вы ввели " + userNumber);
                }
                else
                {
                    Console.WriteLine("Не удалось!");
                }
            }
        }
    }
}

