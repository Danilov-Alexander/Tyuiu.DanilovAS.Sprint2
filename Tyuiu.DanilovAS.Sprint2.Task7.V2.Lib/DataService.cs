using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y) 
        {

            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((y*x)/2)<0 && (x/(2*y)<0))
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
