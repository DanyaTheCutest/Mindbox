using Mindbox_task;
using Mindbox_task.Enums;
using static System.Net.WebRequestMethods;

namespace NUnitTests
{
    public class Tests
	{
		Calculator circleCalc;
		Calculator triangleCalc;
		[SetUp]
		public void Setup()
		{
			circleCalc = new Calculator(ShapeType.Circle, 2);
			triangleCalc = new Calculator(ShapeType.Triangle, 2, 3, 4);
		}

		[Test]
		public void Test1()
		{
			Assert.That(circleCalc.Calculate() == Math.PI * 4);
			Assert.That(triangleCalc.Calculate() == 2.9047375096555625);
		}
	}
}