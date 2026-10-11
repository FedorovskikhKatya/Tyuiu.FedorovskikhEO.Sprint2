using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (y >= 0 && y <= 4 && x >= Math.Sqrt(y))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
