using System.ComponentModel.DataAnnotations;
using Tyuiu.TyazhovLA.Sprint3.Task7.V26.Lib;
namespace Tyuiu.TyazhovLA.Sprint3.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Тяжов Л. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Итоговый таск                                                     *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5; int endValue = 5;
            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + endValue);
            int len = ds.GetMassFunction(startValue, endValue).Length;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, endValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |   f(x)    |");
            Console.WriteLine("+----------+-----------+");
            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");

            Console.ReadKey();


        }
    }
}
