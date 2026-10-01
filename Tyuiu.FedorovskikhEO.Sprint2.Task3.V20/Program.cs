using Tyuiu.FedorovskikhEO.Sprint2.Task3.V20.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task3.V20
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Федоровских Екатерина Олеговна | ИСТНБ-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая вычисляет требуемое значение У               *");
            Console.WriteLine("* с использованием оператора else if и введенным х с клавиатуры           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение х: ");
            double x =Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("значение функции = " + res);
            Console.ReadKey();
        }
    }
}
