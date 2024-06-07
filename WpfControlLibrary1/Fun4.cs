using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    internal class Fun4 : IFunction
    {
        public double calc(double x, double z)
        {
            double result = 0.0;
            for (int i = 1; i <= 5; i++)
            {
                result += i * Math.Cos((i + 1) * x + i) * Math.Cos((i + 1) * z + i);
            }
            return result;
        }
    }       
}
