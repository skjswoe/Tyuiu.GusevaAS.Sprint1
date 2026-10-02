using Tyuiu.GusevaAS.Sprint1.Task2.V25.Lib;

namespace Tyuiu.GusevaAS.Sprint1.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Гусева А. С. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнила: Гусева Алиса Степановна | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ФОРМУЛИРОВКА ЗАДАНИЯ:                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Известен угол в радианах. Перевести угол в градусы.                     *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");            
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Что пользователь вводит? Угол в радианах(целое число)                   *");
            Console.WriteLine("* Что программа печатает на экране? Угол в градусах(вещественное число)   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.Write("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Угол в градусах = " + ds.ConvertRadsToDegrees(x));
            Console.ReadLine();
        }
    }
}
