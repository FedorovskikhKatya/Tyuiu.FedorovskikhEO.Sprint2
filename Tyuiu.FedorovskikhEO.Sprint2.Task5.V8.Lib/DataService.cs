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
                res = (n - 1).ToString("00") + "." + m.ToString("00");
            }
            else
            {
                switch (m)
                {
                    case 2:
                        res = "31.01";
                        break;

                    case 3:
                        res = "28.02";
                        break;

                    case 4:
                        res = "31.03";
                        break;

                    case 5:
                        res = "30.04";
                        break;

                    case 6:
                        res = "31.05";
                        break;

                    case 7:
                        res = "30.06";
                        break;

                    case 8:
                        res = "31.07";
                        break;

                    case 9:
                        res = "31.08";
                        break;

                    case 10:
                        res = "30.09";
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