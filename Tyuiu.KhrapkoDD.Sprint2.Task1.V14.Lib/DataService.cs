using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhrapkoDD.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            // a = 185, b = 216, c = 174, d = 917.
            res[0] = a < b && c > d; // false
            res[1] = a != b || c == d; // true
            res[2] = c < b & a < d; // true
            res[3] = a <= b || b >= d; // true
            res[4] = b > a && d > c; // true
            res[5] = !(b < a) & (c >=d); //false
            return res;

        }
    }
}