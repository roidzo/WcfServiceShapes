using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WcfService1;
using WcfService1.Services;
using Serilog;
using WcfService1.Core.Enums;
using WcfService1.Core;

namespace WcfService.Test
{
    [TestClass]
    public class UnitTestEndToEnd
    {
        private Mock<ILogger> _logger;
        private WcfService1.IQuadrilateralTypeService _service;

        [TestInitialize]
        public void StartUp()
        {
            _logger = new Mock<ILogger>();
            _service = new QuadrilateralTypeService(_logger.Object, new QuadrilateralService(_logger.Object));
        }


        [TestMethod]
        public void TestEndToEndParallelogram()
        {
            //Arrange

            //Act
            var result = _service.GetQuadrilateralType(2, 3, 2, 3, 45, 135, 45, 135);

            //Assert
            Assert.AreEqual(result, Helper.GetEnumDescription(QuadrilateralTypeEnum.Parallelogram));
        }

    }
}
