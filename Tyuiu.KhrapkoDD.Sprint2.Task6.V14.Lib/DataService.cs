using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhrapkoDD.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDateOfNextDay(int k, int d)
        {
            if (k < 1 || k > 365 || d < 1 || d > 7)
            {
                throw new ArgumentException("Недопустимые значения для k или d.");
            }
            int dayOfWeek = (k % 7 + d - 1) % 7;

            // Сокращенная форма switch для определения названия дня
            string weekday = dayOfWeek switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => throw new ArgumentException("Некорректный день недели.")
            };
            return weekday;
        }
    
    }
}