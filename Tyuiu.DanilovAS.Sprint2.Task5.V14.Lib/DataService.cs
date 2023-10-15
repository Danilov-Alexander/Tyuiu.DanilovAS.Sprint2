using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string res = "";
            int temp =  k % 7 + d -1 ;

            if (temp > 6)
            {
                temp -= 7;
            }

            switch (temp)
            {
                case 0:
                    res = "Воскресенье";
                    break;

                case 1:
                    res =  "Понедельник";
                    break;

                case 2:
                    res = "Вторник";
                    break;

                case 3:
                    res = "Среда";
                    break;

                case 4:
                    res = "Четверг";
                    break;

                case 5:
                    res = "Пятница";
                    break;

                case 6:
                    res = "Суббота";
                    break;

                default:
                    throw new ArgumentException($"Значение temp не может быть больше 7 или меньше одного. Значение temp: {temp}");

            }

            // d - День недели, когда 1-е января является понедельником
            //k - День, который должны найти
            // 365 дней
                return res;
        }
        


    }
}
