using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    #region Class
    class ClassComplex
    {
        double im;
        double re;

        public ClassComplex()
        {
            im = 0;
            re = 0;
        }

        public ClassComplex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        public ClassComplex Plus(ClassComplex x2)
        {
            ClassComplex x3 = new ClassComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public ClassComplex Minus(ClassComplex x2)
        {
            ClassComplex x3 = new ClassComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        public ClassComplex aXb(ClassComplex x2)
        {
            ClassComplex x3 = new ClassComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }


        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }


        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }
    #endregion
    #region Struct
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public Complex aXb(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    #endregion
    #region Main
    class Program
    {
        static void Main(string[] args)
        {

            Complex complex1;
            complex1.re = 1;
            complex1.im = 2;

            Complex complex2;
            complex2.re = 3;
            complex2.im = 4;

            Console.WriteLine("Выберите вариант демонстрации работы приложения:\n1 - Стуктура\n2 - Класс\n0 - Завершение работы программы.");
            int var;
            do
            {
                Console.Write("Введите число: ");
                var = int.Parse(Console.ReadLine());
                switch(var)
                {
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Завершение работы программы");
                        break;
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Вычисления в структуре:");
                        Complex result = complex1.Plus(complex2);
                        Console.WriteLine("Суммой:  " + complex1.ToString() + " и " + complex2.ToString() + " является " + result.ToString());
                        result = complex1.Minus(complex2);
                        Console.WriteLine("Разностью: " + complex1.ToString() + " и " + complex2.ToString() + " является " + result.ToString());
                        result = complex1.aXb(complex2);
                        Console.WriteLine("Произведением: " + complex1.ToString() + " и " + complex2.ToString() + " является " + result.ToString());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Вычисления в классе:");
                        ClassComplex classcomplex1 = new ClassComplex(1, 2);
                        ClassComplex classcomplex2 = new ClassComplex(3, 4);
                        ClassComplex classresult = classcomplex1.Plus(classcomplex2);
                        Console.WriteLine("Суммой: " + classcomplex1.ToString() + " и " + classcomplex2.ToString() + " является " + classresult.ToString());
                        classresult = classcomplex1.Minus(classcomplex2);
                        Console.WriteLine("Разностью: " + classcomplex1.ToString() + " и " + classcomplex2.ToString() + " является " + classresult.ToString());
                        classresult = classcomplex1.aXb(classcomplex2);
                        Console.WriteLine("Произведением: " + classcomplex1.ToString() + " и " + classcomplex2.ToString() + " является " + classresult.ToString());
                        break;

                }
                    

            }
            while (var != 0);



           


            Console.ReadKey();
        }
    }
    #endregion
}
