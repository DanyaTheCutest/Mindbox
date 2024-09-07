using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox_task.Abstract;

namespace Mindbox_task.Repository
{
    internal class Circle : IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
            if (!IsCorrect())
                throw new ArgumentException("Radius must be greater than 0");
        }

        public double GetArea()
        {
            return Math.PI * (_radius * _radius);
        }

        public bool IsCorrect()
        {
            if (_radius > 0)
                return true;
            return false;
        }
    }
}
