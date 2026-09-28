using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a<b)|(c<d);
            res[1] = (a>b)&(c<d);
            res[2] = (d>a)||(c<b);
            res[3] = (a!=c)&&(d<=b);
            res[4] = !(res[0]);
            res[5] = (d<c)^(b>a);
            return res;
        }
    }
}
