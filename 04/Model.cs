using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Model
    {
        public double Add(double a, double b) => a + b;
        public double Sub(double a, double b) => a - b;
        public double Mul(double a, double b) => a * b;
        public double Div(double a, double b) => (b != 0 ? a / b : default(double));

    }
}
