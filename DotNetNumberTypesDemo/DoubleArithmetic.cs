using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNumberTypesDemo
{
    public class DoubleArithmetic
    {
        public void CalculateDoubles()
        {
            var value1 = .1;
            var value2 = 10.0;

            var calc1 = value1 + value1 + value1 + value1 + value1 + value1 + value1 + value1 + value1 + value1;
            var calc2 = value1 * value2;

            Console.WriteLine("Addition result: " + calc1.ToString("R"));
            Console.WriteLine("Multiplication result: " + calc2.ToString("R"));
        }
    }
}
