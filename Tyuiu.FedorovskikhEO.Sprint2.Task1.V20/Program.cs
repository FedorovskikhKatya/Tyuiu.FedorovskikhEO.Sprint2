using Tyuiu.FedorovskikhEO.Sprint2.Task1.V20.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a=242;
            int b=155;
            int c = 456;
            int d = 17;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);
            Console.Title = "Спринт #1 | Выполнила: Федоровских Е. O. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                              *");
            Console.WriteLine("* Выполнила: Федоровских Екатерина Олеговна | ИСТНБ-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических               *");
            Console.WriteLine("* выражений, которая вернет массив: True,False,True,False,True,False      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" A = " + a);
            Console.WriteLine(" B = " + b);
            Console.WriteLine(" C = " + c);
            Console.WriteLine(" D = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
