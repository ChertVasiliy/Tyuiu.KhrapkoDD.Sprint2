using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhrapkoDD.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string CardSuit(int m)
        {
            string res;
            switch (m)
            {
                case 1:
                    res = "пики";
                    break;
                case 2:
                    res = "трефы";
                    break;
                case 3:
                    res = "бубны";
                    break; ;
                case 4:
                    res = "червы";
                    break;
                default:
                    throw new ArgumentException($"Масть должна быть (1 <= m <= 4). Значение{m}");
            }
            return res;
        }
    }
}