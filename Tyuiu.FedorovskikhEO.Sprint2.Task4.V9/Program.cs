using Tyuiu.FedorovskikhEO.Sprint2.Task4.V9.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Федоровских Е. O. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнила: Федоровских Екатерина Олеговна | ИСТНБ-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая вычисляет требуемое значение                 *");
            Console.WriteLine("* с использованием тернарного оператора                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x,y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("значение функции = " + res);
            Console.ReadKey();
        }
    }
}
