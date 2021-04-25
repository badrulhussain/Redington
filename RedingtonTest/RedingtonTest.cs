using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Redington.BusinessLayer.Logic;
using Redington.BusinessLayer.Logic.ILogic;
using Redington.Models;
using Redington.Utility;

namespace RedingtonTest
{
    [TestClass]
    public class RedingtonTest
    {
        [TestMethod]
        public void ProbabilityCalculationToTestTheCalculation()
        {
            // Arrange
            var probability = new Probability()
            {
                A = 0.5f,
                B = 0.5f,
                FunctionType = SD.Function1
            };

            float result = 0f,
                expectedValue = 0.25f;

            var mockProbabilityCalculation = new Mock<IProbabilityCalculation>();

            // Act
            mockProbabilityCalculation.Setup(x => x.Get(probability)).Returns(result);

            // Asert
            Assert.Equals(expectedValue, result);

        }
    }
}
