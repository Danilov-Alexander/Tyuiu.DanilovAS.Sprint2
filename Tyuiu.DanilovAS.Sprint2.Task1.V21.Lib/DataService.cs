using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            ///Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
            ///но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,
            ///последовательность операций не должна нарушаться), а также арифметических выражений,
            ///которая вернет логическую последовательность(массив): (False, False, False, False, True, False),
            ///при a = 696, b = 987, c = 696, d = 155
            bool[] temp = new bool[6];
            temp[0] = (a < b) && (c < d) ; // False
            temp[1] = (a < b) ^ (c > d) ; // False
            temp[2] = (a > b) & (c < d); // False
            temp[3] = (a > b) || (c < d);// False
            temp[4] = (a < b) & (c > d); // True
            temp[5] = (a ==b) || (c == d); //False
            return temp;
        }
    }
}
