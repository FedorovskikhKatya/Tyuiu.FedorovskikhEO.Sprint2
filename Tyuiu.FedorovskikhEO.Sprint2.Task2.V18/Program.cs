using Tyuiu.FedorovskikhEO.Sprint2.Task2.V18.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Федоровских Е. O. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Федоровских Екатерина Олеговна | ИСТНБ-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая запрашивает значения с клавиатуры и вычисляет*");
            Console.WriteLine("* находится ли точка с координатами ХУ в защтрихованной области           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите переменную х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("точка находится в заданной отрасли");
            }
            else
            {
                Console.WriteLine("точка не находится в заданной отрасли");
            }
            Console.ReadKey();

        }
    }
}
