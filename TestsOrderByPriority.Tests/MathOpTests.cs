using Xunit.Abstractions;

namespace TestsOrderByPriority.Tests
{
    [TestCaseOrderer("TestsOrderByPriority.Tests.TestSequenceOrder", "TestsOrderByPriority.Tests")]
    public class MathOpTests
    {
        private MathOperations mathOperations;
        private readonly ITestOutputHelper output;
        private static int ctr = 0;

        public MathOpTests(ITestOutputHelper output)
        {
            this.output = output;
            mathOperations = new MathOperations();
        }

        [Fact, TestPriority(3)]
        public void TestAddition()
        {
            //arrange
            int num1 = 5;
            int num2 = 5;
            double result = 0;

            //act
            ctr++;
            result = mathOperations.Addition(num1, num2);
            output.WriteLine($"Test Addition priority {ctr}");

            //assert
            Assert.Equal(10, result);
        }

        [Fact, TestPriority(4)]
        public void TestSubtraction()
        {
            //arrange
            int num1 = 5;
            int num2 = 5;
            double result = 0;

            //act
            ctr++;
            result = mathOperations.Subtraction(num1, num2);
            output.WriteLine($"Test Subtraction priority {ctr}");

            //assert
            Assert.Equal(0, result);
        }

        [Fact, TestPriority(1)]
        public void TestMultiplication()
        {
            //arrange
            int num1 = 5;
            int num2 = 5;
            double result = 0;

            //act
            ctr++;
            result = mathOperations.Multiplication(num1, num2);
            output.WriteLine($"Test Multiplication priority {ctr}");

            //assert
            Assert.Equal(25, result);
        }

        [Fact, TestPriority(2)]
        public void TestDivision()
        {
            //arrange
            int num1 = 5;
            int num2 = 5;
            double result = 0;

            //act
            ctr++;
            result = mathOperations.Division(num1, num2);
            output.WriteLine($"Test Division priority {ctr}");

            //assert
            Assert.Equal(1.0, result);
        }
    }
}