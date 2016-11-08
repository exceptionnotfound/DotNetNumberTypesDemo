using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNumberTypesDemo
{
    public class NumberTests
    {
        private int iterations = 100000000;

        public void DoubleAddition()
        {
            Double x = .1;
            Double result = 10 * x;
            Double result2 = x + x + x + x + x + x + x + x + x + x;

            Console.WriteLine("{0} - {1}", result, result2);
            Console.WriteLine("{0:R} - {1:R}", result, result2);
        }

        public void NumbersTest()
        {
            SingleTest();
            DoubleTest();
            DecimalTest();
        }

        private void SingleTest()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Single z = 0;
            for (int i = 0; i < iterations; i++)
            {
                Single x = i;
                Single y = x * i;
                z += y;
            }
            watch.Stop();
            Console.WriteLine("Single: " + watch.ElapsedTicks);
            Console.WriteLine(z);
        }

        private void DoubleTest()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Double z = 0;
            for (int i = 0; i < iterations; i++)
            {
                Double x = i;
                Double y = x * i;
                z += y;
            }
            watch.Stop();
            Console.WriteLine("Double: " + watch.ElapsedTicks);
            Console.WriteLine(z);
        }

        private void DecimalTest()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Decimal z = 0;
            for (int i = 0; i < iterations; i++)
            {
                Decimal x = i;
                Decimal y = x * i;
                z += y;
            }
            watch.Stop();
            Console.WriteLine("Decimal: " + watch.ElapsedTicks);
            Console.WriteLine(z);
        }

        public void DivisionTest()
        {
            DivisionTest1();
            DivisionTest2();
        }

        private void DivisionTest1()
        {
            int maxDiscountPercent = 30;
            int markupPercent = 20;
            Single niceFactor = 30;
            double discount = maxDiscountPercent * (markupPercent / niceFactor);
            Console.WriteLine("Discount (double): {0:R}", discount);
            //Assert.IsTrue(0 == discount);
            //Assert.IsTrue(10 == discount);
            //Assert.IsTrue(20 == discount);
            //Assert.IsTrue(30 == discount);
        }

        private void DivisionTest2()
        {
            byte maxDiscountPercent = 30;
            int markupPercent = 20;
            int niceFactor = 30;
            int discount = maxDiscountPercent * (markupPercent / niceFactor);
            Console.WriteLine("Discount (int): {0}", discount);
            //Assert.IsTrue(0 == discount);
            //Assert.IsTrue(10 == discount);
            //Assert.IsTrue(20 == discount);
            //Assert.IsTrue(30 == discount);
        }
    }
}
