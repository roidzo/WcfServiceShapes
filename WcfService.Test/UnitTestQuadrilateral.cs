using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WcfService1;
using WcfService1.Services;
using Serilog;
using WcfService1.Core.Enums;
using WcfService1.Core;
using WcfService1.BusinessLogic;

namespace WcfService.Test
{
    [TestClass]
    public class UnitTestQuadrilateral
    {
        private Mock<IQuadrilateral> _quadrilateral;
        private Mock<ILogger> _logger;

        [TestInitialize]
        public void StartUp()
        {
            _quadrilateral = new Mock<IQuadrilateral>();
            _logger = new Mock<ILogger>();
        }


        #region Test Quadrilateral implementation

        [TestMethod]
        public void TestValidQuadrilateral()
        {
            //Arrange
            Exception quadCreationException = null;

            //Act
            try
            {
                IQuadrilateral quad = new Quadrilateral(2, 3, 2, 3, 45, 135, 45, 135);
            }
            catch (Exception ex)
            {
                quadCreationException = ex;
            }

            //Assert
            Assert.IsNotNull(quadCreationException);
            Assert.IsInstanceOfType(quadCreationException, typeof(ArgumentException));
            Assert.AreEqual("", quadCreationException.Message);
        }

        #endregion

    }
}
