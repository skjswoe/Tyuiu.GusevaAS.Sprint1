using Tyuiu.GusevaAS.Sprint1.Task6.V1.Lib;

namespace Tyuiu.GusevaAS.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Гусева А. С. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Работа со строками класс String                                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Гусева Алиса Степановна | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа*");
            Console.WriteLine("* Программа должна завершать работу в результате ввода, например, точки.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine("Для завершения введите точку.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("-> ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    continue;

                if (input[0] == '.')
                    break;

                Console.WriteLine(ds.SymbolCode(input));
                Console.WriteLine();
            }
        }
    }
}