using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Redington.BusinessLayer.Logic.ILogic;
using Redington.Controllers;
using Redington.Models;
using Redington.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redington.Tests
{
    [TestClass]
    public class ProbabilitiesCalculatorControllerTests
    {
        [TestMethod]
        public void Create_ReturnsARedirectToActionResult()
        {
            // Arrange
            var probabilityFunction1Model = new Probability()
            {
                A = 0.5f,
                B = 0.5f,
                FunctionType = SD.Function1
            };

            var mockProbabilityCalculation = new Mock<IProbabilityCalculation>();

            var controller = new ProbabilitiesCalculatorController(mockProbabilityCalculation.Object);

            // Act
            var result = controller.Create(probabilityFunction1Model);

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
        }
    }
}
