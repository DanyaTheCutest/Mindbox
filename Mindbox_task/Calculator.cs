using Mindbox_task.Abstract;
using Mindbox_task.Enums;
using Mindbox_task.Repository;

namespace Mindbox_task
{
    public class Calculator
	{
		private IShape shape;

        public Calculator(ShapeType shapeType, double radius)
        {
            if (shapeType != ShapeType.Circle)
                throw new ArgumentException("Circle ShapeType expected");

            shape = new Circle(radius);
        }

        public Calculator(ShapeType shapeType, double ASide, double BSide, double CSide)
        {
            if (shapeType != ShapeType.Triangle)
                throw new ArgumentException("Triangle ShapeType expected");

            shape = new Triangle(ASide, BSide, CSide);
        }

        //public Calculator(ShapeType shapeType, double ASide, double BSide, double CSide, double DSide)
        //{
        //    //Какая-то логика создания фигур с 4+ сторонами
        //    //Для этого enum ShapeType создавался изначально
        //}

        public double Calculate()
        {
            return shape.GetArea();
        }
    }
}
