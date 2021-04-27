using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Redington.BusinessLayer.Logic;
using Redington.BusinessLayer.Logic.ILogic;
using Redington.DataAccess.Repository.IRepository;
using Redington.Models;
using Redington.Utility;

namespace Redington.Tests
{
    [TestClass]
    public class ProbabilityCalculationTests
    {
        [TestMethod]
        public void Set_ProbabilityCalculationToTestTheCalculation()
        {
            // Arrange
            var probabilityFunction1 = new Probability()
            {
                A = 0.5f,
                B = 0.5f,
                FunctionType = SD.Function1
            };

            var probabilityFunction2 = new Probability()
            {
                A = 0.5f,
                B = 0.5f,
                FunctionType = SD.Function2
            };

            var mockCalculationLogRepository = new Mock<ICalculationLogRepository>();

            var probabilityCalc = new ProbabilityCalculation(mockCalculationLogRepository.Object);

            float function2ExpectedValue = 0.75f,
                function1ExpectedValue = 0.25f;

            // Act
            var function1Result = probabilityCalc.Set(probabilityFunction1);
            var function2Result = probabilityCalc.Set(probabilityFunction2);

            // Assert
            Assert.AreEqual(function1ExpectedValue, function1Result);
            Assert.AreEqual(function2ExpectedValue, function2Result);

        }
    }
}
