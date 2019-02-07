using System;

namespace Complex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double re, im, mod, arg;

            Console.Write("Введите действительную часть комплексного числа re = ");
            re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа im = ");
            im = Convert.ToDouble(Console.ReadLine());
            var z1 = Complex.Complex_FromCartesian(re, im);

            Console.Write("Введите модуль комплексного числа mod = ");
            mod = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите аргумент комплексного числа arg = ");
            arg = Convert.ToDouble(Console.ReadLine());
            var z2 = Complex.Complex_FromPolar(mod, arg);

            Console.WriteLine("Первое комплексное число z = {0} + {1}*i", z1.Re, z1.Im);
            Console.WriteLine("Второе комплексное число z = {0} + {1}*i", z2.Re, z2.Im);
            Console.ReadKey();
        }
    }

    public class Complex
    {
        public Complex() { }

        private Complex(double _re, double _im)
        {
            Re = _re;
            Im = _im;
        }

        public static Complex Complex_FromCartesian(double _re, double _im)
        {
            return new Complex(_re, _im);
        }

        public static Complex Complex_FromPolar(double _mod, double _arg)
        {
            var _re = _mod * Math.Cos(_arg);
            var _im = _mod * Math.Sin(_arg);
            return new Complex(_re, _im);
        }

        public static Complex operator +(Complex num1, Complex num2)
        {
            return new Complex(num1.Re + num2.Re, num1.Im + num2.Im);
        }

        public static Complex operator -(Complex num1, Complex num2)
        {
            return new Complex(num1.Re - num2.Re, num1.Im - num2.Im);
        }

        public double Re { get; private set; }
        public double Im { get; private set; }
    }
}