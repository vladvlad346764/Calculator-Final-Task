using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Methods
    {
            #region Const
            private const byte regresNum = 1;
            private const byte squareNum = 2;
            #endregion

        

            public static double Sum(double a, double b)
            {
                return a + b;
            }

            public static double Subtraction(double a, double b)
            {
                return a - b;
            }

            public static double Multiplication(double a, double b)
            {
                return a * b;
            }

            public static double Division(double a, double b)
            {
                return a / b;
            }

            //Метод обратного числа
            public static double RegresNum(double a)
            {
                return regresNum / a;
            }

                     

            public static double SquareNumber(double number)
            {
                double result = Math.Pow(number, squareNum);

                return result;
            }
        }
    }



