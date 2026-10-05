using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FedorovskikhEO.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string res;

            if (n > 1)
            {
                res = (n - 1) + "." + m;
            }
            else
            {
                switch (m)
                {
                    case 2:
                        res = "31.1";
                        break;

                    case 3:
                        res = "28.2";
                        break;

                    case 4:
                        res = "31.3";
                        break;

                    case 5:
                        res = "30.4";
                        break;

                    case 6:
                        res = "31.5";
                        break;

                    case 7:
                        res = "30.6";
                        break;

                    case 8:
                        res = "31.7";
                        break;

                    case 9:
                        res = "31.8";
                        break;

                    case 10:
                        res = "30.9";
                        break;

                    case 11:
                        res = "31.10";
                        break;

                    case 12:
                        res = "30.11";
                        break;

                    default:
                        res = "Некорректная дата";
                        break;
                }
            }

            return res;
        }
    }
}