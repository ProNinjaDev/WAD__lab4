using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    // Функция Гаусса
    internal class Fun5 : IFunction
    {
        public double calc(double x, double z)
        {
            double sigmaSquared = 2.0;
            return Math.Exp(-(x * x + z * z) / (2 * sigmaSquared));
        }
    }
}
