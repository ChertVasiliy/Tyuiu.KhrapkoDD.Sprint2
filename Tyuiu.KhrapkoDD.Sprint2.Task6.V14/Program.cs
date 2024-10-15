using Tyuiu.KhrapkoDD.Sprint2.Task6.V14.Lib;
namespace Tyuiu.KhrapkoDD.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Храпко Д. Д. | ИСТНб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Получение результата из switch                                              *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #6                                                                        *");
            Console.WriteLine("* Выполнил Храпко Данил Дмитриевич | ИСТНб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Задание:                                                                          *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем недели        *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й день недели *");
            Console.WriteLine("* (если 1 января — понедельник, то d = 1 , если вторник — d = 2 , …, если           *");
            Console.WriteLine("* воскресенье — d = 7).                                                             *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите количество дней:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня недели с которого начинается год:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine($"День недели: {ds.FindDateOfNextDay(d, k)}");

            Console.ReadKey();
        }
    }
}