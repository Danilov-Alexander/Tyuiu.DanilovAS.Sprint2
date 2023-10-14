using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string[] suit = new string[4] { "пики", "трефы", "бубны", "червы" };

            switch (value2)
            {
                case 6:
                    return $"Шестёрка {suit[value1 - 1]}";
                case 7:
                    return $"Семёрка {suit[value1 - 1]}";
                case 8:
                    return $"Восьмёрка {suit[value1 - 1]}";
                case 9:
                    return $"Девятка {suit[value1 - 1]}";
                case 10:
                    return $"Десятка {suit[value1 - 1]}";
                case 11:
                    return $"Валет {suit[value1 - 1]}";
                case 12:
                    return $"Дама {suit[value1 - 1]}";
                case 13:
                    return $"Король {suit[value1 - 1]}";
                case 14:
                    return $"Туз {suit[value1 - 1]}";
                default:
                    return "Некорректный ввод, попробуйте снова";
                    
            }

        }
    }
}
