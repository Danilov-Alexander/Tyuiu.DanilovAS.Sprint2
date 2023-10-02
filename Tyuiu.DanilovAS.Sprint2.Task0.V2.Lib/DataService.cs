using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task0.V2.Lib
{
    public class DataService : ISprint2Task0V2
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            ///Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций 
            ///не должна нарушаться) и арифметических выражений, 
            ///которая вернет логическую последовательность(массив): (False, True, False, True, False, True), при x = 123, y = 123


            bool[] res = new bool[6]; 
            res[0] = x+1 == y ; //False
            res[1] = x-1 != y ; // True
            res[2] = x+1 < y; // False
            res[3] = x+1 > y ; // True
            res[4] = x+1 <= y ; // False
            res[5] = x >= y; ; // True

            return res;
        }
    }
}
