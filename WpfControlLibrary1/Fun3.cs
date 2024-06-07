using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    internal class Fun3 : IFunction
    {
        public double calc(double x, double z)
        {
            return Math.Sin(x) * Math.Pow(Math.Sin(x * x / Math.PI), 20) + Math.Sin(z) * Math.Pow(Math.Sin(2 * z * z / Math.PI), 20);
        }
    }
 }   

