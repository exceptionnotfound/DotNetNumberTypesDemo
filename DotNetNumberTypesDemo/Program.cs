using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNumberTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberTests doubles = new NumberTests();
            char input = 'B';

            OutputMenu();

            while(input != 'Q')
            {
                input = Console.ReadLine().ToUpper().First();

                switch (input)
                {
                    case 'D':
                        doubles.DoubleAddition();
                        break;

                    case 'I':
                        doubles.NumbersTest();
                        break;

                    case 'V':
                        doubles.DivisionTest();
                        break;

                    case 'M':
                        OutputMenu();
                        break;

                    default:
                        break;
                }
            }
        }

        protected static void OutputMenu()
        {
            Console.WriteLine("Available Tests:");
            Console.WriteLine("D - Double Addition");
            Console.WriteLine("I - Numbers over Iterations");
            Console.WriteLine("V - Division");
            Console.WriteLine("M - Menu");
            Console.WriteLine("Q - Quit");
        }
    }
}
