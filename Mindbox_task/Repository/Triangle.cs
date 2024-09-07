using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox_task.Abstract;

namespace Mindbox_task.Repository
{
    internal class Triangle : IShape
    {
        private double A;
        private double B;
        private double C;
        private double p;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            if (!IsCorrect())
                throw new ArgumentException("A triangle with given sides can not exist");

            p = (a + b + c) / 2;
        }
        public double GetArea()
        {
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool isRight()
        {
            if (A > B && A > C)
            {
                if (A * A == B * B + C * C)
                    return true;
            }
            if (B > A && B > C)
            {
                if (B * B == A * A + C * C)
                    return true;
            }
            if (C > A && C > B)
            {
                if (C * C == B * B + A * A)
                    return true;
            }

            return false;
        }

        public bool IsCorrect()
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                return false;
            }
            if (A + B > C && B + C > A)
                return true;

            return false;
        }
    }
}
