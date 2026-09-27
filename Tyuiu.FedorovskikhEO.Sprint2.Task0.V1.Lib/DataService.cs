using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool [] res = new bool[6];
            res[0] = x!=y;
            res[1] = x==y;
            res[2] = x>y;
            res[3] = x<y;
            res[4] = x+2>y;
            res[5] = x+1<y;
            return res; 
        }
    }
}
