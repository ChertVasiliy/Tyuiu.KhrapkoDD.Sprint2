using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhrapkoDD.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetComparisonResults(int x, int y)
        {
            return new bool[]
            {
                x == y,        // False
                x != y,        // True
                x < y,         // False
                x > y,         // True
                x <= y,        // False
                x >= y         // True
            };
        }
    }
}